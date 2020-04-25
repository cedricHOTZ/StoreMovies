using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMoovie.Models
{
    //verifie si l'utilisateur a plus de 18 ans
    public class VerifAge18 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.AdhesionId == 1)
                return ValidationResult.Success;
            if (customer.Birthday == null)
                return new ValidationResult("La date de naissance st requise");

            var age = DateTime.Today.Year - customer.Birthday.Value.Year;
            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Vous devez avoir aumoins 18 ans pour devenir membre");
        }

    }
}
