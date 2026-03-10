namespace MovieTicketBookingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("VOX Cinema");
            cinema.OpenCinema();

            // a) Cannot create plain Ticket
            // Ticket t = new Ticket("Test", 100);  // ERROR: Cannot create instance of abstract class

            // b) Create tickets and book them
            StandardTicket standardTicket = new StandardTicket("Inception", 80, "A5");
            standardTicket.Book();

            VIPTicket vipTicket = new VIPTicket("Avengers", 200, true);
            vipTicket.Book();

            IMAXTicket imaxTicket = new IMAXTicket("Dune", 100, true);
            imaxTicket.Book();

            // c) Add to cinema and print
            cinema.AddTicket(standardTicket);
            cinema.AddTicket(vipTicket);
            cinema.AddTicket(imaxTicket);
            cinema.PrintAllTickets();

            // d) Polymorphism - call abstract method
            Console.WriteLine("\n--- Polymorphism: Final Price per Ticket ---");
            Ticket[] ticketArray = { standardTicket, vipTicket, imaxTicket };
            foreach (var ticket in ticketArray)
            {
                Console.WriteLine($"{ticket.GetType().Name} => Final Price: {ticket.FinalPrice:F2}");
            }

            // e) Extension method - receipt
            Console.WriteLine("\n--- Extension Method: Receipt ---");
            Console.WriteLine(vipTicket.GetReceipt());

            // f) Extension method - total revenue
            Console.WriteLine("\n--- Extension Method: Total Revenue ---");
            Console.WriteLine($"Total Revenue: {ticketArray.TotalRevenue():F2}");

            // g) Close cinema
            cinema.CloseCinema();
        }
    }
}
