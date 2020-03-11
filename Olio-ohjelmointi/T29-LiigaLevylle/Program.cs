using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
 * T29-LiigaLevylle

Projekti: T29-LiigaLevylle
Pisteet: 1

Toteuta edelliseen tehtäväön tiedostoon tallentaminen. Lue kurssin lisämateriaali: olioiden tallentaminen levylle.
*/


namespace T29_LiigaLevylle
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
        public Joukkue()
        {
            pelaajat = new List<Pelaaja>();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Joukkue jyp = new Joukkue() { Nimi = "JYP", Kotikaupunki = "Jyväskylä" };
            Joukkue kalpa = new Joukkue() { Nimi = "Kalpa", Kotikaupunki = "Kuopio" };

            List<Joukkue> joukkueet = new List<Joukkue>();
            joukkueet.Add(jyp);
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

                Console.Write("Valitse toiminto:\n 1) Lisää pelaajia\n 2) Poista pelaajia\n 3) Listaa pelaajia\n 4) Tallentaaksesi pelaajat tiedostoon\n 5) Lopettaaksesi ohjelman\nToiminto ) ");
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
                            try
                            {
                                string erotin = ";";
                                Console.WriteLine("Kirjotetaan pelaajatiedot tiedostoon");
                                string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\liiga.csv";
                                using (StreamWriter sw = File.CreateText(filename))
                                {
                                    sw.WriteLine(jyp.Nimi + erotin + jyp.Kotikaupunki + erotin + jyp.Pelaajat.Count + erotin);
                                    foreach (var item in jyp.Pelaajat)
                                    {
                                        sw.WriteLine(item.Etunimi + erotin + item.Sukunimi + erotin + item.PeliPaikka + erotin + item.Numero);
                                    }
                                    sw.WriteLine(kalpa.Nimi + erotin + kalpa.Kotikaupunki + erotin + kalpa.Pelaajat.Count + erotin);
                                    foreach (var item in kalpa.Pelaajat)
                                    {
                                        sw.WriteLine(item.Etunimi + erotin + item.Sukunimi + erotin + item.PeliPaikka + erotin + item.Numero);
                                    }
                                }
                                Console.WriteLine("Pelaaja tiedot kirjoitettu");

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        }
                    case 5:
                        {
                            progstatus = "Inactive";
                            break;
                        }
                }
            }
        }
    }
}

