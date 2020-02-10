using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Auton kulutus on 7½ litraa 100 kilometrin matkalla ja bensan hinta on 1,55 Euroa.
Tee metodi, jolla voi laskea tietyn ajomatkan bensakustannukset. Pääohjelmassa
kysytään käyttäjältä ajettu matka, sen jälkeen pääohjelma kutsuu metodia, lähettäen
parametrina ajetun kilometrimäärän. Metodi palauttaa kuluvan bensan määrän sekä
bensaan menevän rahan määrän ja pääohjelma näyttää ne käyttäjälle.
 */

namespace T3_Kulutus
{
    class Program
    {
        // Method
        static void Main(string[] args)
        {
            // Variables
            float driven = 250.0F;
            string input = "";

            Console.WriteLine("Give distance in kilometers: ");
            input = Console.ReadLine();
            driven = float.Parse(input);

            var numbers = Method2(driven); // Read given key and value for variable

            // Console.WriteLine("Gasoline consume is {0} liters and cost is {1} euros", numbers.Key, numbers.Value); // Print using key and value, but too much float numbers

            double a = numbers.Key; // Float to double for rounding
            double b = numbers.Value;
            a = System.Math.Round(a, 2);
            b = System.Math.Round(b, 2);

            Console.WriteLine("Gasoline consume is " + a + " liters and cost is " + b + " euros"); // Rounded printing

        }

        // Method 2
        public static KeyValuePair<float, float> Method2(float driven) // Make 2 floats at KeyValuePair
        {
            // Variables for Method2
            float burn = 7.5F;
            float gasprice = 1.55F;
            float consume = 0.0F;
            float cost = 0.0F;
            float consume2 = 0.0F;
             
            consume = driven * burn / 100; // Calculate consumption
           
            cost = driven * burn / 100 * gasprice; // Calculate cost
          
            
            return new KeyValuePair<float, float>(consume, cost);
        }
    }
}
