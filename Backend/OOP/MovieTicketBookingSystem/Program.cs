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

            // Book all tickets
            standardTicket.Book();
            vipTicket.Book();
            imaxTicket.Book();

            // Add tickets to cinema
            cinema.AddTicket(standardTicket);
            cinema.AddTicket(vipTicket);
            cinema.AddTicket(imaxTicket);

            // c) Print all tickets (uses polymorphism)
            cinema.PrintAllTickets();

            // d) Clone a VIP ticket and prove independence
            Console.WriteLine("========== CLONING TEST ==========");
            VIPTicket clonedVip = (VIPTicket)vipTicket.Clone();
            clonedVip.MovieName = "Avatar";
            Console.WriteLine("Original VIP Ticket:");
            vipTicket.Print();
            Console.WriteLine("Cloned VIP Ticket (Modified Movie):");
            clonedVip.Print();
            Console.WriteLine();

            // e) Cancel one ticket and reprint it
            Console.WriteLine("========== CANCELLATION TEST ==========");
            standardTicket.Cancel();
            standardTicket.Print();
            Console.WriteLine();

            // f) Use utility method to print array of printable tickets
            Console.WriteLine("========== PRINTABLE ARRAY ==========");
            IPrintable[] printTickets =
            {
                standardTicket,
                vipTicket,
                imaxTicket,
                clonedVip
            };

            BookingHelper.PrintBookings(printTickets);


            // g) Close the Cinema
            cinema.CloseCinema();

            Console.WriteLine("==================================================");
        }
    }
}
