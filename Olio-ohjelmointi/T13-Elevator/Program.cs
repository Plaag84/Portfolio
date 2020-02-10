using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_Elevator
{
    class Elevator
    {
        public Elevator() { }
        public int Floor { get; set; }
        public readonly int MaxFloor = 5;
        public readonly int MinFloor = 1;
        public int Panel(int button)
        {
            int result;
            if (button < MinFloor)
            {
                result = Floor;
            }
            else if (button > MaxFloor)
            {
                result = Floor;
            }
            else
            {
                result = button;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Elevator hissi = new Elevator();
            hissi.Floor = 1;

            string input = ""; // For all input values
            int usage = 0; // For switch cases

            Console.WriteLine("Elevator is now in floor : {0}", hissi.Floor);

            while (true) // Switch off to any status to break
            {

                Console.Write("Give a new floor number (1-5) > ");
                input = Console.ReadLine();
                usage = int.Parse(input);
                hissi.Floor = hissi.Panel(usage);
                if (usage > hissi.MaxFloor)
                    Console.WriteLine("Floor is too big!");
                else if (usage < hissi.MinFloor)
                    Console.WriteLine("Floor is too small!");
                else
                    Console.WriteLine("Elevator is now in floor : {0}", hissi.Floor);
            }
        }
    }
}
