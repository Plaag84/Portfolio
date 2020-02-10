'''
12
Write a function called vowels that is a given a string and it returns the number of vowels in that string.
To keep things simple, do not include ö, ä and å.

print(vowels("aaa")) # prints: 3
print(vowels("aba")) # prints: 2
print(vowels("bca")) # prints: 1
'''

def vowels(sana):
	vokaalit = ["a","e","i","o","u","ä","ö","A","E","I","O","U","Ä","Ö"]
	määrä = 0
	for x in sana:
		for i in vokaalit:
			if x == i:
				määrä += 1
	return määrä
print(vowels("aaa")) # prints: 3
print(vowels("aba")) # prints: 2
print(vowels("bca")) # prints: 1