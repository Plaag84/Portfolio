'''
Create a function, called sum that takes a list of numbers as a parameter
and it returns the sum of the numbers in the list.

#example lists:
list1 = [1,2,3,4,5] #the function should return 15
list2 = [1,1,1,1]   #the function should return 4
'''

z = 0
numerolista = []
x = int(input("Anna listan suuruus: "))
def listalisäys(numerolista, z, x):
	while z<x:
		y = int(input("Anna numero: "))
		numerolista.append(y)
		z = z+1
	print(numerolista)
listalisäys(numerolista,z,x)
def sum(numerolista):
	yhteensä = 0
	for x in numerolista:
		yhteensä = yhteensä + x
	return yhteensä
print(sum(numerolista))
