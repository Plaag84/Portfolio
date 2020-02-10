using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14_Amplifier
{
    class Amplifier
    {
        public Amplifier() { }
        public readonly int maxVolume = 100;
        public readonly int minVolume = 0;
        private int volume = 0;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= maxVolume)
                    volume = maxVolume;
                    
                else if (value <= minVolume)
                    volume = minVolume;
                else
                    volume = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amppi = new Amplifier();
            amppi.Volume = 0;

            string input = ""; // For all input values
            int usage = 0; // For switch cases

            while (true) // Switch off to any status to break 
            {
                // Console.WriteLine("Elevator is now in floor : {0}", hissi.Floor);
                Console.Write("Give a new volume value (0-100) > ");
                input = Console.ReadLine();
                usage = int.Parse(input);
                amppi.Volume = usage;
                if (usage > amppi.maxVolume)
                    Console.WriteLine("-> Too much volume - Amplifier volume is set to maximum : 100");
                else if (usage < amppi.minVolume)
                    Console.WriteLine("-> Too low volume - Amplifier volume is se to minimum : 0");
                else
                    Console.WriteLine("-> Amplifier volue is set to : {0}", amppi.Volume);
            }
        }
    }
}
