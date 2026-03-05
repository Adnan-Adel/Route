namespace MovieTicketBookingSystem;

public static class BookingHelper
{
    private static int bookingCounter = 0;

    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
    {
        double totalPrice = numberOfTickets * pricePerTicket;
        if (numberOfTickets >= 5)
            totalPrice = totalPrice - (0.1 * totalPrice);
        return totalPrice;
    }

    public static string GenerateBookingReference()
    {
        bookingCounter++;
        return $"BK-{bookingCounter}";
    }
}
