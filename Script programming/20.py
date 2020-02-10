'''
20
Take values from the previous assignment and write a Python script that does
the following:
Iterates the countrycodes list, uses the codemap dict to get the key name for
the country in question and prints the information from the countries
dict formatted like this:

finland:
    head honcho: Juha Sipila, who is 54 years old
    population: 5.439000 million
sweden:
    head honcho: Stefan Lofven, who is 58 years old
    population: 9.593000 million
norway:
    head honcho: Erna Solberg, who is 54 years old
    population: 5.084000 million
Use \n and ‘\t’ to format the output.
Note: The printing must be done using iteration (for) and
dict lookups(x[y] syntax), manually printing each value will not count as
a correct answer!
'''
countrycodes = ["fi","se","no"]
codemap = {"fi" : "finland","se" : "sweden","no" : "norway"}
countries = {
"finland":{"head honcho":("Juha Sipila"),"age":(54),"population":5.439},
"sweden":{"head honcho":("Stefan Lofven"),"age":(58),"population":9.593},
"norway":{"head honcho":("Erna Solberg"),"age":(54),"population":5.084},
}
#print(countrycodes,codemap,countries)
i = 0
for i in range(len(countrycodes)):
	muuttuja = countrycodes[i]
	print(codemap[muuttuja],"\b:")
	muuttuja2 = codemap[muuttuja]
	print("\thead honcho: %s, who is %d years old\n\tpopulation: %f million" % (countries[muuttuja2]["head honcho"],countries[muuttuja2]["age"],countries[muuttuja2]["population"]))

#Joonatan Ovaska
