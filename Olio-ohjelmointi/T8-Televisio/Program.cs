using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_Televisio
{
    class TV
    {
        public TV () { }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Size { get; set; }
        public int Brightness { get; set; }
        public int Contrast { get; set; }
        public int Color_R { get; set; }
        public int Color_G { get; set;}
        public int Color_B { get; set; }
        public bool Power { get; set; }
        public int Channel { get; set; }
        public int Volume { get; set; }
        public int[] Picturesettings(int[] settings)
        {
            string input = "";
            int usage = 0;
            string progstatus = "Active";

            while (progstatus == "Active") // Switch off to any status to break
            {
                Console.WriteLine("Brightness is {0}.\nContrast is {1}.\nValue of red is {2}.\nValue of green is {3}.\nValue of blue is {4}.\n", settings[0], settings[1], settings[2], settings[3], settings[4]);
                Console.WriteLine("Choose your action:\n 1) Adjust Brightness\n 2) Adjust Contrast\n 3) Adjust red value\n 4) Adjust green value\n 5) Adjust blue value\n 6) Back to main menu");
                input = Console.ReadLine();
                usage = int.Parse(input);

                switch (usage)
                {
                    case 1:
                        {
                            Console.WriteLine("Current brightness is {0}. Choose new brightness :", settings[0]);
                            input = Console.ReadLine();
                            settings[0] = int.Parse(input);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Current contrast is {0}. Choose new contrast :", settings[1]);
                            input = Console.ReadLine();
                            settings[1] = int.Parse(input);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Current red value is {0}. Choose new red value :", settings[2]);
                            input = Console.ReadLine();
                            settings[2] = int.Parse(input);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Current green value is {0}. Choose new green value :", settings[3]);
                            input = Console.ReadLine();
                            settings[3] = int.Parse(input);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Current blue value is {0}. Choose new blue value :", settings[4]);
                            input = Console.ReadLine();
                            settings[4] = int.Parse(input);
                            break;
                        }
                    case 6:
                        {
                            progstatus = "Inactive";
                            break;
                        }
                }
            
            }
        return settings;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // New instance
            TV telkku = new TV();

            // Class variables
            int[] settings = new int[] { 50, 50, 50, 50, 50};

            telkku.Brand = "LG";
            telkku.Model = "49UM7100";
            telkku.Size = 49;
            telkku.Brightness = settings[0];
            telkku.Contrast = settings[1];
            telkku.Color_R = settings[2];
            telkku.Color_G = settings[3];
            telkku.Color_B = settings[4];
            telkku.Power = true;
            telkku.Channel = 1;
            telkku.Volume = 25;

            // Variables

            string input = "";
            string progstatus = "Active";
            int usage = 0;

            while (progstatus == "Active") // Switch off to any status to break
            {
                Console.WriteLine("Your {0} TV {1} on/off status is : {2}. Channel is {3}. Volume is {4}.\n", telkku.Brand, telkku.Model, telkku.Power, telkku.Channel, telkku.Volume);
                Console.WriteLine("Choose your action:\n 1) Turn off TV\n 2) Change channel\n 3) Change sound volume\n 4) Change picture settings\n 5) View picture settings\n 6) Quit program");
                input = Console.ReadLine();
                usage = int.Parse(input);

                switch (usage)
                {
                    case 1:
                        {
                            progstatus = "Inactive";
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Current channel is {0}. Choose your channel :", telkku.Channel);
                            input = Console.ReadLine();
                            telkku.Channel = int.Parse(input);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Current sound volume is {0}. Choose your sound volume :", telkku.Volume);
                            input = Console.ReadLine();
                            telkku.Channel = int.Parse(input);
                            break;
                        }
                    case 4:
                        {
                            telkku.Picturesettings(settings);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Brightness is {0}.\nContrast is {1}.\nValue of red is {2}.\nValue of green is {3}.\nValue of blue is {4}.\n", settings[0], settings[1], settings[2], settings[3], settings[4]);
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
