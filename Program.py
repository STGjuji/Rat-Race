from random import randint
import time



def clear():
    print("\n" * 80)

def race(rat = 2):

    rat = ['----{,_,">' for i in range(rat)]
    finished = [False,]

    while not all(finished):

        time.sleep(1)
        clear()

        print('\t' * 8, '|')

        for i in range(len(rat)):

            x = randint(1, 6)
            spaces = ' ' * x
            rat[i] = spaces + rat[i]
            print(rat[i])

        finished = map(lambda mouse: False if len(mouse) < 50 else True, rat)

race(3)