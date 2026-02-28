namespace MovieTicketBookingSystem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n========== Movie Ticket Booking System ==========\n");

        Console.WriteLine("========== Ticket Booking ==========");

        Ticket[] tickets = new Ticket[3];

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

            tickets[i - 1] = new Ticket(MovieName!, Type, seat, price);
        }

        Console.WriteLine("========== All Tickets ==========\n");
        foreach (Ticket ticket in tickets)
        {
            ticket.PrintTicket();
        }

        Console.WriteLine("\n========== Search by Movie ==========\n");
        Console.WriteLine("Enter movie name to search: ");
        string? movieName = Console.ReadLine();
        bool found = false;
        foreach (Ticket ticket in tickets)
        {
            if (ticket.MovieName == movieName)
            {
                found = true;
                Console.Write("Found: ");
                ticket.PrintTicket();
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Not Found.");
        }

        Console.WriteLine("\n========== Statistics ==========\n");
        Console.WriteLine($"Total Tickets Sold: ");
    }
}
