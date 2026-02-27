namespace MovieTicketBookingSystem;

public class Ticket
{
    public string? MovieName;
    public TicketType Type;
    public SeatLocation Seat;
    private double Price;

    public Ticket(string moviename, TicketType type, SeatLocation seat, double price)
    {
        MovieName = moviename;
        Type = type;
        Seat = seat;
        Price = price;
    }

    public Ticket(string moviename) : this(moviename, TicketType.Standard, new SeatLocation { Row = 'A', Number = 1 }, 50)
    { }

    public double CalcTotal(double taxPercent)
    {
        double total = Price + (Price * (taxPercent / 100));
        return total;
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
        Console.WriteLine($"Movie   : {MovieName}");
        Console.WriteLine($"Type    : {Type}");
        Console.WriteLine($"Seat    : {Seat.Row}{Seat.Number}");
        Console.WriteLine($"Price   : ${Price}");
        Console.WriteLine($"Total (14% tax) : {CalcTotal(14)}");
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
