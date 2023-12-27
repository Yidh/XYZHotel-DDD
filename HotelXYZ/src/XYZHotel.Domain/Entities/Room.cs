using System.ComponentModel.DataAnnotations;

namespace HotelXYZ.src.XYZHotel.Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le type de chambre est requis.")]
        public string Type { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Le prix par nuit doit être supérieur ou égal à zéro.")]
        public decimal PricePerNight { get; set; }

        // Vous pouvez ajouter d'autres attributs de validation selon les besoins.

        public string[] Amenities { get; set; }
    }
}
