namespace Watches;

public class HandDisplay : IDisplayStrategy
{
    public void Display(DateTime time)
    {
        Console.WriteLine($"Display hour {time} with hands");
    }
}