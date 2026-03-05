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


    // ---------- Override Method ----------
    public override void PrintTicket()
    {
        string lounge = LoungeAccess ? "Yes" : "No";
        decimal total = PriceAfterTax + ServiceFee;
        Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price:F2} EGP | After Tax: {PriceAfterTax:F2} EGP | Type: VIP | Lounge: {lounge} | Service Fee: {ServiceFee:F2} EGP | Total: {total:F2} EGP");
    }
}
