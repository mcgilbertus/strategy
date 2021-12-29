package com.infoback;

import java.time.LocalDateTime;

public class HandDisplay implements IDisplayStrategy {
  @Override
  public void display(LocalDateTime time) {
    System.out.println("Display hour "+time+" with hands");
  }
}
