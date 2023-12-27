using System.ComponentModel.DataAnnotations;
namespace HotelXYZ.src.XYZHotel.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est requis.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "L'email est requis.")]
        [EmailAddress(ErrorMessage = "L'email n'est pas dans un format valide.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le numéro de téléphone est requis.")]
        [Phone(ErrorMessage = "Le numéro de téléphone n'est pas dans un format valide.")]
        public string PhoneNumber { get; set; }

        public Wallet Wallet { get; set; }

    }
}
