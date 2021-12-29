package com.infoback;

import java.time.LocalDateTime;

public class Watch {
  private final LocalDateTime _time;
  private final IDisplayStrategy _display;
  private final IAlarmStrategy _alarm;

  public Watch(IDisplayStrategy displayStrategy, IAlarmStrategy alarmStrategy)
  {
    this(LocalDateTime.now(), displayStrategy, alarmStrategy);
  }

  public Watch(LocalDateTime time, IDisplayStrategy displayStrategy, IAlarmStrategy alarmStrategy)
  {
    _time = time;
    _display = displayStrategy;
    _alarm = alarmStrategy;
  }

  public void displayTime()
  {
    _display.display(_time);
  }

  public void displayAlarms()
  {
    for(Alarm alarm : _alarm.getAlarms(null, null))
    {
      System.out.println(alarm);
    }
  }

  public void addAlarm(Alarm alarm)
  {
    _alarm.addAlarm(alarm);
  }
}
