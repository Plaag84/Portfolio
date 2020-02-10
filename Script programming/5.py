# Create a simple script that asks values from the user and adds or removes it to/from a list depending a choice. (Hint: input)

# Script asks values until a user gives some x character.
# When the script closes it prints out all items from a list.


lista = []
while True:
	print(lista)
	z = int(input("Lisää tietoa valitsemalla 1, poista tietoa valitsemalla 2, poistu ohjelmasta valitsemalla 3: "))
	if z == 1:
		x = int(input("Anna tietue paikka: "))
		y = input("Anna tieto tietueelle: ")
		lista.insert(x, y)
		continue
	if z == 2:
		x = int(input("Anna poistettavan tietueen paikka: "))
		lista.pop(x)
		continue
	if z == 3:
		print(lista)
		break
	else:
		continue
