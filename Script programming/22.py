'''
Write a function called speeding_ticket that is given the speed of a car and
the speed limit.

The function should return a tuple that contains information about the
mount of the fine and whether or not the driver loses his license.
If the car’s speed exceeds the speed limit by 5 km/h the driver receives
a fine of 100€ and if the car’s speed exceeds
the speed limit by 20km/h he gets a fine of 500€ and loses his license.

The returned tuple should contain the amount of the fine as the first value
and a boolean informing whether or not the driver lost his license
(True loses license, False does not).

print(speeding_ticket(50, 50)) #No fine. Prints: (0, False)
print(speeding_ticket(60, 50)) #100€ fine, doesn't lose license. Prints: (100,
 False)
print(speeding_ticket(100, 50)) #500€ fine, loses license. Prints: (500, True)
'''


def speeding_ticket(speed,speed_limit):
	if speed > (speed_limit+20):
		fine = 500
		license = True
		return (fine,license)
	elif speed > (speed_limit+5):
		fine = 100
		license = False
		return (fine,license)
	else:
		fine = 0
		license = False
		return (fine,license)
print(speeding_ticket(50,50))
print(speeding_ticket(60,50))
print(speeding_ticket(100,50))

#Joonatan Ovaska
