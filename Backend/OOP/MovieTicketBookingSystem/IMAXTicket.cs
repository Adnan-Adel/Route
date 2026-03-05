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

    // ---------- Override ToString ----------
    public override string ToString()
    {
        string format = Is3D ? "3D" : "2D";
        return base.ToString() + $" | Type: IMAX | Format: {format}";
    }
}
