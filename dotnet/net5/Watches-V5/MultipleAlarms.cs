using System;
using System.Collections.Generic;
using System.Linq;

namespace WatchesV5
{

    public class MultipleAlarms : IAlarmStrategy
    {
        private readonly List<Alarm> _alarms;

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

        public Alarm FindAlarmByName(string alarmName)
        {
            throw new NotImplementedException();
        }
    }
}