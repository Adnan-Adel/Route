namespace MovieTicketBookingSystem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n========== Movie Ticket Booking System ==========\n");
        Console.Write("Enter Moive Name: ");
        string? MovieName = Console.ReadLine();

        Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
        bool isParsed = int.TryParse(Console.ReadLine(), out int typeChoice);
        TicketType Type = typeChoice switch
        {
            0 => TicketType.Standard,
            1 => TicketType.VIP,
            2 => TicketType.IMAX,
            _ => TicketType.Standard
        };

        Console.Write("Enter Seat Row (A, B, C...): ");
        char row = char.ToUpper(Console.ReadLine()![0]);

        Console.Write("Enter Seat Number: ");
        isParsed = int.TryParse(Console.ReadLine(), out int seatNumber);

        SeatLocation seat = new SeatLocation { Row = row, Number = seatNumber };

        Console.Write("Enter Price: ");
        isParsed = double.TryParse(Console.ReadLine(), out double price);

        Ticket ticket = new Ticket(MovieName!, Type, seat, price);

        Console.Write("Enter Discount Amount: ");
        isParsed = double.TryParse(Console.ReadLine(), out double discount);

        Console.WriteLine("==== Ticket Info ====");
        ticket.PrintTicket();

        Console.WriteLine("==== After Discount ====");
        Console.WriteLine($"Discount Before: {discount:F2}");
        ticket.ApplyDiscount(ref discount);
        Console.WriteLine($"Discount After: {discount:F2}");

        ticket.PrintTicket();
    }
}
