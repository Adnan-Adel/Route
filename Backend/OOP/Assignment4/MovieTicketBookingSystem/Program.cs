namespace MovieTicketBookingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // a) Create a Cinema and open it
            Cinema cinema = new Cinema("VOX Cinema");
            cinema.OpenCinema();

            // b) Create one of each ticket type
            StandardTicket standardTicket = new StandardTicket("Inception", 120, "A-5");
            VIPTicket vipTicket = new VIPTicket("Avengers", 200, true);
            IMAXTicket imaxTicket = new IMAXTicket("Dune", 180, false);

            // c) Test both versions of SetPrice on one ticket
            Console.WriteLine("========== SetPrice Test ==========");
            Console.WriteLine($"Setting price directly: 150");
            standardTicket.SetPrice(150);
            Console.WriteLine($"Setting price with multiplier: 100 x 1.5 = 150");
            standardTicket.SetPrice(100, 1.5m);
            Console.WriteLine();

            // Add all tickets to cinema
            cinema.AddTicket(standardTicket);
            cinema.AddTicket(vipTicket);
            cinema.AddTicket(imaxTicket);

            // d) Print all tickets (uses polymorphism)
            cinema.PrintAllTickets();

            // e) Call ProcessTicket() with one of the tickets
            Console.WriteLine("========== Process Single Ticket ==========");
            Cinema.ProcessTicket(vipTicket);
            Console.WriteLine();

            // f) Close the Cinema
            cinema.CloseCinema();

            Console.WriteLine("==================================================");
        }
    }
}
