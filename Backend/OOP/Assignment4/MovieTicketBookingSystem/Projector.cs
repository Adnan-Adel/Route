namespace MovieTicketBookingSystem;

public class Projector
{
    // ---------- Properties ----------
    public bool IsOn { get; private set; }

    // ---------- Methods ----------
    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("Projector Started");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("Projector Stopped");
    }
}
