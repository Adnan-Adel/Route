namespace MovieTicketBookingSystem;

public class Projector
{
    // ---------- Properties ----------
    public bool IsOn { get; private set; }

    // ---------- Methods ----------
    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("Projector is now ON");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("Projector is now OFF");
    }
}
