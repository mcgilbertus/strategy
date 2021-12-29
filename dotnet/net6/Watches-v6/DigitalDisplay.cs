namespace Watches;

public class DigitalDisplay : IDisplayStrategy
{
    public void Display(DateTime time)
    {
        Console.WriteLine(time);
    }
}