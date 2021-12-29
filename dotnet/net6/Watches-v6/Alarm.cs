namespace Watches;

public class Alarm
{
    public DateTime AlarmTime { get; set; }
    public string? AlarmName { get; set; }

    public Alarm(DateTime alarmTime, string? alarmName)
    {
        AlarmTime = alarmTime;
        AlarmName = alarmName;
    }

    public override string ToString()
    {
        return $"'{AlarmName}' for {AlarmTime}";
    }
}