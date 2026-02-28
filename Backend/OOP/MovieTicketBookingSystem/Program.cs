namespace MovieTicketBookingSystem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n========== Movie Ticket Booking System ==========\n");

        Console.WriteLine("========== Ticket Booking ==========");

        Cinema cinema = new Cinema();

        for (int i = 1; i < 4; i++)
        {
            Console.WriteLine($"\nEnter data for Ticket {i}:");

            Console.Write("Moive Name: ");
            string? MovieName = Console.ReadLine();

            Console.Write("Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int typeChoice);
            TicketType Type = typeChoice switch
            {
                0 => TicketType.Standard,
                1 => TicketType.VIP,
                2 => TicketType.IMAX,
                _ => TicketType.Standard
            };

            Console.Write("Seat Row (A-Z): ");
            char row = char.ToUpper(Console.ReadLine()![0]);

            Console.Write("Seat Number: ");
            isParsed = int.TryParse(Console.ReadLine(), out int seatNumber);

            SeatLocation seat = new SeatLocation { Row = row, Number = seatNumber };

            Console.Write("Price: ");
            isParsed = double.TryParse(Console.ReadLine(), out double price);

            Ticket ticket = new Ticket(MovieName!, Type, seat, price);
            cinema.AddTicket(ticket);
            Console.WriteLine();
        }

        Console.WriteLine("========== All Tickets ==========\n");
        for (int i = 0; i < 3; i++)
        {
            Ticket? ticket = cinema[i];
            if (ticket != null)
            {
                ticket.PrintTicket();
            }
        }

        Console.WriteLine("\n========== Search by Movie ==========\n");
        Console.WriteLine("Enter movie name to search: ");
        string? searchName = Console.ReadLine();
        Ticket? foundTicket = cinema[searchName!];
        if (foundTicket != null)
        {
            Console.Write("Found: ");
            foundTicket.PrintTicket();
        }
        else
        {
            Console.WriteLine("Not found.");
        }

        Console.WriteLine("\n========== Statistics ==========\n");
        Console.WriteLine($"Total Tickets Sold: {Ticket.GetTotalTicketsSold()}");

        string ref1 = BookingHelper.GenerateBookingReference();
        string ref2 = BookingHelper.GenerateBookingReference();
        Console.WriteLine($"\nBooking Reference 1: {ref1}");
        Console.WriteLine($"\nBooking Reference 2: {ref2}");


        double groupPrice = BookingHelper.CalcGroupDiscount(5, 80);
        double originalPrice = 5 * 80;
        double discount = originalPrice - groupPrice;
        Console.WriteLine($"\nGroup Discount (5 tickets x 80 EGP): {groupPrice} EGP (10% off applied)");
        Console.WriteLine($"You saved: {discount} EGP");

        Console.WriteLine("\n==================================================");
    }
}
