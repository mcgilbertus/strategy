package com.infoback;

import java.time.LocalDateTime;

public class Main {

    public static void main(String[] args) {
        System.out.println();
        System.out.println("Creating watch with hand display and no alarms");
        var watch1 = new Watch(new HandDisplay(), new NoAlarm());
        watch1.displayTime();
        System.out.println("Adding alarm1");
        watch1.addAlarm(new Alarm(LocalDateTime.of(2022,1,1,10,34,0), "alarm1"));
        System.out.println("Adding alarm2");
        watch1.addAlarm(new Alarm(LocalDateTime.of(2022,1,2,9,0,0), "alarm2"));
        System.out.println("Alarms set:");
        watch1.displayAlarms();

        System.out.println();
        System.out.println("Creating watch with digital display and single alarms");
        var watch2 = new Watch(new DigitalDisplay(), new SingleAlarm());
        watch2.displayTime();
        System.out.println("Adding alarm1");
        watch2.addAlarm(new Alarm(LocalDateTime.of(2022,1,1,10,34,00), "alarm1"));
        System.out.println("Adding alarm2");
        watch2.addAlarm(new Alarm(LocalDateTime.of(2022,1,2,9,0,0), "alarm2"));
        System.out.println("Alarms set:");
        watch2.displayAlarms();

        System.out.println();
        System.out.println("Creating watch with digital display and multiple alarms");
        var watch3 = new Watch(new DigitalDisplay(), new MultipleAlarms());
        watch3.displayTime();
        System.out.println("Adding alarm1");
        watch3.addAlarm(new Alarm(LocalDateTime.of(2022,1,1,10,34,00), "alarm1"));
        System.out.println("Adding alarm2");
        watch3.addAlarm(new Alarm(LocalDateTime.of(2022,1,2,9,0,0), "alarm2"));
        System.out.println("Alarms set:");
        watch3.displayAlarms();
    }
}
