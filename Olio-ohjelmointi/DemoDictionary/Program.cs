using System;
using System.Collections.Generic; //Tarvitaan dictionaryyn

//Dictionary Demo

namespace DemoDictionary
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityID { get; set; }
        public override string ToString()
        {
            return $"{Firstname} {Lastname} hetu={SocialSecurityID}"; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testataan dictionaryn-kokoelmaa");
            //luodaan henkilöitä sisältävä kokoelma
            Dictionary<string, Person> persons = new Dictionary<string, Person>();
            //luodaan henkilöitä
            Person person1 = new Person() { Firstname = "John", Lastname = "Doe", SocialSecurityID = "010100A111A" };
            Person person2 = new Person() { Firstname = "Netta", Lastname = "Niilonen", SocialSecurityID = "020200A222A" };
            Person person3 = new Person() { Firstname = "Matti", Lastname = "Mainio", SocialSecurityID = "030304A333A" };
            //lisätään henkilöt dictionaryyn
            persons.Add(person1.SocialSecurityID, person1);
            persons.Add(person2.SocialSecurityID, person2);
            persons.Add(person3.SocialSecurityID, person3);
            //kokoelman läpikäyntiä
            Console.WriteLine("Kokoelmassa on {0} henkilöä", persons.Count);
            Console.WriteLine("Henkilöiden HETUt ovat:");
            foreach (var item in persons.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Henkilöiden tiedot:");
            foreach (var item in persons.Values)
            {
                Console.WriteLine(item);
            }
            //haku kokoelmasta
            string hetu = "020200A222A";
            if (persons.ContainsKey(hetu))
            {
                Console.WriteLine("Löytyi henkilö {0} ", persons[hetu]);
                Console.WriteLine($"Löytyi henkilö {persons[hetu]}");
            }
            else
            {
                Console.WriteLine($"Ei ole henkilö jonka hetu on {hetu}");
            }
        }
    }
}
