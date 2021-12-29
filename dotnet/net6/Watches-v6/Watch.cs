namespace Watches;

public class Watch
{
    private readonly DateTime _time;
    private readonly IDisplayStrategy _display;
    private readonly IAlarmStrategy _alarm;

    public Watch(IDisplayStrategy displayStrategy, IAlarmStrategy alarmStrategy) : this(DateTime.Now, displayStrategy, alarmStrategy) {}
    
    public Watch(DateTime time, IDisplayStrategy displayStrategy, IAlarmStrategy alarmStrategy)
    {
        _time = time;
        _display = displayStrategy;
        _alarm = alarmStrategy;
    }

    public void DisplayTime()
    {
        _display.Display(_time);
    }

    public void DisplayAlarms()
    {
        foreach (var alarm in _alarm.GetAlarms())
        {
            Console.WriteLine(alarm);
        }
    }

    public void AddAlarm(Alarm alarm)
    {
        _alarm.AddAlarm(alarm);
    }
}