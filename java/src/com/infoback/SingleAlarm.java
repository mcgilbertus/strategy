package com.infoback;

import java.time.LocalDateTime;
import java.util.ArrayList;

public class SingleAlarm implements IAlarmStrategy {
  private Alarm _alarm;

  @Override
  public void addAlarm(Alarm alarm) {
    this._alarm = alarm;
  }

  @Override
  public Iterable<Alarm> getAlarms(LocalDateTime fromTime, LocalDateTime toTime) {
    ArrayList<Alarm> result = new ArrayList<>();
    if (_alarm != null)
      result.add(_alarm);
    return result;
  }

  @Override
  public void removeAlarm(Alarm alarm) {
    if (_alarm != null && _alarm.getAlarmName().equals(alarm.getAlarmName()))
      _alarm = null;
  }

  @Override
  public Alarm findAlarmByName(String alarmName) {
    if (_alarm != null && _alarm.getAlarmName().equals(alarmName))
      return _alarm;
    return null;
  }
}
