using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreMoovie.Data;
using StoreMoovie.Dtos;
using StoreMoovie.Models;

namespace StoreMoovie.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly DefaultContext _context;
        private readonly IMapper _mapper;
       



        public MoviesController(DefaultContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Movies
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Movie>>> GetMovie()
        //{
        //    return await _context.Movie.ToListAsync();
        //}
        //public async Task<IActionResult> GetMovie()
        //{
        //    List<MovieDto> movies = _mapper.Map<List<Movie>, List<MovieDto>>
        //        (await _context.Movie
        //       .Include(c => c.Genres)
        //        .ToListAsync());


        //    return Ok(movies);
        //}
        public ActionResult<IEnumerable<Movie>> GetMovies(string query = null)
        {

            List<Movie> movies = new List<Movie>();
            //obtenir uniquement les films disponible
            var movie = _context.Movie.Include(m => m.Name).Where(m => m.NumberAvailable > 0);
          
            if (!string.IsNullOrWhiteSpace(query))
            {
                movies = _context.Movie.Where(c => c.Name.Contains(query)).Include(c => c.Genres).ToList();
            }
            else
            {
                movies = _context.Movie.Include(c => c.Genres).ToList();
            }




            return Ok(movies);
        }

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            var movie = await _context.Movie.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        // PUT: api/Movies/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            _context.Entry(movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Movies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovie(Movie movie)
        {
            _context.Movie.Add(movie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie", new { id = movie.Id }, movie);
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Movie>> DeleteMovie(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();

            return movie;
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}