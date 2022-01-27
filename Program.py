from random import randint
import time
import turtle


def clear():
    print("\n" * 80)
    
Question = input("Choose the track: (Type:1 - Short) (Type:2 - Medium) (Type:3 - Long)")
if Question == ("1"):
	print ("Short")
elif Question == ("2"):
	print ("Medium")
elif Question == ("3"):
    print ("Long")


Question = input("Are you betting on group 1 or 2   ")
if Question == ("1"):
	print ("Good Choice!")
elif Question == ("2"):
	print ("Good Choice!")
	
class race:
    def race(rat, rat2 = 2):

        rat = ['1----{,_,">' for i in range(rat)]
        finished = [False,]
        
        rat2 = ['2----{,_,">' for i in range(rat2)]
        finished = [False,]
        

        while not all(finished):

            time.sleep(1)
            clear()

            print('\t' * 9, 'FINISH')

            for i in range(len(rat)):
                x = randint(1, 10)
                spaces = ' ' * x
                rat[i] = spaces + rat[i]
                print(rat[i])
                
        
            finished = map(lambda mouse: False if len(mouse) < 50 else True, rat)
            
            print("--------------------------------------------------------------------")            
            
            for i in range(len(rat2)):
                x = randint(1, 10)
                spaces = ' ' * x
                rat2[i] = spaces + rat2[i]
                print(rat2[i])
                
        
            finished = map(lambda mouse: False if len(mouse) < 50 else True, rat2)
            
    race(3)
    
if Question == ("1"):
	print ("Good Choice!")
elif Question == ("2"):
	print ("Good Choice!")