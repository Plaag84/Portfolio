'''
28
Write a Python script that acts a simple calculator.
The script should present the user with a list of numbered actions to perform (addition, substraction, division or multiplication) and two numbers afer that.

If the user inputs an invalid choice the program should print an error and prompt the user to try again.
If the user inputs anything else than numbers the program should print an error and prompt the user to try again.
If the user attempts to divide by zero the program should print an error message.
Print the result as a float
If the user inputs -1 when choosing the action, the program should terminate.
Try to utilize the fact that Python has functions as first class values! You can for example place anonymous functions inside a variables and call them or use reduce function.

Example execution:
0) add
1) sub
2) multiply
3) divide
-1) quit
choice: 0
number: 1
number: 2
The result is: 3.000000
0) add
1) sub
2) multiply
3) divide
-1) quit
choice: 2
number: 5
number: 5
The result is: 25.000000
0) add
1) sub
2) multiply
3) divide
-1) quit
choice: -1
'''

a = 0
while a != -1:
	print("0) add")
	print("1) sub")
	print("2) multiply")
	print("3) divide")
	print("-1) quit")
	try:
		a = int(input("choice: "))
		if a < -1 or a > 3:
			raise ValueError
		if a == -1:
			break
	except ValueError:
		print("\nerror, try again\n")
		continue
	try:
		b = int(input("number: "))
	except ValueError:
		print("\nerror, try again\n")
		continue
	try:
		c = int(input("number: "))
	except ValueError:
		print("\nerror, try again\n")
		continue
	if a == 0:
		print("The result is: %f" % (b+c))
	if a == 1:
		print("The result is: %f" % (b-c))
	if a == 2:
		print("The result is: %f" % (b*c))
	if a == 3:
		try:
			print("The result is: %f" % (b/c))
		except ZeroDivisionError:
			print("\nerror, try again\n")
			continue

#Joonatan Ovaska
