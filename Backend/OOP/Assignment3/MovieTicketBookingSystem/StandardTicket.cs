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

    // ---------- Override ToString ----------
    public override string ToString()
    {
        return base.ToString() + $" | Type: Standard | Seat: {SeatNumber}";
    }
}
