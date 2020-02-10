'''
29
Write a script that reads the animals from the file, saves them to a list and prints items on alphabetical order.

Example file.txt:
Rabbit
Pig
Dog
Horse
Bird
'''

def aakkostus(filu):
	tiedosto = open(filu)
	lista = tiedosto.readlines()
	tiedosto.close()
	lista.sort()
	return lista
print(aakkostus("file.txt"))

#Joonatan Ovaska