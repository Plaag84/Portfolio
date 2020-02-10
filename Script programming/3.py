'''
Write a Python script that prints out a triangle like the last assignment, but in this case the output should look like this:

          AA
         AAAA
        AAAAAA
       AAAAAAAA
      AAAAAAAAAA
     AAAAAAAAAAAA
    AAAAAAAAAAAAAA
   AAAAAAAAAAAAAAAA
  AAAAAAAAAAAAAAAAAA
 AAAAAAAAAAAAAAAAAAAA
'''

rivit=10
for puu in range (rivit):
	for jee in range(1, rivit - puu): # (1,...) poistaa ekan tyhjän, nollannesrivin
		print(" ", end= "")
	for jee in range(-1, puu): # (-1,...) jättää tyhjän pois
		print("AA", end= "")
	print("\r")
