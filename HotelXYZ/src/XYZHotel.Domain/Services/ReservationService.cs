using HotelXYZ.src.XYZHotel.Domain.Entities;
using HotelXYZ.src.XYZHotel.Domain.Interface;

namespace XYZHotel.Domain.Services
{
    public class ReservationService : IReservationService
    {
      

        public Reservation CreateReservation(Client client, Room room, DateTime checkInDate, int numberOfNights)
        {
            decimal totalAmount = room.PricePerNight * numberOfNights;

         

            var reservation = new Reservation
            {
                Client = client,
                Room = room,
                CheckInDate = checkInDate,
                NumberOfNights = numberOfNights,
                TotalAmount = totalAmount,
                IsConfirmed = false
            };

            // Débit de 50% du montant total
            ProcessPayment(reservation, totalAmount / 2);

            return reservation;
        }

        public bool ConfirmReservation(Reservation reservation)
        {
            if (!reservation.IsConfirmed)
            {
              
                 //confirmation de la réservation
                reservation.IsConfirmed = true;

                // Paiement du reste du montant (l'autre moitié)
                ProcessPayment(reservation, reservation.TotalAmount / 2);

                return true; // La confirmation a réussi
            }

            // La réservation est déjà confirmée, rien à faire.
            return false;
        }

        public bool CancelReservation(Reservation reservation)
        {
            if (!reservation.IsConfirmed)
            {
                // annulation de la réservation
                reservation.IsConfirmed = false;

                // Aucun remboursement en cas d'annulation

                return true; // L'annulation a réussi
            }

            // La réservation est déjà confirmée, l'annulation n'est pas possible.
            return false;
        }

        // Méthode de simulation de paiement (à remplacer par votre logique réelle)
        private void ProcessPayment(Reservation reservation, decimal amount)
        {
            
        }
    }
}
