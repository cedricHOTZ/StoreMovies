
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreMoovie.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "La nom est requis")]
        [StringLength(255)]
        public string Name { get; set; }
        // inscrit a une newsletter
      
          
        [DataType(DataType.Date)]
     
        public DateTime? Birthday { get; set; }

       
        public bool IsSubscribedToNewsletter { get; set; }

        //relation avec la table adhesion
       
        [ForeignKey("Adhesions")]
        //Affiche le texte dans le form
        [Display(Name = "choix de l'adhesion")]
        [Required]
        public int AdhesionId { get; set; }

        public Adhesion Adhesion { get; set; }
    }
}
