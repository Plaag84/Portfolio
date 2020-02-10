using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace T7_Pesukone
{
    class WM
    {
        // Variables


        // Constructor
        public WM() { }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Selectedprogram { get; set; }

        public int Spinning { get; set; }

        public int Temperature { get; set; }

        public bool Childproof { get; set; }

        public bool Turnedon { get; set; }

        public int Programselection()
        {
            Console.WriteLine("Your washing machine's program is {0}. Choose the program.\n 1) Example program\n 2) Nothing", Selectedprogram);
            //input = Console.ReadLine();
            // usage = int.Parse(input);
            //switch (usage)
            //{
            //    case 1: Selectedprogram = 1; break;
            //    case 2: Selectedprogram = 2; break;
            //}
            Selectedprogram = 1;
            return Selectedprogram;
        }

        public void Rinsewater()
        {
            Console.WriteLine("Pumping water in");
            // Activate pump unit
            Thread.Sleep(5000);
        }

        public void Removewater()
        {
            Console.WriteLine("Removing water");
            // Activate outlet pushing unit
            Thread.Sleep(5000);
        }
        public void Ready()
        {
            Console.WriteLine("Ready sound");
            // Activate PC-speaker
            Thread.Sleep(1000); // Wait for a short moment, for safety reasons
            // Open locking from hatch
            Console.WriteLine("Hatch locking turned off, turning machine off");
           
            Turnedon = false;

        }
        public bool Childlock()
        {
            if (Childproof == false)
                Childproof = true;
            else
                Childproof = false;
            return Childproof;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {

            // Create new class object instance

            WM pesukone = new WM();

            pesukone.Turnedon = true;
            pesukone.Brand = "Miele";
            pesukone.Model = "WDB020FIN";

            // Variables

            pesukone.Selectedprogram = 0;
            pesukone.Spinning = 0;
            pesukone.Temperature = 0;
            pesukone.Childproof = false;
            string input = ""; // For all input values
            string progstatus = "Active"; // For the UI loop
            int usage = 0; // For switch cases
            int usage2 = 0;

            // UI to Switch LOOP
            while (progstatus == "Active") // Switch off to any status to break
            {
                Console.WriteLine("Your {0} washing machine {1} on/off status is : {2}.\nSelected program is {3}.\nSpinning speed is {4}.\nTemperature is adjusted to {5}C°.\nChildproof mechanism on/off status is: {6}\n", pesukone.Brand, pesukone.Model, pesukone.Turnedon, pesukone.Selectedprogram, pesukone.Spinning, pesukone.Temperature, pesukone.Childproof);
                Console.WriteLine("Choose your action:\n 1) Select washing program\n 2) Change Spinning speed\n 3) Choose temperature\n 4) Switch on/off status of the childproof mechanism\n 5) Start the program\n 6) Turn off the machine");
                input = Console.ReadLine();
                usage = int.Parse(input);
                
                switch (usage)
                {
                    case 1:
                        {
                            pesukone.Programselection();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Your washing machine's spinning speed is currently {0}. Choose the spinning speed.\n 1) 0 rpm\n 2) 400 rpm\n 3) 700 rpm\n 4) 1000 rpm\n 5) 1400 rpm\n 6) 1600 rpm", pesukone.Spinning);
                            input = Console.ReadLine();
                            usage2 = int.Parse(input);
                            switch (usage2)
                            {
                                case 1: pesukone.Spinning = 0; break;
                                case 2: pesukone.Spinning = 400; break;
                                case 3: pesukone.Spinning = 700; break;
                                case 4: pesukone.Spinning = 1000; break;
                                case 5: pesukone.Spinning = 1400; break;
                                case 6: pesukone.Spinning = 1600; break;
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Your washing machine's water heating temperature is currently {0}C°. Choose your temperature.\n 1) 20C°\n 2) 30C°\n 3) 40C°\n 4) 60C°\n 5) 90C°", pesukone.Temperature);
                            input = Console.ReadLine();
                            usage2 = int.Parse(input);
                            switch (usage2)
                            {
                                case 1: pesukone.Temperature = 20; break;
                                case 2: pesukone.Temperature = 30; break;
                                case 3: pesukone.Temperature = 40; break;
                                case 4: pesukone.Temperature = 60; break;
                                case 5: pesukone.Temperature = 90; break;
                                
                            }
                            break;
                        }
                    case 4:
                        {
                            pesukone.Childlock();
                            break;
                        }
                    case 5:
                        {
                            switch (pesukone.Selectedprogram)
                            {
                                case 1: // Example program
                                    {
                                        pesukone.Removewater();
                                        pesukone.Rinsewater();
                                        pesukone.Rinsewater();
                                        // Call warming mechanism with pesukone.Temperature value
                                        // Washing machine spin 4 times left
                                        Thread.Sleep(1000);
                                        //  Washing machine spin 4 times right
                                        Thread.Sleep(1000);
                                        pesukone.Removewater();
                                        // Call spinning with pesukone.Spinning value
                                        pesukone.Rinsewater();
                                        pesukone.Rinsewater();
                                        // Call warming mechanism with pesukone.Temperature value
                                        // Washing machine spin 4 times left
                                        Thread.Sleep(1000);
                                        //  Washing machine spin 4 times right
                                        Thread.Sleep(1000);
                                        pesukone.Removewater();
                                        // Call spinning with pesukone.Spinning value
                                        pesukone.Removewater();
                                        pesukone.Removewater();
                                        pesukone.Ready();
                                        progstatus = "Inactive";
                                        break;
                                    }
                                case 2:
                                    {
                                        break;
                                    }
                            
                            }
                            break;
                        }



                    case 6:
                        {
                            progstatus = "Inactive";
                            break;
                        }
                }




            }







        }
    }
}
