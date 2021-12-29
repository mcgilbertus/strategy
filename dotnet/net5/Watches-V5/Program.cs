using System;

namespace WatchesV5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Creating watch with hand display and no alarms");
            var watch1 = new Watch(displayStrategy: new HandDisplay(), alarmStrategy: new NoAlarm());
            watch1.DisplayTime();
            Console.WriteLine("Adding alarm1");
            watch1.AddAlarm(new Alarm(new DateTime(2022,1,1,10,34,0), "alarm1"));
            Console.WriteLine("Adding alarm2");
            watch1.AddAlarm(new Alarm(new DateTime(2022,1,2,9,0,0), "alarm2"));
            Console.WriteLine("Alarms set:");
            watch1.DisplayAlarms();

            Console.WriteLine();
            Console.WriteLine("Creating watch with digital display and single alarms");
            var watch2 = new Watch(displayStrategy:new DigitalDisplay(), alarmStrategy:new SingleAlarm());
            watch2.DisplayTime();
            Console.WriteLine("Adding alarm1");
            watch2.AddAlarm(new Alarm(new DateTime(2022,1,1,10,34,00), "alarm1"));
            Console.WriteLine("Adding alarm2");
            watch2.AddAlarm(new Alarm(new DateTime(2022,1,2,9,0,0), "alarm2"));
            Console.WriteLine("Alarms set:");
            watch2.DisplayAlarms();

            Console.WriteLine();
            Console.WriteLine("Creating watch with digital display and multiple alarms");
            var watch3 = new Watch(displayStrategy:new DigitalDisplay(), alarmStrategy:new MultipleAlarms());
            watch3.DisplayTime();
            Console.WriteLine("Adding alarm1");
            watch3.AddAlarm(new Alarm(new DateTime(2022,1,1,10,34,00), "alarm1"));
            Console.WriteLine("Adding alarm2");
            watch3.AddAlarm(new Alarm(new DateTime(2022,1,2,9,0,0), "alarm2"));
            Console.WriteLine("Alarms set:");
            watch3.DisplayAlarms();
        }
    }
}