'''
Write a function called reverse that is given a list and it returns the list
in reverse order.
(Using reverse from the standard library is not allowed) Hint: pop

print(reverse([1,2,3,4])) #prints [4,3,2,1]
print(reverse(["aa", "bb", "cc"])) #prints ["cc", "bb", "aa"]
'''
i = 1
lista = []
x = int(input("Valitse käytettävä lista 1) numerolista 2) kirjainlista: "))
if x == 1:
	lista = [1,2,3,4,5]
elif x == 2:
	lista = ["aa","bb","cc"]
else:
	print("Jotain meni pieleen")
def reverse(lista):
	for i in range(len(lista) - 1):
		lista.insert(i, lista.pop())
		i = i+1
	return lista
print(reverse(lista))
