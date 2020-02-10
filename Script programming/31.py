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
'''
31
Append functionality to a assignment 30.
Add user a possibility to delete existing items from the file.
'''


def aakkostus(filu):
	while True:
		tiedosto = open(filu)
		lista = tiedosto.readlines()
		tiedosto.close()
		lista.sort()
		print(lista)
		print("Toiminnot:\n0) Lopeta\n1) Lisää eläin\n2) Poista eläin\n")
		valinta = int(input("Valitse toiminto: "))
		if valinta == 0:
			break
		if valinta == 1:
			lisää = str(input("Lisää tiedostoon eläin: "))
			tiedosto = open(filu,"a")
			tiedosto.write("{}\n".format(lisää))
			tiedosto.close()
			continue
		if valinta == 2:
			try:
				poista = str(input("Poista eläin tiedostosta kirjoittamalla eläimen nimi: "))
				tiedosto = open(filu)
				lista = tiedosto.readlines()
				tiedosto.close()
				lista.remove("{}\n".format(poista))
				tiedosto = open(filu,"w")
				tiedosto.writelines(lista)
				tiedosto.close()
				continue
			except ValueError:
				print("Eläintä ei löydy, varmista isot ja pienet kirjaimet ja jätä kautta n kirjoittamatta")
				continue
	tiedosto = open(filu)
	lista = tiedosto.readlines()
	tiedosto.close()
	lista.sort()
	return lista
print(aakkostus("file.txt"))

#Joonatan Ovaska