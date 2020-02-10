'''
13
Write multiple functions that print the following information when called:

dog_sleeps(name, time) #prints: X sleeps Y hours
dog_walks(name, speed) #prints: X walks Y speed
dog_runs(name, speed)  #prints: X runs Y speed
dog_barks(name. sound) #prints: X barks with a sound Y

#For example:
name = "Musti"
dog_walks(name, 10) #Musti walks 10.00km/h speed
dog_barks(name,"wuf wuf") # Musti barks with a sound "wuf wuf"
'''

name = input("Give a name to a doggo: ")
time = int(input("Give a time time of a nap: "))
speed = int(input("Give a number of a walk a speed: "))
sound = input("Descripe the sound: ")


def dog_sleeps(name, time):
	print(name, "sleeps", time, "hours")
def dog_walks(name, speed):
	print(name, "walks", speed, "km/h speed")
def dog_runs(name, speed):
	print(name, "runs", speed*1.5, "km/h speed")
def dog_barks(name, sound):
	print(name, "barks with a sound", sound)
while True:
	x = int(input("Choose your destiny 1) dog sleep 2) dog walks 3) dog runs 4) dog barks 5) quit: "))
	if x == 1:
		dog_sleeps(name,time)
		continue
	elif x == 2:
		dog_walks(name,speed)
		continue
	elif x == 3:
		dog_runs(name,speed)
		continue
	elif x == 4:
		dog_barks(name,sound)
		continue
	elif x == 5:
		break
	else:
		print("Didn't quite get it, please try again")
		continue