using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMoovie.Dtos
{
    public class NewRentalDto
    {
        // Id du client
        public int CustomerId { get; set; }
        // Id du film qui est une list
        public List<int> MovieId {get; set;}
    }
}
