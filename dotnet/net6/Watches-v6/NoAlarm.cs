namespace Watches;

public class NoAlarm : IAlarmStrategy
{
    public void AddAlarm(Alarm alarm)
    {
        Console.WriteLine("Alarms not supported");
    }

    public IEnumerable<Alarm> GetAlarms(DateTime? @from = null, DateTime? to = null)
    {
        return new List<Alarm>();
    }

    public void RemoveAlarm(Alarm alarm)
    {
        Console.WriteLine("Alarms not supported");
    }

    public Alarm? FindAlarmByName(string alarmName)
    {
        return null;
    }
}