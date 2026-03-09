namespace MovieTicketBookingSystem;

public partial class Cinema
{

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

    public void BookAllTickets()
    {
        foreach (var ticket in tickets)
        {
            if (ticket != null && !ticket.IsBooked)
            {
                ticket.Book();
            }
        }
    }
}
