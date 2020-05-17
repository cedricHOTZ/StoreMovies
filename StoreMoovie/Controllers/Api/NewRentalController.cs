using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using StoreMoovie.Data;
using StoreMoovie.Dtos;
using StoreMoovie.Models;

namespace StoreMoovie.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewRentalController : ControllerBase
    {
        private readonly DefaultContext _context;
        private readonly IMapper _mapper;

        public NewRentalController(DefaultContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult CreateNewRentals(NewRentalDto newrental)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var customer = _context.Customers.Single(
                c => c.Id == newrental.CustomerId);

            var movies = _context.Movie.Where(
                c =>newrental.MovieId.Contains(c.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("!le film est iintrouvable");

                movie.NumberAvailable--;
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);

            }
            _context.SaveChanges();
            return Ok();
        }
       
    }
}
