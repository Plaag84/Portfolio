using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
 * T28-Liiga

Projekti: T28-Liiga
Pisteet: 2

Toteuta ohjelma, jolla voidaan lisätä, poistaa ja listata Liiga-joukkueen (esim JYPin tai Kalpan) pelaajia.
Luo Pelaaja-luokka, jolla on ominaisuudet Etunimi, Sukunimi, Pelipaikka ja Numero.
Luo myös Joukkue-luokka. Luokalla on ominaisuudet Nimi, Kotikaupunki ja Pelaajat.
Ominaisuus Pelaajat on siis lista Pelaaja-olioita. Tee Joukkue-luokalle sisäinen metodi HaePelaajat(string joukkue),
jota konstruktori kutsuu. HaePelaajat metodi luo Pelaajat-listaan oikeat pelaajat.
*/


namespace T28_Liiga
{
    class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string PeliPaikka { get; set; }
        public string Numero { get; set; }
        public Pelaaja() { }
        public Pelaaja(string etunimi, string sukunimi, string pelipaikka, string numero) // konstruktori
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            PeliPaikka = pelipaikka;
            Numero = numero;
        }
        public override string ToString()
        {
            return Etunimi + "    \t" + Sukunimi + "    \t" + PeliPaikka + "    \t#" + Numero;
        }
    }
    class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        private List<Pelaaja> pelaajat = new List<Pelaaja>();
        public List<Pelaaja> Pelaajat
        {
            get
            {
                return pelaajat;
            }
        }

        public void HaePelaajat(string nimi)
        {
            if (nimi == "jyp")
            {
                Nimi = "JYP";
                Kotikaupunki = "Jyväskylä";
                Pelaaja mokke = new Pelaaja() { Etunimi = "Markus", Sukunimi = "Ruusu", PeliPaikka = "Maalivahti", Numero = "40" };
                pelaajat.Add(mokke);
                Pelaaja p1 = new Pelaaja() { Etunimi = "Anttoni", Sukunimi = "Honka", PeliPaikka = "Puolustaja", Numero = "3" };
                pelaajat.Add(p1);
                Pelaaja p2 = new Pelaaja() { Etunimi = "Alex", Sukunimi = "Lindroos", PeliPaikka = "Puolustaja", Numero = "51" };
                pelaajat.Add(p2);
                Pelaaja h1 = new Pelaaja() { Etunimi = "Jani", Sukunimi = "Tuppurainen", PeliPaikka = "Hyökkääjä", Numero = "12" };
                pelaajat.Add(h1);
                Pelaaja h2 = new Pelaaja() { Etunimi = "Ossi", Sukunimi = "Louhivaara", PeliPaikka = "Hyökkääjä", Numero = "23" };
                pelaajat.Add(h2);
                Pelaaja h3 = new Pelaaja() { Etunimi = "Antti", Sukunimi = "Kalapudas", PeliPaikka = "Hyökkääjä", Numero = "21" };
                pelaajat.Add(h3);
            }
            else if (nimi == "kalpa")
            {
                Nimi = "Kalpa";
                Kotikaupunki = "Kuopio";
                Pelaaja mokke = new Pelaaja() { Etunimi = "Henri", Sukunimi = "Kiviaho", PeliPaikka = "Maalivahti", Numero = "30" };
                pelaajat.Add(mokke);
                Pelaaja p1 = new Pelaaja() { Etunimi = "Otto", Sukunimi = "Huttunen", PeliPaikka = "Puolustaja", Numero = "2" };
                pelaajat.Add(p1);
                Pelaaja p2 = new Pelaaja() { Etunimi = "Hugo", Sukunimi = "Gallet", PeliPaikka = "Puolustaja", Numero = "22" };
                pelaajat.Add(p2);
                Pelaaja h1 = new Pelaaja() { Etunimi = "Tuomas", Sukunimi = "Vartiainen", PeliPaikka = "Hyökkääjä", Numero = "13" };
                pelaajat.Add(h1);
                Pelaaja h2 = new Pelaaja() { Etunimi = "Mikko", Sukunimi = "Virtanen", PeliPaikka = "Hyökkääjä", Numero = "15" };
                pelaajat.Add(h2);
                Pelaaja h3 = new Pelaaja() { Etunimi = "Aleksi", Sukunimi = "Klemetti", PeliPaikka = "Hyökkääjä", Numero = "20" };
                pelaajat.Add(h3);
            }

        }
        public Joukkue(string nimi)
        {
            HaePelaajat(nimi);
        }
        public Joukkue() { }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Joukkue jyp = new Joukkue("jyp");
            Joukkue kalpa = new Joukkue("kalpa");

            List<Joukkue> joukkueet = new List<Joukkue>();

            joukkueet.Add(kalpa);

            string input = ""; // For all input values
            string progstatus = "Active"; // For the UI loop
            int usage = 0; // For switch cases


            // UI to Switch LOOP
            while (progstatus == "Active") // Switch off to any status to break
            {
                
                
                foreach (var item in joukkueet)
                {
                    Console.WriteLine("Liiga joukkueessa {0}, jonka kotikaupunki on {1} on tällä hetkellä {2} pelaajaa", item.Nimi, item.Kotikaupunki, item.Pelaajat.Count);
                }
                
                Console.Write("Valitse toiminto:\n 1) Lisää pelaajia\n 2) Poista pelaajia\n 3) Listaa pelaajia\n 4) Lopettaaksesi ohjelman\nToiminto ) ");
                input = Console.ReadLine();
                usage = int.Parse(input);

                switch (usage)
                {
                    case 1:
                        {
                            Pelaaja pelaaja = new Pelaaja();
                            Console.Write("Lisätäänkö pelaaja joukkueeseen jyp vai kalpa? : ");
                            input = Console.ReadLine();

                            if (input.ToLower() == "jyp")
                            {
                                Console.Write("Anna pelaajan etunimi : ");
                                input = Console.ReadLine();
                                pelaaja.Etunimi = input;
                                Console.Write("Anna pelaajan sukunimi : ");
                                input = Console.ReadLine();
                                pelaaja.Sukunimi = input;
                                Console.Write("Anna pelaajan peli paikka : ");
                                input = Console.ReadLine();
                                pelaaja.PeliPaikka = input;
                                Console.Write("Anna pelaajan peli numero : ");
                                input = Console.ReadLine();
                                pelaaja.Numero = input;
                                jyp.Pelaajat.Add(pelaaja);
                            }
                            else if (input.ToLower() == "kalpa")
                            { 
                                Console.Write("Anna pelaajan etunimi : ");
                                input = Console.ReadLine();
                                pelaaja.Etunimi = input;
                                Console.Write("Anna pelaajan sukunimi : ");
                                input = Console.ReadLine();
                                pelaaja.Sukunimi = input;
                                Console.Write("Anna pelaajan peli paikka : ");
                                input = Console.ReadLine();
                                pelaaja.PeliPaikka = input;
                                Console.Write("Anna pelaajan peli numero : ");
                                input = Console.ReadLine();
                                pelaaja.Numero = input;
                                kalpa.Pelaajat.Add(pelaaja);
                            }
                            else
                            {
                                Console.WriteLine("Joukkueen nimeäminen meni pieleen");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Anna poistettavan pelaajan joukkue");
                            Console.Write("Lisätäänkö pelaaja joukkueeseen jyp vai kalpa? : ");
                            input = Console.ReadLine();
                            
                            if (input.ToLower() == "jyp")
                            {
                                Console.Write("Anna poistettavan pelaajan id (alkaen numerosta 1)\n numero ) ");
                                input = Console.ReadLine();
                                usage = int.Parse(input);
                                jyp.Pelaajat.RemoveAt(usage - 1);
                            }
                            else if (input.ToLower() == "kalpa")
                            {
                                Console.Write("Anna poistettavan pelaajan id (alkaen numerosta 1)\n numero ) ");
                                input = Console.ReadLine();
                                usage = int.Parse(input);
                                kalpa.Pelaajat.RemoveAt(usage - 1);
                            }
                            else
                                Console.WriteLine("Joukkueen nimeäminen meni pieleen");
                            break;
                        }
                    case 3:
                        {
                            // Console.Clear(); // tämä on muuten hyvä, mutta hyvää tehtävä screenshottia varten tämä pitää ottaa pois
                            Console.WriteLine("\nJypin pelaajat\nEtunimi   \tSukunimi   \tPelipaikka   \tPelinumero\n------------------------------------------------------------------");
                            foreach (var item in jyp.Pelaajat)
                            {
                                Console.WriteLine($"{item.Etunimi}   \t{item.Sukunimi}   \t{item.PeliPaikka}   \t{item.Numero}");
                            }
                            Console.WriteLine("\n");
                            Console.WriteLine("Kalpan pelaajat\nEtunimi   \tSukunimi   \tPelipaikka   \tPelinumero\n------------------------------------------------------------------");
                            foreach (var item in kalpa.Pelaajat)
                            {
                                Console.WriteLine($"{item.Etunimi}   \t{item.Sukunimi}   \t{item.PeliPaikka}   \t{item.Numero}");
                            }
                            Console.WriteLine("\n");
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

