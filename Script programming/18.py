'''
18
This function adds an element to a list inside a dict of lists.
Rewrite it and use a try-except statement which handles a possible KeyError
if the list with the name provided doesn’t exist in the dictionary yet,
instead of checking beforehand whether it does.
Include else and finally clauses in your try-except block:

thedict = {
    "List1": ["Bob","Comes","After","You"],
    "List2": [100,"Hello"]
}

# function takes a dict, a list name and the element
def add_to_list_in_dict(thedict, listname, element):
    if listname not in thedict:
        print("The dict don't have a following key %s" % (listname))
    else:
        thedict[listname].append(element)
        print("Added %s to %s." % (element, listname))


add_to_list_in_dict(thedict, "List1", "Hellou")
add_to_list_in_dict(thedict, "Book", "Page1")
'''

thedict = {
	"List1": ["Bob","Comes","After","You"],
	"List2": [100,"Hello"]
}

def add_to_list_in_dict(thedict, listname, element):
	try:
		thedict[listname].append(element)
	except KeyError:
		print("KeyError!")
	else:
		thedict[listname].append(element)
		print("Added %s to %s." % (element, listname))
	finally:
		print("Case %s closed!" % (listname))
add_to_list_in_dict(thedict, "List1", "Hellou")
add_to_list_in_dict(thedict, "Book", "Page1")

#Joonatan Ovaska
