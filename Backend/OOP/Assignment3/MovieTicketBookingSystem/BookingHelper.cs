namespace MovieTicketBookingSystem;

public static class BookingHelper
{
    private static int bookingCounter = 0;

    public static decimal CalcGroupDiscount(int numberOfTickets, decimal pricePerTicket)
    {
        decimal totalPrice = numberOfTickets * pricePerTicket;
        if (numberOfTickets >= 5)
            totalPrice = totalPrice - (0.1m * totalPrice);
        return totalPrice;
    }

    public static string GenerateBookingReference()
    {
        bookingCounter++;
        return $"BK-{bookingCounter}";
    }
}
