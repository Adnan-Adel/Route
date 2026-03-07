namespace MovieTicketBookingSystem;

public class StandardTicket : Ticket, ICloneable
{
    // ---------- Additional Properities ----------
    public string SeatNumber { get; set; }

    // ---------- Constructor ----------
    public StandardTicket(string moviename, decimal ticketPrice, string seatNumber)
    : base(moviename, ticketPrice)
    {
        SeatNumber = seatNumber;
    }

    // ---------- Override Method ----------
    public override void Print()
    {
        string status = IsBooked ? "Booked" : "Available";

        Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price:F2} EGP | After Tax: {PriceAfterTax:F2} EGP | Type: Standard | Seat: {SeatNumber} | Status: {status}");
    }

    public Object Clone()
    {
        return new StandardTicket(this.MovieName!, this.Price, this.SeatNumber);
    }
}
