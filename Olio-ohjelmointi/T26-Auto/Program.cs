using System;
using System.Collections.Generic;

/*
 * T26-Auto

Projekti: T26-Auto
Pisteet: 1

Toteuta alla olevan määrittelyn mukaisesti kaksi luokkaa Auto- ja Rengas. Tee
luokille tarvittavat ominaisuudet ja metodit. Tee pääohjelma, jossa luot kaksi-kolme autoa,
ja varustat ne erilaisilla renkailla. Autojen ja rengastietoja ei tarvitse kysyä käyttäjältä,
vaan voit alustaa ne suoraan pääohjelman koodissa.
Auto

+Merkki:string
+Malli:string
+RenkaidenLkm:int {readonly}
+MaxRenkaidenLkm:int
+Renkaat:List {readonly}

Rengas

+Valmistaja:string
+Malli:string
+RengasKoko:string (esim: "205/45R16")
 */
namespace T26_Auto
{
    class Rengas
    {
        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public string RengasKoko { get; set; }
    }
    class Auto
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public readonly int RenkaidenLkm = 4;
        public int MaxRenkaidenLkm { get; set; }
        private List<Rengas> renkaat = new List<Rengas>();
        public List<Rengas> Renkaat
        {
            get
            {
                return renkaat;
            }
        }
        public Auto()
        {
            renkaat = new List<Rengas>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testataan autoa ja sen renkaita");
            Auto auto = new Auto() { Merkki = "Skoda", Malli = "Octavia" };
            for (int i = 0; i < auto.RenkaidenLkm; i++)
            {
                Rengas rengas = new Rengas() { Valmistaja = "Nokian", Malli = "Hakka", RengasKoko = "205/55R16" };
                auto.Renkaat.Add(rengas);
            }

            //näytetään auton renkaat
            Console.WriteLine($"Arskan autossa {auto.Merkki} {auto.Malli} on seuraavat kumit:");
            foreach (var item in auto.Renkaat)
            {
                Console.WriteLine($"- {item.Valmistaja} {item.Malli} {item.RengasKoko}");
            }


            Auto auto2 = new Auto() { Merkki = "Lada", Malli = "Riva (VAZ 2105)" };
            for (int i = 0; i < auto.RenkaidenLkm; i++)
            {
                Rengas rengas = new Rengas() { Valmistaja = "Linglong", Malli = "GreenMax", RengasKoko = "175/65R14" };
                auto2.Renkaat.Add(rengas);
            }
            //näytetään auton renkaat
            Console.WriteLine($"Peran autossa {auto2.Merkki} {auto2.Malli} on seuraavat kumit:");
            foreach (var item in auto2.Renkaat)
            {
                Console.WriteLine($"- {item.Valmistaja} {item.Malli} {item.RengasKoko}");
            }

        }

	

	
    }
}
