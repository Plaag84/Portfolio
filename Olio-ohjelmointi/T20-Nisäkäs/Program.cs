using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * T20-Nisäkäs

Projekti: T20-Nisakas
Pisteet: 2

Tehtävässä tulee toteuttaa muutamia luokkia, joiden avulla testataan abstraktien metodien toimivuutta.
Luo abstrakti luokka Nisakas, jolla on Ika-ominaisuus sekä Liiku-metodi, jonka toteutus on jätetty toteuttamatta (abstrakti metodi).
Peri Nisakas-luokasta Ihminen-luokka, jolla on ominaisuuksina ihmiseen yleisesti liittyviä ominaisuuksia (paino, pituus, nimi). Lisää Ihminen-luokkaan metodit: Liiku ja Kasva, joista ensimmäinen tulostaa ruutuun "liikun" ja jälkimmäinen lisää ihmisen ikää yhdellä vuodella. Huomioi, että Liiku-metodi ja Ikä-ominaisuus on Nisakas-luokassa
Peri Ihminen-luokasta Vauva- ja Aikuinen-luokat. Ylikirjoita Vauva-luokassa yliluokan Liiku-metodi tulostamaan "konttaa". Ylikirjoita Aikuinen-luokassa myös sama metodi ja laita se tulostamaan "kävelee". Lisää aikuiselle ominaisuus auto (String). Lisää vauvalle ominaisuus vaippa (String).
Toteuta pääohjelmassa muutamia ihmisiä, aikuisia ja vauvoja. Tulostele olioiden tietoja konsolille.
 */

namespace T20_Nisäkäs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Testataan abstrakteja luokkia:");
            //luodaan olio Ihminen-luokasta
            Ihminen ihminen = new Ihminen()
            {
                Ikä = 20,
                Nimi = "Jaska",
                Paino = 70,
                Pituus = 180
            };
            Ihminen ihminen2 = new Ihminen()
            {
                Ikä = 20,
                Nimi = "Jorma",
                Paino = 70,
                Pituus = 180
            };
            Console.WriteLine(ihminen.Liiku());
            Console.WriteLine(ihminen.ToString());
            //aikuinen
            Aikuinen aikamies = new Aikuinen() { Auto = "Porche", Ikä = 34, Nimi = "Arska", Paino = 90, Pituus = 169 };
            Console.WriteLine(aikamies.ToString());
            Console.WriteLine(aikamies.Liiku());
            aikamies.Kasva(); // Kasvaa 1v
            Console.WriteLine(aikamies.ToString());
            //aikuinen2
            Aikuinen aikamies2 = new Aikuinen() { Auto = "Lada", Ikä = 68, Nimi = "Roope", Paino = 64, Pituus = 177 };
            Console.WriteLine(aikamies2.ToString());
            //vauva
            Vauva vauva = new Vauva() { Pituus = 57, Paino = 4, Nimi = "Iippo", Ikä = 1, Vaippa = "Muumi" };
            Console.WriteLine(vauva.ToString());
            Console.WriteLine(vauva.Liiku());
            Vauva vauva2 = new Vauva() { Pituus = 63, Paino = 5, Nimi = "Iivo", Ikä = 1, Vaippa = "Muumi" };
            List<Ihminen> poppoo = new List<Ihminen>();
            poppoo.Add(ihminen);
            poppoo.Add(ihminen2);
            poppoo.Add(aikamies);
            poppoo.Add(aikamies2);
            poppoo.Add(vauva);
            poppoo.Add(vauva2);
            foreach (Ihminen item in poppoo)
            {
                // Console.WriteLine(item.ToString());
                Console.WriteLine($"Olen {item.Nimi}, {item.Liiku()}");
                if (item is Aikuinen)
                {
                    //kastataaan eli muunnetaan item tyypiksi aikuinen
                    Aikuinen apu = (Aikuinen)item;
                    Console.WriteLine($"ja välillä ajan autollani {apu.Auto}");
                }
                if (item is Vauva)
                {
                    Vauva apu = (Vauva)item;
                    Console.WriteLine($"ja käytän {apu.Vaippa} vaippoja");
                }
                    
            }

        }
    }
}
