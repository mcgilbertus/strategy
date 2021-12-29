namespace Watches;

public interface IAlarmStrategy
{
    void AddAlarm(Alarm alarm);
    IEnumerable<Alarm> GetAlarms(DateTime? @from = null, DateTime? to = null);
    void RemoveAlarm(Alarm alarm);
    Alarm? FindAlarmByName(string alarmName);
}