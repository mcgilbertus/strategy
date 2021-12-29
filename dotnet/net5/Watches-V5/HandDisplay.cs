using System;

namespace WatchesV5
{

    public class HandDisplay : IDisplayStrategy
    {
        public void Display(DateTime time)
        {
            Console.WriteLine($"Display hour {time} with hands");
        }
    }
}