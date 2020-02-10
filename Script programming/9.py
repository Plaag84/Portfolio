'''
Write a function called largest that is given a list of numbers and the
 function returns the largest number in the list.
'''

z = 0
numerolista = []
x = int(input("Anna listan suuruus: "))
def listalisäys(numerolista,z,x):
	while z<x:
		y= int(input("Anna numero: "))
		numerolista.append(y)
		z = z+1
	print(numerolista)
listalisäys(numerolista,z,x)
def isoin(numerolista,x):
	isoin = numerolista[0]
	for x in numerolista:
		if x > isoin:
			isoin = x
	return isoin
print(isoin(numerolista, x))
