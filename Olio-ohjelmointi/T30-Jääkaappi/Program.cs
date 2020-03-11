using System;
using System.Collections.Generic;

/*
 * T30-Jääkaappi

Projekti: T30-Jääkaappi
Pisteet: 1

Pohdi jääkaappia reaalimaailman käsitteenä ja erityisesti sitä mitä sieltä löytyy.
Tee pienimuotoinen toteutus, joka koostaa jääkaapin sisältöä muutamista eri asioista/olioista.
Jääkaappi on siis olio, jolla on kokoelma erilaisia elintarvikkeita.
 */

//Kurssimateriaalista

/*Kokoelma eli "Sanakirja" (Dictionary)
Dictionary<TKey,TValue>
Tietorakenne Dictionary sisältää sekä avaimia (key) ja arvoja (value). Tietorakenteessa olevat avaimet ovat aina uniikkeja ja viittaavat johonkin arvoon/tietoon.
Tietorakenteen määrittelyn yhteydessä annetaan aina tyyppi sekä avaimelle että arvolle. Lisätietoa: Dictionary<TKey,TValue> Class. */

namespace T30_Jääkaappi
{
    class Ruoka
    {
        public string Nimike { get; set; }
        public int Koko { get; set; }
    }

    class Jääkaappi
    {
        public List<Ruoka> sisältö = new List<Ruoka>();
        public string Nimi = "Electrolux";
        public string Malli = "ERF5110";
        public int TakuuaikaKK = 24;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Jääkaappi ellu = new Jääkaappi();
                ellu.sisältö.Add(new Ruoka { Nimike = "Oivariini, runsas suolainen", Koko = 1 });
                ellu.sisältö.Add(new Ruoka { Nimike = "Ykkösmaito 1l", Koko = 4 });
                ellu.sisältö.Add(new Ruoka { Nimike = "Fosters olut 0,4l", Koko = 12 });
                ellu.sisältö.Add(new Ruoka { Nimike = "Vichy (kotimaista) 0,33l", Koko = 36 });
                ellu.sisältö.Add(new Ruoka { Nimike = "Mikropizza (Saarioinen, kinkku)", Koko = 8 });
                ellu.sisältö.Add(new Ruoka { Nimike = "Oltermanni, normaalisuolainen", Koko = 2 });
                foreach (var item in ellu.sisältö)
                {
                    Console.WriteLine(item.Nimike + " " + item.Koko + "kpl");
                }
        }
    }
}
