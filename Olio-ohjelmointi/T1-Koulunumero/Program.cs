using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Koulunumero
{
    class Program
    {
        // Metodi
        static void Main(string[] args)
        {
            // Muuttujat
            int point = 0;
            int grade = 0;
            string input;

            // Kysytään käyttäjältä pistemäärä
            Console.WriteLine("Give points : ");
            input = Console.ReadLine();

            // Muutetaan käyttäjän antama teksti (string) kokonaisluvuksi
            point = int.Parse(input); // Huom ei aina välttämättä onnistu, vaan voi aiheuttaa poikkeuksen
            
            // Pistemäärän perusteella arvosana
            if (point < 2)
            {
                grade = 0;
            }
            else if (point < 4)
            {
                grade = 1;
            }
            else if (point < 6)
            {
                grade = 2;
            }
            else if (point < 8)
            {
                grade = 3;
            }
            else if (point < 10)
            {
                grade = 4;
            }
            else
            {
                grade = 5;
            }

            // Näytetään se käyttäjälle
            Console.WriteLine("School number is " + grade.ToString());

            // Loppu

            // https://gitlab.labranet.jamk.fi/M3286/olio-tehtavat/blob/master/Tehtavat/T1-Koulunumero/Capture.PNG

        }
    }
}
