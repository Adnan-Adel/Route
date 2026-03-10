namespace MovieTicketBookingSystem;

public class StandardTicket : Ticket
{
    // ---------- Additional Properities ----------
    public string SeatNumber { get; set; }

    // ---------- Constructor ----------
    public StandardTicket(string moviename, decimal ticketPrice, string seatNumber)
    : base(moviename, ticketPrice)
    {
        SeatNumber = seatNumber;
    }

    // implementing abstract property
    public override decimal FinalPrice => Price * 1.14m;

    // ---------- Override Method ----------
    public override void Print()
    {
        string bookedStatus = IsBooked ? "Yes" : "No";
        Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price:F0} | Final: {FinalPrice:F2} | Booked: {bookedStatus}");
    }

    public override Object Clone()
    {
        return new StandardTicket(this.MovieName!, this.Price, this.SeatNumber);
    }
}
