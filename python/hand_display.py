from interfaces import Display_Behavior


class Hand_Display(Display_Behavior):
    def display(self, time):
        print(f'Display hour {time} with hands')

