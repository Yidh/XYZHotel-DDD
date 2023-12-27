namespace HotelXYZ.src.XYZHotel.Domain.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Room Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public int NumberOfNights { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsConfirmed { get; set; }

        public bool IsValid()
        {
            return Client != null &&
                   Room != null &&
                   CheckInDate != default &&
                   NumberOfNights > 0 &&
                   TotalAmount >= 0;
        }
    }
}
