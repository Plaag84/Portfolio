'''
27
Write a Python script that generates a random number between 0 and 20 (0 and 20 are included in the range) and asks the user to guess the number.

Requirements:

The program should ask the number 5 times. If the user guesses correctly the program should print “correct!” and exit.
If the user doesn’t guess correctly after 5 times the program should print “game over, you lost! the correct number was ??” and exit.
The game should display a how many times the user has guessed and how many tries he has left.
If the user inputs a number that is less than 0 or bigger than 20, the game should print an error message and let the user guess again (number of remaining guesses shouldn’t change).
If the user inputs a non-number, the program should print an error and let the user try again (number of remaining guesses shouldn’t change).

Example output:
++ Guessing Game ++
Guess a number between 0 and 20 !
Guess 1/5: a
Not a number, try again
Guess 1/5: 999
The guess should be between 0 and 20, try again
Guess 1/5: -1000
The guess should be between 0 and 20, try again
Guess 1/5: 10
sorry, try again!
Guess 2/5: 5
sorry, try again!
Guess 3/5: 4
sorry, try again!
Guess 4/5: 11
sorry, try again!
Guess 5/5: 12
sorry, try again!
game over, you lost! the correct number was 9
'''
happy = "bad"
a=0
y=5
import random
mystery = random.randint(0,20)
def guessing_game(mystery,a,y,happy):
	print("++ Guessing Game ++")
	print("Guess a number between 0 and 20 !")
	while a < y:
#		arvaus = int(input("Guess %s/%s:" % (a,y)))
		try:
			arvaus = int(input("Guess %s/%s: " % (a+1,y)))
			if arvaus < 0 or arvaus > 20:
				raise ValueError
		except ValueError:
			print("Guess should be between 0 and 20, try again")
			continue
		else:
			if mystery == arvaus:
				print("correct!")
				happy = "ending"
				break
			else:
				print("sorry, try again!")
			a = a+1
	if happy != "ending":
		print("game over, you lost! the correct number was %d" % (mystery))
guessing_game(mystery,a,y,happy)

#Joonatan Ovaska

