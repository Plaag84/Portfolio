'''
25
Extend the function in the previous assignment to handle TypeError which is
caused when you try to divide a number with a non-number (e.g. character).
'''

def calculator(string,x,y):
	if string == "add":
		return (x+y)
	if string == "sub":
		return (x-y)
	if string == "multiply":
		return (x*y)
	if string == "divide":
		try:
			return (x/y)
		except ZeroDivisionError:
			return("None")
		except TypeError:
			return("Wrong type of data")
		return (x/y)
	else:
		print("Error")
print(calculator("add",1,2))
print(calculator("sub",1,2))
print(calculator("multiply",1,2))
print(calculator("divide",1,2))
print(calculator("divide",2,0))
print(calculator("divide",3,"a"))

#Joonatan Ovaska

