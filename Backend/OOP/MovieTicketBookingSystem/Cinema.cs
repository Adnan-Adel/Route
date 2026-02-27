namespace MovieTicketBookingSystem;

public class Cinema
{
    private Ticket?[] tickets = new Ticket?[20];

    public Ticket? this[int index]
    {
        get
        {
            if (index >= 0 && index < tickets.Length)
                return tickets[index];
            return null;
        }
        set
        {
            if (index >= 0 && index < tickets.Length)
                tickets[index] = value;
        }
    }
    public Ticket? this[string movieName]
    {
        get
        {
            if (string.IsNullOrEmpty(movieName))
                return null;

            foreach (var ticket in tickets)
            {
                if (ticket != null && ticket.MovieName == movieName)
                    return ticket;
            }
            return null;
        }
    }
    public bool AddTicket(Ticket t)
    {
        if (t == null)
            return false;
        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i] == null)
            {
                tickets[i] = t;
                return true;
            }
        }
        return false;
    }
}
