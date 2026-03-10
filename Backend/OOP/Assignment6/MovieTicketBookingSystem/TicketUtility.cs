namespace MovieTicketBookingSystem;

public static class TicketUtility
{
    public static string GetReceipt(this Ticket ticket)
    {
        string bookedStatus = ticket.IsBooked ? "Booked" : "Not Booked";
        return $"========== RECEIPT ==========\n" +
               $"  Ticket   : #{ticket.TicketId}\n" +
               $"  Movie    : {ticket.MovieName}\n" +
               $"  Price    : {ticket.Price:F2}\n" +
               $"  Final    : {ticket.FinalPrice:F2}\n" +
               $"  Status   : {bookedStatus}\n" +
               $"=============================";
    }

    public static decimal TotalRevenue(this Ticket[] tickets)
    {
        decimal total = 0;
        foreach (Ticket ticket in tickets)
        {
            if (ticket != null)
            {
                total += ticket.Price;
            }
        }
        return total;
    }
}
