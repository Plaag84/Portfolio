'''
14
Write a function called division which takes two parameters and divides
the first parameter with the second.
Write an exception handler and make the program to tell the
user if there is a ZeroDivisionError.
Otherwise it should return the division of the parameters.
'''
'''
15
Update your function so that when the user calls the function
with wrong type as a parameter it says "One or both of your parameters are wrong
type!" (Don't remove the ZeroDivision exception!)
'''

def division(a,b):
	c = 0
	try:
		c = a/b
	except ZeroDivisionError:
		print("Divided by zero!")
	except TypeError:
		print("Wrong datatype error!")
	return c
print(division(6,2))
print(division(3,0))
print(division("a",5))
try:
	print(division(3,5,6))
except TypeError:
	print("Väärä määrä")
