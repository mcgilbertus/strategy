from alarm import Alarm
from digital_display import Digital_Display
from hand_display import Hand_Display
from multiple_alarms import Multiple_Alarms
from no_alarms import No_Alarms
from single_alarm import Single_Alarm
from watch import Watch
from datetime import datetime

print('Creating watch with hand display and no alarms')
watch1 = Watch(datetime.now(), Hand_Display(), No_Alarms())
watch1.display_time()
print('Adding alarm1')
watch1.add_alarm(Alarm(datetime(2022,1,1,10,34,0), "alarm1"))
print('Adding alarm2')
watch1.add_alarm(Alarm(datetime(2022,1,2,9,0,0), "alarm2"))
print('Alarms set:')
watch1.display_alarms()

print()
print('Creating watch with digital display and single alarms')
watch2 = Watch(datetime.now(), Digital_Display(), Single_Alarm())
watch2.display_time()
print('Adding alarm1')
watch2.add_alarm(Alarm(datetime(2022,1,1,10,34,0), "alarm1"))
print('Adding alarm2')
watch2.add_alarm(Alarm(datetime(2022,1,2,9,0,0), "alarm2"))
print('Alarms set:')
watch2.display_alarms()

print()
print('Creating watch with digital display and multiple alarms')
watch3 = Watch(datetime.now(), Digital_Display(), Multiple_Alarms())
watch3.display_time()
print('Adding alarm1')
watch3.add_alarm(Alarm(datetime(2022,1,1,10,34,0), "alarm1"))
print('Adding alarm2')
watch3.add_alarm(Alarm(datetime(2022,1,2,9,0,0), "alarm2"))
print('Alarms set:')
watch3.display_alarms()

