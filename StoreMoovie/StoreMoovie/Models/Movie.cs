using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMoovie.Models
{
    public class Movie
    {
        private const string V = "La stock est requis";

        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Le nom est obligatoire")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date de sortie")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="La date est requise")]
        public DateTime? DateDeSortie { get; set; }

        [Display(Name = "Nombre de stock")]
       [Range(0 ,100, ErrorMessage ="La valeur doit être comprise entre 0 et 100")]
        [Required(AllowEmptyStrings = false, ErrorMessage = V)]

        public int? Stock { get; set; }

        [ForeignKey("Genres")]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        public Genres Genres { get; set; }

        [Display(Name = "Date de la location")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Date retour de la location")]
        public DateTime ReleaseDate { get; set; }


        
        public int NumberAvailable { get; set; }
    }
}
