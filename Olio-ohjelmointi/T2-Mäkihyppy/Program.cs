using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_Mäkihyppy
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numbers = { 0, 0, 0, 0, 0 };
            float total = 0;
            float minimi = 0;
            float maksimi = 0;
            float end = 0;
            int n = 0;
            string input = "";

            Console.WriteLine("Give total of 5 style points\n");

            // Ask 5 times new style points
            while (n < 5)
            { 
            Console.WriteLine(n+1 + ") Give points : "); // Let's not show 0's number as first
            input = Console.ReadLine();
            numbers[n] = float.Parse(input); // Read to numbers [n] position new number
            n++;
            }

            minimi = numbers.Min(); // Learn minimum
            maksimi = numbers.Max(); // Learn maximum
            total = numbers.Sum(); // Count total
            
            end = total - maksimi - minimi; // Remove min + max from total
            Console.WriteLine(end); // Print for user
                        
        }
    }
}
