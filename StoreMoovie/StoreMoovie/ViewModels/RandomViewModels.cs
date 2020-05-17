using StoreMoovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMoovie.ViewModels
{
    public class RandomViewModels
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
