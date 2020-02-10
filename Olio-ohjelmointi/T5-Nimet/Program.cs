using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_Nimet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables

            List<string> names = new List<string>();
            int counter = 0;
            string input = "a";

            // Instructions for user
            Console.WriteLine("Please, give names of students. Empty input will stop the input.");

            // Loop the names from user            
            while (input != "") // Break when empty
            {
                Console.WriteLine("Give a name: ");
                input = Console.ReadLine();

                if (input != "") // If not empty do this
                { 
                    names.Add(input);
                    counter++;
                }
                else
                    break;
                
            }

            Console.WriteLine(counter + " names are given: ");

            names.Sort(); // Auto sort names (alphabetically)

            foreach (string name in names) // Loop the list
                {
                Console.WriteLine(name); // Write each line
                }

        }
    }
}
