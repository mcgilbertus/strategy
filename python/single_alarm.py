import alarm
from alarm import Alarm
from interfaces import Alarm_Behavior


class Single_Alarm(Alarm_Behavior):
    def __init__(self):
        self._alarm = None

    def add_alarm(self, alarm):
        self._alarm = alarm

    def get_alarms(self, from_time=None, to_time=None):
        result = []
        if self._alarm:
            result.append(self._alarm)
        return result

    def remove_alarm(self, alarm):
        if self._alarm and self._alarm.alarm_name == alarm.alarm_name:
            self._alarm = None

    def find_alarm_by_name(self, alarm_name):
        if self._alarm and self._alarm.alarm_name == alarm_name:
            return self._alarm
        return None