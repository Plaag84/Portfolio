class student:

	def add_course(self, courses):
		self.courses.append(courses)

	def list_courses(self):
		return self.courses

	def __init__(self, name, age, student_id):
		courses = []
		self.courses = courses
		self.name = name
		self.age = age
		self.student_id = student_id

joe = student("Joe", 25, "f1234")
josie = student("Josie", 21, "f5678")
print(joe.list_courses())
joe.add_course("script programming")
print(joe.list_courses())
josie.add_course("network programming")
josie.add_course("mathematics 2")
print(josie.list_courses())

#Joonatan Ovaska
