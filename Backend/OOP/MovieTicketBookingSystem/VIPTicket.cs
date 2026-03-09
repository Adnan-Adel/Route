namespace MovieTicketBookingSystem;

public class VIPTicket : Ticket
{

    // ---------- Additional Properities ----------
    public bool LoungeAccess { get; set; }
    public decimal ServiceFee { get; set; } = 50;

    // ---------- Constructor ----------
    public VIPTicket(string moviename, decimal ticketPrice, bool loungeAccess)
    : base(moviename, ticketPrice)
    {
        LoungeAccess = loungeAccess;
    }

    // implementing abstract property
    public override decimal FinalPrice => (Price * 1.14m) + ServiceFee;


    // ---------- Override Method ----------
    public override void Print()
    {
        string lounge = LoungeAccess ? "Yes" : "No";
        string bookedStatus = IsBooked ? "Yes" : "No";
        Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {lounge} | Fee: {ServiceFee:F0} | Price: {Price:F0} | Final: {FinalPrice:F2} | Booked: {bookedStatus}");
    }

    public override Object Clone()
    {
        return new VIPTicket(this.MovieName!, this.Price, this.LoungeAccess);
    }
}
