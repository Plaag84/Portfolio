'''
Write a Python script that prints out all elements with a even index from the given list. Print the index before the element separated by a colon(:)

#Here’s the example list (can be copied to a Python file):  
persons = ["alice", "bob", "craig", "dave", "elisabeth", "frank", "george"]  
#Hint: use the modulus operator(%)!  
'''

#tulosta parilliset

persons = ["alice", "bob", "craig", "dave", "elisabeth", "frank", "george"]

print ("%s" % (persons[1::2]))
print (persons[1::2])

