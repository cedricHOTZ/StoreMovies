using StoreMoovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMoovie.ViewModels
{
    public class NewCustomerViewModel
    {
        public List<Adhesion> Adhesions { get; set; }
        public Customer Customer { get; set; }
    }
}
