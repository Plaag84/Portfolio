'''
17
Make an Error handling for the following errors and test them with
small scripts:

NameError
IndexError
KeyError
'''

sikapossu = [1,2]
avaimet = {}
try:
	sika = possu
except NameError:
	print("Wrong name!")
try:
	print(sikapossu[3])
except IndexError:
	print("Wrong indexvalue!")
try:
	avaimet['hukassa']
except KeyError:
	print("KeyError!")

#Joonatan Ovaska
