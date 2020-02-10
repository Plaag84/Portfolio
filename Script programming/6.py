'''
6
Make a function called compareNumbers that takes two parameters, compares them and returns the greater number
'''

nro1 = 2
nro2 = 9
# sika = possu

nro1 = int(input("Anna luku1: "))
nro2 = int(input("Anna luku2: "))

def compareNumbers(nro1, nro2):
	'''
	vertailee numeroita keskenään
	'''
	if nro1 < nro2:
		return nro2
	elif nro1 > nro2:
		return nro1
	else:
		print("Sama arvo")
		print(nro1,nro2)
print("\nIsompi numero")
compareNumbers(nro1,nro2)
print(compareNumbers(nro1,nro2))

#Joonatan Ovaska