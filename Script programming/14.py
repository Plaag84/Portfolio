'''
14
Write a function called division which takes two parameters and divides
the first parameter with the second.
Write an exception handler and make the program to tell the
user if there is a ZeroDivisionError.
Otherwise it should return the division of the parameters.
'''

def division(a,b):
	c = 0
	try:
		c = a/b
	except ZeroDivisionError:
		print("Divided by zero!")
	return c
print(division(6,2))
print(division(3,0))
