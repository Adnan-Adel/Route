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

    // ---------- Override ToString ----------
    public override string ToString()
    {
        string lounge = LoungeAccess ? "Yes" : "No";
        decimal total = PriceAfterTax + ServiceFee;
        return base.ToString() + $" | Type: VIP | Lounge: {lounge} | Service Fee: {ServiceFee:F2} EGP | Total: {total:F2} EGP";
    }
}
