using System.ComponentModel.DataAnnotations;

namespace HotelXYZ.src.XYZHotel.Domain.Entities
{
    public class Wallet
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le client associé au portefeuille est requis.")]
        public Client Client { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Le solde du portefeuille doit être supérieur ou égal à zéro.")]
        public decimal Balance { get; set; }

        [Required(ErrorMessage = "La devise du portefeuille est requise.")]
        public string Currency { get; set; }
    }
}
