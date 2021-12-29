namespace Watches;

public class MultipleAlarms: IAlarmStrategy
{
    private List<Alarm> _alarms;

    public MultipleAlarms()
    {
        _alarms = new List<Alarm>();
    }

    public void AddAlarm(Alarm alarm)
    {
        _alarms.Add(alarm);
    }

    public IEnumerable<Alarm> GetAlarms(DateTime? from = null, DateTime? to = null)
    {
        return _alarms
            .Where(alarm => (alarm.AlarmTime >= from || from == null) && (alarm.AlarmTime <= to || to == null))
            .ToList();
    }

    public void RemoveAlarm(Alarm alarm)
    {
        throw new NotImplementedException();
    }

    public Alarm? FindAlarmByName(string alarmName)
    {
        throw new NotImplementedException();
    }
}