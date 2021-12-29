import alarm
from alarm import Alarm
from interfaces import Alarm_Behavior


class Multiple_Alarms(Alarm_Behavior):
    def __init__(self):
        self._alarms = []

    def add_alarm(self, alarm):
        self._alarms.append(alarm)

    def get_alarms(self, from_time=None, to_time=None):
        return [alarm for alarm in self._alarms
                if (from_time is None or alarm.alarm_time >= from_time) and
                (to_time is None or alarm.alarm_time <= to_time)]

    def remove_alarm(self, alarm):
        raise NotImplementedError

    def find_alarm_by_name(self, alarm_name):
        raise NotImplementedError
