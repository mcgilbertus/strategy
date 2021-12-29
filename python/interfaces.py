from abc import ABC, abstractmethod


class Display_Behavior(ABC):
    @abstractmethod
    def display(self, time):
        pass

class Alarm_Behavior(ABC):
    @abstractmethod
    def add_alarm(self, alarm):
        pass

    @abstractmethod
    def get_alarms(self, from_time=None, to_time=None):
        pass

    @abstractmethod
    def remove_alarm(self, alarm):
        pass

    @abstractmethod
    def find_alarm_by_name(self, alarm_name):
        pass
