using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMoovie.Models
{
    public class Genres
    {
        [Key]
        public int IdGenre { get; set; }
       
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Movie Movie { get; set; }
    }
}
