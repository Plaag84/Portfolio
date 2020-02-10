using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
T4-Palindromi

Projekti: T4-Palindromi
Pisteet: 1

Tee ohjelma, joka kysyy käyttäjältä lauseen eli merkkijonon. Sovelluksen tulee
ilmoittaa käyttäjälle oliko annettu merkkijono palindromi.
*/

namespace T4_Palindromi
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "";
            Console.WriteLine("Give a word or a sentence and the program will check if it a palindrome :");
            sentence = Console.ReadLine();

            Console.WriteLine("{0} = {1}", sentence, Palindromer(sentence));
            
        }
        public static bool Palindromer(string value)
        {
            int min = 0;
            int max = value.Length - 1; // Let's read the length of sentence
            while (true)
            {
                if (min > max)
                {
                    return true; // If there's nothing more to check and no failure, it must be TRUE!
                }
                char a = value[min];
                char b = value[max];

                // This sets the first char for the check
                while (!char.IsLetterOrDigit(a)) // When char is not letter or digit
                {
                    min++; // Skip to next char if empty
                    if (min > max) // If no more characters then true
                    {
                        return true; 
                    }
                    a = value[min];
                }

                // This checks for the last char for the check
                while (!char.IsLetterOrDigit(b)) // When char is not letter or digit
                {
                    max--; // Skip to next char if empty
                    if (min > max) // If no more characters then true
                    {
                        return true;
                    }
                    b = value[max];
                }

                if (char.ToLower(a) != char.ToLower(b)) // If no match, go to fail
                {
                    return false; // Fail
                }
                min++; // Next char
                max--; // Next char
            }
            

        }



        
    }
}
