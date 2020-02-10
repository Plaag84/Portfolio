'''
24
Add a divide operation to your calculator from the previous assignment and
make sure it can handle division by zero(use try and except).
If a division by zero occurs return None.

Note: Returning None like this is usually not the correct choice,
but in this case it is done for simplicity.
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
		return (x/y)
	else:
		print("Error")
print(calculator("add",1,2))
print(calculator("sub",1,2))
print(calculator("multiply",1,2))
print(calculator("divide",1,2))
print(calculator("divide",2,0))

#Joonatan Ovaska
