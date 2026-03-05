namespace MovieTicketBookingSystem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========== Cinema Opened ==========\n");

        // a) Create a Cinema and open it
        Cinema cinema = new Cinema("VOX Cinema");
        cinema.OpenCinema();

        // b) Create one of each ticket type (hardcoded data) and add to Cinema

        // Standard Ticket
        StandardTicket standardTicket = new StandardTicket("Inception", 120, "A-5");
        cinema.AddTicket(standardTicket);

        // VIP Ticket
        VIPTicket vipTicket = new VIPTicket("Avengers", 200, true);
        cinema.AddTicket(vipTicket);

        // IMAX Ticket (2D)
        IMAXTicket imaxTicket2D = new IMAXTicket("Dune", 180, false);
        cinema.AddTicket(imaxTicket2D);

        // IMAX Ticket (3D) - price will increase by 30 automatically
        IMAXTicket imaxTicket3D = new IMAXTicket("Midnight in paris", 120, true);
        cinema.AddTicket(imaxTicket3D);

        // c) Print all tickets
        cinema.PrintAllTickets();

        // Display total tickets sold
        Console.WriteLine("\n========== Statistics ==========\n");
        Console.WriteLine($"Total Tickets Sold: {Ticket.GetTotalTicketsSold()}");

        string ref1 = BookingHelper.GenerateBookingReference();
        string ref2 = BookingHelper.GenerateBookingReference();
        Console.WriteLine($"\nBooking Reference 1: {ref1}");
        Console.WriteLine($"\nBooking Reference 2: {ref2}");

        double groupPrice = BookingHelper.CalcGroupDiscount(5, 100);
        double originalPrice = 5 * 100;
        double discount = originalPrice - groupPrice;
        Console.WriteLine($"\nGroup Discount (5 tickets x 100 EGP): {groupPrice} EGP (10% off applied)");
        Console.WriteLine($"You saved: {discount} EGP");

        // d) Close the Cinema
        cinema.CloseCinema();

        Console.WriteLine("\n==================================================");
    }
}
