using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Olio_Koira
{
    class Dog
    {
        // Ominaisuudet (Properties)
        public string Name { get; set; }
        
        // Konstruktorit (Constructors)
        // HUOM: Luokalla on olemassa ns. oletuskonstruktori, mutta oletuskonstruktori häviää kun määritellään omia konstruktoreita
        public Dog()
        { }
        public Dog(string name)
        {
            Name = name;
        }


        // Metodit (Methods)
        public string Growl()
        {

            return "murrrrrrrr";
        }
        public string Bark(int times)
        {
            string bark = "";
            for (int i = 0; i < times; i++)
            {
                bark += "bfulrphfh ";
            }
            return bark;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan olio eli luodaan instanssi luokasta
            Dog dog = new Dog();

            dog.Name = "Pelle";

            Console.WriteLine("My dog name is {0} and he says {1} {2}", dog.Name, dog.Growl(), dog.Bark(7));

            // Luodaan toinenkin koira
            Dog puppy = new Dog("Rampe");
            Console.WriteLine("Neighbor has a dog, which has name {0} and he says {1} {2}", puppy.Name, puppy.Growl(), puppy.Bark(3));

            // Testaaan taulukon (array) luonti ja käyttö
            Dog[] dogs = new Dog[2];
            dogs[0] = dog; // Pelle ensimmäiseen muistipaikkaan
            dogs[1] = puppy; // Rampe menee toiseen muistipaikkaan

            // Näytetään taulukon koirien tiedot
            foreach (Dog item in dogs)
            {
                Console.WriteLine(item.Name + " " + item.Bark(2));
            }


        }
    }
}
