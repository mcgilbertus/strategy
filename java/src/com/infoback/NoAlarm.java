package com.infoback;

import java.time.LocalDateTime;
import java.util.ArrayList;

public class NoAlarm implements IAlarmStrategy {
  @Override
  public void addAlarm(Alarm alarm) {
    System.out.println("Alarms not supported");
  }

  @Override
  public Iterable<Alarm> getAlarms(LocalDateTime fromTime, LocalDateTime toTime) {
    return new ArrayList<Alarm>();
  }

  @Override
  public void removeAlarm(Alarm alarm) {
    System.out.println("Alarms not supported");
  }

  @Override
  public Alarm findAlarmByName(String alarmName) {
    return null;
  }
}
