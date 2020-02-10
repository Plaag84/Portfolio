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
'''
30
Append functionality to a assignment 29.
Add user a possibility to add new items to a file.
'''



def aakkostus(filu):
	tiedosto = open(filu)
	lista = tiedosto.readlines()
	tiedosto.close()
	while True:
		tiedosto = open(filu)
		lista = tiedosto.readlines()
		tiedosto.close()
		lista.sort()
		print(lista)
		lisää = str(input("Lisää tiedostoon eläimiä tai kirjoita 0 lopettaaksesi: "))
		if lisää == "0":
			break
		else:
			tiedosto = open(filu,"a")
			tiedosto.write("{}\n".format(lisää))
			tiedosto.close()
			continue
	tiedosto = open(filu)
	lista = tiedosto.readlines()
	tiedosto.close()
	lista.sort()
	return lista
print(aakkostus("file.txt"))

#Joonatan Ovaska