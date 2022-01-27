import time
from random import randint
from questions import *


def clear():
    print("\n" * 80)
    
print(TrackQuestion)

print(GroupQuestion)

class race:
    def race(rat, rat2 = 2):

        rat = ['1----{,_,">' for i in range(rat)]
        finished = [False,]
        
        rat2 = ['2----{,_,">' for i in range(rat2)]
        finished = [False,]
        

        while not all(finished):

            time.sleep(1)
            clear()

            print('\t' * 8, 'FINISH')

            for i in range(len(rat)):
                x = randint(1, 12)
                spaces = ' ' * x
                rat[i] = spaces + rat[i]
                print(rat[i])
                
        
            finished = map(lambda mouse: False if len(mouse) < 50 else True, rat)
            
            print("--------------------------------------------------------------------")            
            
            for i in range(len(rat2)):
                x = randint(1, 12)
                spaces = ' ' * x
                rat2[i] = spaces + rat2[i]
                print(rat2[i])
                
        
            finished = map(lambda mouse: False if len(mouse) < 50 else True, rat2)
            
    race(3)
