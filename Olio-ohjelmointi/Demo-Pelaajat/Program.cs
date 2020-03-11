using System;
using System.Collections.Generic;
using System.IO;

namespace Demo_Pelaajat
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
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                string erotin = ";"; //CSV:ssä sanat on eroteltu toisistaan puolipisteellä
                Console.WriteLine("Luetaan pelaajatietoja tiedostosta");
                string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\jyp.csv";
                string[] lines = File.ReadAllLines(filename);
                Console.WriteLine("\n------------------------------------------------------\nEtunimi   \tSukunimi   \tPelipaikka   \tNumero\n------------------------------------------------------");
                List<Pelaaja> tiimi = new List<Pelaaja>();
                foreach (string line in lines)
                {
                    // Console.WriteLine(line);
                    // Splitataan tekstirivi neljäksi merkkijonoksi
                    string[] words = line.Split(erotin.ToCharArray());
                    // Luodaan pelaaja-olio
                    Pelaaja pelaaja = new Pelaaja(words[0], words[1], words[2], words[3]);
                    // Näytetään pelaajan nimi
                    //Console.WriteLine(pelaaja.Etunimi + " " + pelaaja.Sukunimi + " " + pelaaja.PeliPaikka + " " + pelaaja.Numero);
                    tiimi.Add(pelaaja);
                    Console.WriteLine(pelaaja.ToString());
                }
                Console.WriteLine("\nJoukkueessa on {0} pelaajaa", tiimi.Count);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
