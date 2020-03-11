using System;
using System.Collections.Generic;
using System.Linq;

/*
 * T25-Jono

Projekti: T25-Jono
Pisteet: 1

Toteuta ratkaisu, joka simuloi kaupan kassan asiakasvirtaa. Toteuta luokka Kassajono joka käyttää jonoa eli Queue-tietorakennetta.
Kassajono -luokalla voisi olla esimerkiksi metodit:
MeneJonoon(parametrit)
PoistuJonosta(parametrit)
ja ominaisuus:
Pituus
Voit myös suunnitella ja toteuttaa oman rajapinnan luokalle. Huom: tässä yhteydessä rajapinta tarkoittaa luokasta ulospäin näkyviä julkisia ominaisuuksia ja metodeja.
 */

namespace T25_Jono
{
    class Kassajono
    {
        public Queue<string> queue = new Queue<string>();
        public int Pituus { get; set; }
        public void MeneJonoon(string tyyppi) 
        {
            queue.Enqueue(tyyppi);
        }
        public void PoistuJonosta() 
        {
            queue.Dequeue();
        }
        public override string ToString()
        {
            return "Jonossa nyt\n" + queue.Peek();
        }
        public int JononPituus()
        {
            return queue.Count();
        }
        public string JonoPeek()
        {
            return queue.Peek();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kassajono siwa = new Kassajono() { Pituus = 3 };

            string progstatus = "Active";
            string input;

            while (progstatus == "Active") 
            {
                Console.WriteLine("Anna jonoon tulevan asiakkaan nimi (enter lopettaa)");
                input = Console.ReadLine();

                if (siwa.JononPituus() > siwa.Pituus - 1 & input != "")
                {
                    Console.WriteLine("Jono täynnä");
                    Console.WriteLine("----- Palvellaan jonon ensimmäinen asiakas -----");
                    Console.WriteLine("Palvelen nyt asiakasta: " + siwa.JonoPeek());
                    siwa.PoistuJonosta();
                    siwa.MeneJonoon(input);
                    Console.WriteLine($"Jonossa on nyt {siwa.JononPituus()} asiakasta:");
                    foreach (string item in siwa.queue)
                    {
                        Console.WriteLine(item);
                    }
                }

                else if (input == "")
                {
                    progstatus = "Inactive";
                    int length = siwa.JononPituus();
                    for (int i = 0; i < length ; i++)
                    {
                        Console.WriteLine("----- Palvellaan jonon ensimmäinen asiakas -----");
                        Console.WriteLine("Palvelen nyt asiakasta: " + siwa.JonoPeek());
                        siwa.PoistuJonosta();
                    }

                    Console.WriteLine("Kaikki asiakkaat palveltu");
                }
                else
                {
                    siwa.MeneJonoon(input);
                    Console.WriteLine($"Jonossa on nyt {siwa.JononPituus()} asiakasta:");
                    foreach (string item in siwa.queue)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}