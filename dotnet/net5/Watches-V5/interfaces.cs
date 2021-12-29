using System;
using System.Collections.Generic;

namespace WatchesV5
{
    public interface IDisplayStrategy
    {
        void Display(DateTime time);
    }
    
    public interface IAlarmStrategy
    {
        void AddAlarm(Alarm alarm);
        IEnumerable<Alarm> GetAlarms(DateTime? fromTime = null, DateTime? toTime = null);
        void RemoveAlarm(Alarm alarm);
        Alarm FindAlarmByName(string alarmName);
    }
}