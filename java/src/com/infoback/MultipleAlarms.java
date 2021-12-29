package com.infoback;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class MultipleAlarms implements IAlarmStrategy {
  private List<Alarm> _alarms = new ArrayList<Alarm>();

  @Override
  public void addAlarm(Alarm alarm) {
    _alarms.add(alarm);
  }

  @Override
  public Iterable<Alarm> getAlarms(LocalDateTime fromTime, LocalDateTime toTime) {
    return _alarms.stream()
      .filter(alarm -> (fromTime == null || alarm.getAlarmTime().isAfter(fromTime)) &&
                       (toTime == null || alarm.getAlarmTime().isBefore(toTime)))
      .collect(Collectors.toList());
  }

  @Override
  public void removeAlarm(Alarm alarm) {
    throw new UnsupportedOperationException();
  }

  @Override
  public Alarm findAlarmByName(String alarmName) {
    throw new UnsupportedOperationException();
  }
}
