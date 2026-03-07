namespace MovieTicketBookingSystem;

public class Ticket : IPrintable
{
    // ---------- Private Fields ----------
    private string? movieName;
    private decimal price;
    private static int ticketCounter = 0;
    private bool isBooked;



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

    public bool IsBooked
    {
        get { return isBooked; }
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

    // ---------- Methods ----------
    public void SetPrice(decimal price)
    {
        Price = price;
    }

    public void SetPrice(decimal basePrice, decimal multiplier)
    {
        Price = basePrice * multiplier;
    }

    public bool Book()
    {
        if (isBooked)
        {
            Console.WriteLine($"Ticket #{TicketId} is already booked.");
            return false;
        }

        isBooked = true;
        return true;
    }

    public bool Cancel()
    {
        if (!isBooked)
        {
            Console.WriteLine($"Ticket #{TicketId} is not booked.");
            return false;
        }

        isBooked = false;
        return true;
    }

    // ---------- Virtual Methods ----------
    public virtual void Print()
    {
        string status = IsBooked ? "Booked" : "Available";
        Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price:F2} EGP | After Tax: {PriceAfterTax:F2} EGP | Status: {status}");
    }


    // ---------- Static Methods ----------
    public static int GetTotalTicketsSold()
    {
        return ticketCounter;
    }
}
