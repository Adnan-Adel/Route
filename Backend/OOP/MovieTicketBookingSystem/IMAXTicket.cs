namespace MovieTicketBookingSystem;

public class IMAXTicket : Ticket
{
    // ---------- Additional Property ----------
    private bool is3D;
    public bool Is3D
    {
        get { return is3D; }
        set
        {
            is3D = value;
            if (is3D)
            {
                Price += 30;
            }
        }
    }

    // ---------- Constructor ----------
    public IMAXTicket(string moviename, decimal ticketPrice, bool is3D)
        : base(moviename, ticketPrice)
    {
        Is3D = is3D;
    }

    // ---------- Override Method ----------
    public override void Print()
    {
        string status = IsBooked ? "Booked" : "Available";

        string format = Is3D ? "3D" : "2D";
        Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price:F2} EGP | After Tax: {PriceAfterTax:F2} EGP | Type: IMAX | Format: {format} | Status: {status}");
    }

    public override Object Clone()
    {
        return new IMAXTicket(this.MovieName!, this.Price - (this.Is3D ? 30 : 0), this.Is3D);
    }
}
