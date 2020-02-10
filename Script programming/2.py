'''
Write a Python script that prints out a triangle of using the character A.
The height of the triangle should 10 lines. Place the character used for printing in a variable.
Place the height of the triangle in a variable as well. The output should look like this:

A
AA
AAA
AAAA
AAAAA
AAAAAA
AAAAAAA
AAAAAAAA
AAAAAAAAA
AAAAAAAAAA
'''

i=10
for x in range(i):
	for jee in range(x):
		print ("A", end="")
	print("\r")
