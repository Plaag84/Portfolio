'''
Make a function which takes two parameters, sums them up and checks 
if the sum is divisible by 2.
If it is print "Yes it is!" and if not "Nope." (tip: %)
'''

print("Annappa kaksi numeroa niin katotaan onko niiren yhteissumma kahrella jaollisia nääs")
nro1 = int(input("Anna luku1: "))
nro2 = int(input("Anna luku2: "))

def divisible(nro1, nro2):
	summa = nro1 + nro2
	if summa % 2 == 0:
		print("Yes it is!")
	else:
		print("Nope.")
divisible(nro1,nro2)
