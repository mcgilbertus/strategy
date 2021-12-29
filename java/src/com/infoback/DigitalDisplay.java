package com.infoback;

import java.time.LocalDateTime;

public class DigitalDisplay implements IDisplayStrategy {
  @Override
  public void display(LocalDateTime time) {
    System.out.println(time);
  }
}
