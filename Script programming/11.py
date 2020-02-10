'''
11
Write a function called sum2 that takes a number and sums all the numbers starting from 0 up to that number.

print(sum2(3)) #prints: 6
print(sum2(12)) #prints: 78
'''

numero = int(input("Anna numero niin tää ohjelma mullistaa sun maailman ynnäämällä kaikki numerot yhteen ennen numeroosi asti: "))

def sum2(numero):
	i = 0
	apuri = 0
	for i in range(numero + 1):
		apuri = i + apuri
		i = i+1
	numero = apuri
	return numero
sum2(numero)
print(sum2(numero))