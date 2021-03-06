﻿using StoreMoovie.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMoovie.Dtos
{
    public class CustomerDto
    {
       
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        // inscrit a une newsletter


        [DataType(DataType.Date)]
    
        public DateTime? Birthday { get; set; }


        public bool IsSubscribedToNewsletter { get; set; }

        //Affiche le texte dans le form

        [Display(Name = "Adhesion")]
        public int AdhesionId { get; set; }

        //relation avec la table adhesion

        public AdhesionDto Adhesion { get; set; }
       
       
      
    }
}

