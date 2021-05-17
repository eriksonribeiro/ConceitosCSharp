using System;
using ReservationException.Entities.Exceptions;


namespace ReservationException.Entities
{
    public static class Menu
    {
        public static void Reservation()
        {
            try
            {
                Console.WriteLine("************************************\nRESERVATION");
                Console.Write("RoomNumber: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

                Console.WriteLine($"\n{reservation}");
                Console.WriteLine("\n************************************\nUPDATE RESERVATION");
                Console.WriteLine("Enter data to update the reservation");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine($"Reservation {reservation}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation; {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error; {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro not expected!; {e.Message}");
            }

        }
        public static void ExtendedExzception() 
        {

        }

    }
}
