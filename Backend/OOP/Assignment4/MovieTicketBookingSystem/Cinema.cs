namespace MovieTicketBookingSystem;

public class Cinema
{
    // ---------- Private Fields ----------
    private Ticket?[] tickets = new Ticket[20];
    private Projector projector;

    // ---------- Properties ----------
    public string CinemaName { get; set; }

    // ---------- Constructor ----------
    public Cinema(string cinemaName)
    {
        CinemaName = cinemaName;
        projector = new Projector();
    }

    // ---------- Methods ----------
    public bool AddTicket(Ticket t)
    {
        if (t == null)
            return false;
        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i] == null)
            {
                tickets[i] = t;
                return true;
            }
        }
        return false;
    }

    public void PrintAllTickets()
    {
        Console.WriteLine($"\n========== {CinemaName} - All Tickets ==========");
        bool hasTickets = false;

        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i] != null)
            {
                ProcessTicket(tickets[i]!);
                hasTickets = true;
            }
        }

        if (!hasTickets)
        {
            Console.WriteLine("No tickets sold yet.");
        }
        Console.WriteLine("=====================================================\n");
    }

    public void OpenCinema()
    {
        Console.WriteLine($"\nOpening {CinemaName}...");
        projector.TurnOn();
        Console.WriteLine($"{CinemaName} is now OPEN\n");
    }

    public void CloseCinema()
    {
        Console.WriteLine($"\nClosing {CinemaName}...");
        projector.TurnOff();
        Console.WriteLine($"{CinemaName} is now CLOSED\n");
    }

    // ---------- Static Methods ----------
    public static void ProcessTicket(Ticket t)
    {
        if (t != null)
        {
            t.PrintTicket();
        }
    }
}
