using System;
using System.Collections.Generic;

/*
 * T27-Kulkuneuvot

Projekti: T27-Kulkuneuvot
Pisteet: 1

Tee Rengas-luokka (tai käytä edellisen tehtävän luokkaa), jolla on seuraavat ominaisuudet:
Valmistaja, Malli ja Rengaskoko. Tee tämän jälkeen Kulkuneuvo-luokka muutamilla
kulkuneuvoon kuuluvilla ominaisuuksilla (nimi, malli) ja käytä tekemääsi
Rengas-luokkaa apuna renkaiden käsittelyyn. Tässä vaiheessa voit koostaa kulkuneuvon
renkaat Rengas-olioina List-rakenteeseen. Tee pääohjelma, jossa luot muutamia kulkuneuvoja
(esim. auto ja moottoripyörä) renkaineen. Tietoja ei tarvitse kysyä käyttäjältä, vaan voit alustaa niitä suoraan pääohjelman koodissa.
Esimerkkitoiminta:
Created a new vehichle Porsche model 911
Tyre Nokia added to vehicle Porsche
Tyre Nokia added to vehicle Porsche
Tyre Nokia added to vehicle Porsche
Tyre Nokia added to vehicle Porsche

Vechicle Name: Porsche Model:911
Tyres:
-Name: Nokia Model:Hakkapeliitta TyreSize:205R16
-Name: Nokia Model:Hakkapeliitta TyreSize:205R16
-Name: Nokia Model:Hakkapeliitta TyreSize:205R16
-Name: Nokia Model:Hakkapeliitta TyreSize:205R16

Created a new vehichle Ducati model Diavel
Tyre MIC added to vehicle Ducati
Tyre MIC added to vehicle Ducati

Vechicle Name: Ducati Model:Diavel
Tyres:
-Name: MIC Model:Pilot TyreSize:160R17
-Name: MIC Model:Pilot TyreSize:140R16    
...
 */
namespace T27_Kulkuneuvot
{
    class Rengas
    {
        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public string RengasKoko { get; set; }
    }
    class Kulkuneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int MaxRenkaidenLkm { get; set; }
        private List<Rengas> renkaat = new List<Rengas>();
        public List<Rengas> Renkaat
        {
            get
            {
                return renkaat;
            }
        }
        public Kulkuneuvo()
        {
            renkaat = new List<Rengas>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testataan autoa ja sen renkaita");
            Kulkuneuvo auto = new Kulkuneuvo() { Nimi = "Porsche", Malli = "model 911" };
            for (int i = 0; i < 4; i++)
            {
                Rengas rengas1 = new Rengas() { Valmistaja = "Nokian", Malli = "Hakka", RengasKoko = "205R16" };
                auto.Renkaat.Add(rengas1);
            }

            //näytetään auton renkaat
            Console.WriteLine($"Arskan autossa {auto.Nimi} {auto.Malli} on seuraavat kumit:");
            foreach (var item in auto.Renkaat)
            {
                Console.WriteLine($"- {item.Valmistaja} {item.Malli} {item.RengasKoko}");
            }


            Kulkuneuvo vehicle = new Kulkuneuvo() { Nimi = "Ducati", Malli = "model Diavel" };
          
            
            Rengas rengas2 = new Rengas() { Valmistaja = "MIC", Malli = "Pilot", RengasKoko = "160R17" };
            vehicle.Renkaat.Add(rengas2);
            Rengas rengas3 = new Rengas() { Valmistaja = "MIC", Malli = "Pilot", RengasKoko = "140R16" };
            vehicle.Renkaat.Add(rengas2);
        
            //näytetään auton renkaat
            Console.WriteLine($"Peran kulkuneuvossa {vehicle.Nimi} {vehicle.Malli} on seuraavat kumit:");
            foreach (var item in vehicle.Renkaat)
            {
                Console.WriteLine($"- {item.Valmistaja} {item.Malli} {item.RengasKoko}");
            }
            
        }




    }
}
