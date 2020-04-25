using Microsoft.OData.Edm;
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
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        // inscrit a une newsletter
      
           // [DisplayFormat(DataFormatString="{0:dd/MM/YYYY}")]
        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        //relation avec la table adhesion

        [ForeignKey("Adhesion")]
        //Affiche le texte dans le form
        [Display(Name = "choix de l'adhesion")]
        public int AdhesionId { get; set; }

        public Adhesion Adhesion { get; set; }
    }
}
