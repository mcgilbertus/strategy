package com.infoback;

import java.time.LocalDateTime;

public class Alarm
{
  private LocalDateTime alarmTime;

  private String alarmName;

  public Alarm(LocalDateTime alarmTime, String alarmName)
  {
    this.alarmTime = alarmTime;
    this.alarmName = alarmName;
  }

  @Override
  public String toString()
  {
    return String.format("'%s' set for %s", this.alarmName, this.alarmTime);
  }

  public LocalDateTime getAlarmTime() {
    return alarmTime;
  }

  public void setAlarmTime(LocalDateTime alarmTime) {
    this.alarmTime = alarmTime;
  }

  public String getAlarmName() {
    return alarmName;
  }

  public void setAlarmName(String alarmName) {
    this.alarmName = alarmName;
  }

}
