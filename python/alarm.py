class Alarm:
    def __init__(self, alarm_time, alarm_name):
        self.alarm_time = alarm_time
        self.alarm_name = alarm_name

    def __str__(self):
        return f"'{self.alarm_name}' set for {self.alarm_time}"

