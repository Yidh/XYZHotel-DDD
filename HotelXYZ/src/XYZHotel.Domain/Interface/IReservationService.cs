using HotelXYZ.src.XYZHotel.Domain.Entities;

namespace HotelXYZ.src.XYZHotel.Domain.Interface
{
    public interface IReservationService
    {
        Reservation CreateReservation(Client client, Room room, DateTime checkInDate, int numberOfNights);

        bool ConfirmReservation(Reservation reservation);

        bool CancelReservation(Reservation reservation);

      
    }

}
