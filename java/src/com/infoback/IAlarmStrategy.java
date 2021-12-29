package com.infoback;

import java.time.LocalDateTime;

public interface IAlarmStrategy {
  void addAlarm(Alarm alarm);
  Iterable<Alarm> getAlarms(LocalDateTime fromTime, LocalDateTime toTime);
  void removeAlarm(Alarm alarm);
  Alarm findAlarmByName(String alarmName);
}
