using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Kiuas
{
    class Stove
    {
        // Constructor
        public Stove() { }
        
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Humidity { get; set; }

        public float Temperature { get; set; }

        public bool Status { get; set; }

        public bool Switchstatus()
        {

            if (Status == false)
                Status = true;
            else
                Status = false;
            return Status;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            // Create new class object instance

            Stove kiuas = new Stove();

            kiuas.Brand = "Harvia";
            kiuas.Model = "C900";

            // Variables

            kiuas.Humidity = 0;
            kiuas.Temperature = 0;
            kiuas.Status = false;
            string input = ""; // For all input values
            string progstatus = "Active"; // For the UI loop
            int usage = 0; // For switch cases

            // UI to Switch LOOP
            while (progstatus == "Active") // Switch off to any status to break
            {
                Console.WriteLine("Your {0} stove {1} on/off status is : {2}. Humidity precentage is adjusted to {3}%. And temperature is adjusted to {4}C°.\n", kiuas.Brand, kiuas.Model, kiuas.Status, kiuas.Humidity, kiuas.Temperature);
                Console.WriteLine("Choose your action:\n 1) Adjust humidity precentage of the stove\n 2) Adjust heating temperature of the stove\n 3) Switch on/off status of the stove\n 4) Quit program");
                input = Console.ReadLine();
                usage = int.Parse(input);

                switch (usage)
                {
                    case 1:
                        {
                            Console.WriteLine("Your stove's humidity precentage is {0}. Adjust the humidity precentage of the stove :", kiuas.Humidity);
                            input = Console.ReadLine();
                            kiuas.Humidity = int.Parse(input);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Your stove's heating temperature is currently {0}C°. Adjust the heating temperature :", kiuas.Temperature);
                            input = Console.ReadLine();
                            kiuas.Temperature = float.Parse(input);
                            break;
                        }
                    case 3:
                        {
                            kiuas.Switchstatus();
                            break;
                        }

                    case 4:
                        {
                            progstatus = "Inactive";
                            break;
                        }
                }

                

                
            }
            
            





        }
    }
}
