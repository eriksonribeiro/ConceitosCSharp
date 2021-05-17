using ReservationException.Entities.Exceptions;
using System;

namespace ReservationException.Entities
{
    class Reservation
    {
        public int RoomNumber { get; private set; }
        public DateTime Checkin { get; private set; }
        public DateTime Checkout { get; private set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Check-Out date must be after Check-in Date! ");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }
        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);

            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            if (checkin < Checkin || checkout < Checkout)
                throw new DomainException("Reservation dates for update must be future date!");

            if (checkout <= checkin)
                throw new DomainException("Check-Out date must be after Check-in Date! ");

            Checkin = checkin;
            Checkout = checkout;
        }
        public override string ToString()
        {
            return $"Room: {RoomNumber}\nCheck-in: {Checkin.ToString("dd/MM/yyyy")}\nCheck-out: {Checkout:dd/MM/yyyy}\n{Duration()} Nights";
        }
    }
}
