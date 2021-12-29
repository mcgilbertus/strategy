from interfaces import Alarm_Behavior


class No_Alarms(Alarm_Behavior):
    def add_alarm(self, alarm):
        print('Alarms not supported')

    def get_alarms(self, from_time=None, to_time=None):
        return []

    def remove_alarm(self, alarm):
        print('Alarms not supported')

    def find_alarm_by_name(self, alarm_name):
        return None

