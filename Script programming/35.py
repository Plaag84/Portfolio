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

def read_student_data(file):
	lista = []
	tiedosto = open(file)
	
	
	for line in open(file):
		x = 0
		fields = line.split(";")
		opiskelija = student
		opiskelija.name = fields[0]
		opiskelija.age = fields[1]
		opiskelija.student_id = fields[2]
		opiskelija.courses = fields[3]
		opiskelija[x] = opiskelija
		x = x+1
		
	print(opiskelija)	
	'''
	for line in open(file):
		
		rivi = line.split(";") 
		name, age, student_id, courses = [i.strip() for i in rivi]
		#courses = [i.strip() for i in kurssit]
		opiskelija = student(name, age, student_id, courses)
		print(opiskelija)
	
	tiedosto.close()
	print(opiskelija)
	'''

	
#joe = student("Joe", 25, "f1234")
#josie = student("Josie", 21, "f5678")
#print(joe.list_courses())
#joe.add_course("script programming")
#print(joe.list_courses())
#josie.add_course("network programming")
#josie.add_course("mathematics 2")
#print(josie.list_courses())

print(read_student_data("student-data.txt"))

#Joonatan Ovaska

'''
def cat(filu):
	tiedosto = open(filu)
	count = 0
	for line in open(filu):
		count = count + 1
	for x in range(count):
		print(tiedosto.readline(), end='')
	tiedosto.close()
'''