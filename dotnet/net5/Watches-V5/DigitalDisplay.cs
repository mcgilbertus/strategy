using System;

namespace WatchesV5
{

    public class DigitalDisplay : IDisplayStrategy
    {
        public void Display(DateTime time)
        {
            Console.WriteLine(time);
        }
    }
}