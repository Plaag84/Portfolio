using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * T10-Opiskelija

Projekti: T10-Opiskelija
Pisteet: 1

Suunnittele UML-editorilla Opiskelija-luokka, joka sisältää opiskelijalle
tyypillisiä tietoja ja toimintoja. Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma,
joka luo muutamia opiskelijoita ja tallentaa opiskelijat taulukkoon (esim. 5 opiskelijaa).
Tulosta taulukossa olevien opiskelijoiden tiedot käyttämällä toistorakennetta.
 */


namespace T10_Opiskelija
{

    class Opiskelija
    {
        public Opiskelija() { }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string SocialNumber { get; set; }
        public string StudentID { get; set; }
        public bool Status { get; set; }
        public bool Attend(bool decision)
        {
            {

                if (decision == false)
                    return false;
                else
                    return true;
            }
         
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students you want to add?: ");
            int count = int.Parse(Console.ReadLine());
            
            Opiskelija[] newPersons = new Opiskelija[count];

            for (int i = 0; i < count; i++)
            {
                newPersons[i] = new Opiskelija();
                Console.Write("Write firstname for student " + (i + 1) + "\t");
                newPersons[i].Firstname = Console.ReadLine();
                Console.Write("Write surname for student " + (i + 1) + "\t");
                newPersons[i].Surname = Console.ReadLine();
                Console.Write("Write socialnumber for student " + (i + 1) + "\t");
                newPersons[i].SocialNumber = Console.ReadLine();
                Console.Write("Write studentID for student " + (i + 1) + "\t");
                newPersons[i].StudentID = Console.ReadLine();
                Console.Write("Attend to next semester? true for yes, false for no " + (i + 1) + "\t");
                string input = Console.ReadLine();
                bool boolis = bool.Parse(input);
                newPersons[i].Status = newPersons[i].Attend(boolis);
            }

            Console.WriteLine("\nStudents Firstname \tSurname \tSocialNumber \tStudentID \tAttending to semester \n");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(newPersons[i].Firstname + "\t\t" + newPersons[i].Surname + "\t\t" + newPersons[i].SocialNumber + "\t" + newPersons[i].StudentID + "\t" + newPersons[i].Status);
            }

            Console.ReadKey();

        }
    }
}
