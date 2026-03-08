namespace MovieTicketBookingSystem;

public interface IBookable
{
    bool IsBooked { get; }
    bool Book();
    bool Cancel();
}
