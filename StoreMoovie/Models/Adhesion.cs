using System.ComponentModel.DataAnnotations;

namespace StoreMoovie.Models
{
    public class Adhesion
    {
        //clé primaire
        [Key]
        public int AdhesionId { get; set; }
        public string Name { get; set; }
        // frais d'inscription
        public short SignUpFree { get; set; }
        //durée de l'abonnement
        public byte DurationInMonths { get; set; }
        //taux de remise
        public byte DiscountRate { get; set; }
        

        public Customer Customer { get; set; }
    }
}
