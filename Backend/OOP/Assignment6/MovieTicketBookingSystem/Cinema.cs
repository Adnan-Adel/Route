namespace MovieTicketBookingSystem;

public partial class Cinema
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

}
