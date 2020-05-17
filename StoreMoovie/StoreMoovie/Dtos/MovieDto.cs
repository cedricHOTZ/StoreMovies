using StoreMoovie.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMoovie.Dtos
{
    public class MovieDto
    {
      

    
        public int Id { get; set; }

        
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date de sortie")]

        public DateTime? DateDeSortie { get; set; }

        [Display(Name = "Nombre de stock")]
       

        public int? Stock { get; set; }

      
       

        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        public GenresDto Genres { get; set; }

        
    }
}

