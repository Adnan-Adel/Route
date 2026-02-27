namespace MovieTicketBookingSystem;

public class Ticket
{
    private string? movieName;
    private double price;

    private static int ticketCounter = 0;

    public string? MovieName
    {
        get { return movieName; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                movieName = value;
        }
    }

    public TicketType Type { get; set; }

    public SeatLocation Seat { get; set; }

    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
        }
    }

    public double PriceAfterTax => Price + (Price * 0.14);

    public int TicketId { get; private set; }

    public Ticket(string moviename, TicketType ticketType, SeatLocation seatLocation, double ticketPrice)
    {
        ticketCounter++;
        TicketId = ticketCounter;

        movieName = moviename;
        Price = ticketPrice > 0 ? ticketPrice : 50;
        Type = ticketType;
        Seat = seatLocation;
    }

    public Ticket(string moviename) : this(moviename, TicketType.Standard, new SeatLocation { Row = 'A', Number = 1 }, 50)
    { }

    public static int GetTotalTicketsSold()
    {
        return ticketCounter;
    }

    public void ApplyDiscount(ref double discountAmount)
    {
        if (discountAmount > 0 && discountAmount <= Price)
        {
            Price = Price - discountAmount;
            discountAmount = 0;
        }
    }

    public void PrintTicket()
    {
        Console.WriteLine($"Ticket #{TicketId} | {MovieName} | {Type} | Seat: {Seat.Row}-{Seat.Number} | Price: {Price:F0} EGP | After Tax: {PriceAfterTax:F1} EGP");
    }
}


public enum TicketType
{
    Standard,
    VIP,
    IMAX
}

public struct SeatLocation
{
    public char Row;
    public int Number;
}
