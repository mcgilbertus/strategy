namespace Watches;

public class SingleAlarm: IAlarmStrategy
{
    private Alarm? _alarm;
    
    public void AddAlarm(Alarm alarm)
    {
        _alarm = alarm;
    }

    public IEnumerable<Alarm> GetAlarms(DateTime? from = null, DateTime? to = null)
    {
        var alarms = new List<Alarm>();
        if (_alarm != null)
            alarms.Add(_alarm);
        return alarms;
    }

    public void RemoveAlarm(Alarm alarm)
    {
        if (alarm.AlarmName == _alarm?.AlarmName)
        {
            _alarm = null;
        }
    }

    public Alarm? FindAlarmByName(string alarmName)
    {
        if (_alarm?.AlarmName == alarmName)
        {
            return _alarm;
        }

        return null;
    }
}