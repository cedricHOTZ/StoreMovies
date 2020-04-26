using Microsoft.EntityFrameworkCore;
using StoreMoovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreMoovie.Dtos;

namespace StoreMoovie.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Adhesion> Adhesions { get; set; }

        public DbSet<Genres> Genres { get; set; }

        public DbSet<StoreMoovie.Dtos.MovieDto> MovieDto { get; set; }


    }
}

