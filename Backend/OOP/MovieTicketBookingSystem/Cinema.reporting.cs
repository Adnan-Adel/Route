
namespace MovieTicketBookingSystem;

public partial class Cinema
{
    public void PrintAllTickets()
    {
        Console.WriteLine($"\n========== {CinemaName} - All Tickets ==========");
        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i] != null)
            {
                tickets[i]!.Print();
            }
        }
        Console.WriteLine("=====================================================\n");
    }

    public void ShowStatistics()
    {
        int bookedCount = 0;
        decimal totalRevenue = 0;

        foreach (var ticket in tickets)
        {
            if (ticket != null)
            {
                if (ticket.IsBooked)
                {
                    bookedCount++;
                    totalRevenue += ticket.FinalPrice;
                }
            }
        }

        Console.WriteLine($"\n--- Statistics ---");
        Console.WriteLine($"Total Tickets: {Ticket.GetTotalTicketsSold()}");
        Console.WriteLine($"Booked: {bookedCount}");
        Console.WriteLine($"Revenue: {totalRevenue:F2}");
    }
}
