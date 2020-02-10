class dog:

	def __init__(self, name, sound, walking_speed, running_speed):
		self.name = name
		self.sound = sound
		self.walking_speed = walking_speed
		self.running_speed = running_speed

	def walk(self):
		print("Walking speed is: ", self.walking_speed, "km/h")

	def run(self):
		print("Running speed is: ", self.running_speed, "km/h")

	def bark(self):
		print("Barking sound is: ", self.sound)

	def print_name(self):
		print("Name is: ", self.name)

dog1 = dog("Wuffe", "Woof!", (20), (15))
dog2 = dog("Maxi", "Röf", (5), (7))
dog3 = dog("Musse", "Buh", (30), (50))

dog1.bark()
dog1.print_name()
dog2.bark()
dog3.run()

dog2.sound = "Rööf"

dog2.bark()

#Joonatan Ovaska
