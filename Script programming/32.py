'''
32
Write a Python script that mimics the cat UNIX tool.
cat reads a given file and prints it’s content to stdout. In other words, you have to write an application that reads a filename from the command line arguments (sys.argv list).

If no command line arguments are given the program should print an error “not enough arguments”.
Hint: sys.argv is a list (remember len())
If the file is not found or it cannot be read the exception should be handled and an error message should be printed (the relevant exception is IOError).

So you execute the application from the command line like this:

$ python assignment29.py test.txt
#contents of test.txt get printed out if the file exists.

#If you execute the application like this:
$ python assignment29.py test2.txt
#Contents of the file test2.txt get printed out.

#Example output:  
$ python assignment29.py players.txt
Lee Sedol
Park Junghwan
Xie He
Chen Yaoye
Tan Xiao
Iyama Yuta
Piao Wenyao
Gu Li
Kong Jie
Jian Weijie
Zhou Ruiyan
Ida Atsushi
Note that both test.txt and test2.txt have to be in the same folder as assignment32.py.

The whole point with these command line arguments is that you can print out different files without changing the actual Python code.
'''
import sys

def cat(filu):
	tiedosto = open(filu)
	count = 0
	for line in open(filu):
		count = count + 1
	for x in range(count):
		print(tiedosto.readline(), end='')
	tiedosto.close()
try:
	print(cat(sys.argv[1]))
#except FileNotFoundError:
	#print("File doesn't exist")
except IOError:
	print("File doesn't exists")
except IndexError:
	print("Not enough arguments")
	
#Joonatan Ovaska