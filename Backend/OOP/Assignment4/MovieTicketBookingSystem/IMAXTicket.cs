namespace MovieTicketBookingSystem;

public class IMAXTicket : Ticket
{
    // ---------- Additional Property ----------
    public bool Is3D { get; }

    // ---------- Constructor ----------
    public IMAXTicket(string moviename, decimal ticketPrice, bool is3D)
        : base(moviename, ticketPrice + (is3D ? 30 : 0))
    {
        Is3D = is3D;
    }

    // ---------- Override Method ----------
    public override void PrintTicket()
    {
        string format = Is3D ? "3D" : "2D";
        Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price:F2} EGP | After Tax: {PriceAfterTax:F2} EGP | Type: IMAX | Format: {format}");
    }
}
