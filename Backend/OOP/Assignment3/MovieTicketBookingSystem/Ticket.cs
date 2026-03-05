namespace MovieTicketBookingSystem;

public class Ticket
{
    // ---------- Private Fields ----------
    private string? movieName;
    private decimal price;
    private static int ticketCounter = 0;



    // ---------- Properities ----------
    public int TicketId { get; private set; }

    public string? MovieName
    {
        get { return movieName; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                movieName = value;
        }
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
        }
    }

    // computed property
    public decimal PriceAfterTax => Price + (Price * 0.14m);

    // ---------- Constructor ----------
    public Ticket(string moviename, decimal ticketPrice)
    {
        ticketCounter++;
        TicketId = ticketCounter;

        movieName = moviename;
        Price = ticketPrice > 0 ? ticketPrice : 50m;
    }

    // ---------- Static Methods ----------
    public static int GetTotalTicketsSold()
    {
        return ticketCounter;
    }


    // ---------- Override ToString ----------
    public override string ToString()
    {
        return $"Ticket #{TicketId} | {MovieName} | Price: {Price:F2} EGP | After Tax: {PriceAfterTax:F2} EGP";
    }
}
