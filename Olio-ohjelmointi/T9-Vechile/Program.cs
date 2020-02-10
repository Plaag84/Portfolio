using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9_Vechile
{
    class Vechile
    {
        public Vechile() { }
        public string Branch { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }
        public void PrintData(string Branch, string Model, int Speed, int Tyres)
        {
            Console.WriteLine(" This vechile is {0}.\n Model is {1}\n It's top (expected) speed is {2}\n It has {3} tyres.\n", Branch, Model, Speed, Tyres);
        }
        public string ToString(string eka, string toka, int kolmas, int neljäs)
        {
            return (eka) + (toka) + (kolmas) + (neljäs).ToString();
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vechile polkupyörä = new Vechile();

            polkupyörä.Branch = "Bicycle";
            polkupyörä.Model = "Helkama";
            polkupyörä.Speed = 20;
            polkupyörä.Tyres = 2;
            polkupyörä.PrintData(polkupyörä.Branch, polkupyörä.Model, polkupyörä.Speed, polkupyörä.Tyres);

            Vechile skootteri = new Vechile();

            skootteri.Branch = "Lightweight motorcycle";
            skootteri.Model = "Helkama";
            skootteri.Speed = 40;
            skootteri.Tyres = 2;
            skootteri.PrintData(skootteri.Branch, skootteri.Model, skootteri.Speed, skootteri.Tyres);

            string data = "";
            data = polkupyörä.ToString(polkupyörä.Branch, polkupyörä.Model, polkupyörä.Speed, polkupyörä.Tyres);
            Console.WriteLine(data);

        }
    }
}
