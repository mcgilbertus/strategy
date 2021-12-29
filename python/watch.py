class Watch():
    def __init__(self, time, display_strategy, alarm_strategy):
        self._time = time
        self._display_strategy = display_strategy
        self._alarm_strategy = alarm_strategy

    def display_time(self):
        self._display_strategy.display(self._time)

    def display_alarms(self):
        for alarm in self._alarm_strategy.get_alarms():
            print(alarm)

    def add_alarm(self, alarm):
        self._alarm_strategy.add_alarm(alarm)
