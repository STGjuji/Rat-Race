from random import randint
import time


def clear():
    print("\n" * 80)

def race(mice = 2):

    mice = ['----{,_,">' for i in range(mice)]
    finished = [False,]

    while not all(finished):

        time.sleep(1)
        clear()

        print('\t' * 8, '|')

        for i in range(len(mice)):

            x = randint(1, 6)
            spaces = ' ' * x
            mice[i] = spaces + mice[i]
            print(mice[i])

        finished = map(lambda mouse: False if len(mouse) < 50 else True, mice)

race(3)