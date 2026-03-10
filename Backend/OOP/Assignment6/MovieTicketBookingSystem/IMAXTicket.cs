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
        if (is3D)
        {
            Price += 30;
        }
    }

    // implementing abstract property
    public override decimal FinalPrice => Price * 1.14m;

    // ---------- Override Method ----------
    public override void Print()
    {
        string format = Is3D ? "Yes" : "No";
        string bookedStatus = IsBooked ? "Yes" : "No";
        Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {format} | Price: {Price:F0} | Final: {FinalPrice:F2} | Booked: {bookedStatus}");
    }

    public override Object Clone()
    {
        decimal basePrice = Is3D ? Price - 30 : Price;
        return new IMAXTicket(this.MovieName!, basePrice, this.Is3D);
    }
}
