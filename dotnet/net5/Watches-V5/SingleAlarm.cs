using System;
using System.Collections.Generic;

namespace WatchesV5
{

    public class SingleAlarm : IAlarmStrategy
    {
        private Alarm _alarm;

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
            if (alarm.AlarmName == this._alarm?.AlarmName)
            {
                _alarm = null;
            }
        }

        public Alarm FindAlarmByName(string alarmName)
        {
            if (_alarm?.AlarmName == alarmName)
            {
                return _alarm;
            }

            return null;
        }
    }
}