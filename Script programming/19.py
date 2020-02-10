'''
19
Write a Python script that contains:

A list called countrycodes containing strings ("fi", "se", "no")
A dict called codemap that has "fi", "se" and "no" as keys and the names of
those countries as values (finland, sweden and norway)

Another dict called countries that contains the country names (finland, sweden
and norway) as keys. The value should be a dict with two items:
head honcho as the key and a tuple with the country’s prime minister’s name
and age as a value
population as the key and a the population of the country as a float.

Make sure you got the syntax correct by printing out countrycodes, codemap and
countries.

To save you from googling that stuff, here is the required information:
Finland
population: 5.439 million
Prime minister: Juha Sipila, 54 years old
Sweden
Population: 9.593 million
Prime minister: Stefan Lofven, 58 years old
Norway
Population: 5.084 million
Prime minister: Erna Solberg, 54 years old
Note: Normally we would use objects to store this kind of information but we
haven’t covered them yet and this assignment is about lists, tuples and dicts.

Omit the umlauts (ä, ö, å etc.)
'''

countrycodes = ["fi","se","no"]
codemap = {"fi" : "finland","se" : "sweden","no" : "norway"}
countries = {
"finland":{"head honcho":("Juha Sipila"),"age":(54),"population":5.439},
"sweden":{"head honcho":("Stefan Lofven"),"age":(58),"population":9.593},
"norway":{"head honcho":("Erna Solberg"),"age":(54),"population":5.084}
}
print(countrycodes,codemap,countries)

#Joonatan Ovaska
