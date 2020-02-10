using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * T11-CD

Projekti: T11-CD
Pisteet: 1

Suunnittele UML-editorilla CD-luokka, joka sisältää ominaisuuksina tyypillisiä CD-levyyn kuuluvia tietoja.
Pohdi myös mitä eri toiminnallisuuksia CD:llä voisi olla. Toteuta ainakin toiminnallisuus,
joka palauttaa kaikkien ominaisuuksien arvot yhtenä merkkijonona (sen avulla pääohjelmassa voisi
tulostaa kaikki CD:n tiedot). Tehtävässä "ei tarvitse" toteuttaa eri biisien ominaisuuksia,
tätä asiaa pohditaan tulevissa demoissa, kun olio-ohjelmointiin liittyvä koostaminen otetaan esille.
Jos kuitenkin haluat miettiä sitä, niin se on tämän tehtävän +kohta eli voit kokeilla tehdä erillisen
Biisi-luokan ja toteuttaa CD-luokan sisälle taulukon, jossa on biisejä.
Ohjelmoi C#:lla suunnittelemasi CD-luokka. Toteuta pääohjelmassa CD-olioita.
Tiedot voit keksiä itse, niitä ei tarvitse kysyä käyttäjältä. Tulosta ruudulle CD:n tietoja.
CD:
    -Artist: Nightwish
    -Name: Endless Forms Most Beautiful
    -Genre: Symphonic metal
    -Price: 19,9$
    Songs:
    --- Name: Shudder Before the Beautiful - 06:29
    --- Name: Weak Fantasy - 05:23
    --- Name: Elan - 04:45
    --- Name: Yours Is an Empty Hope - 05:34
    --- Name: Our Decades in the Sun - 06:37
    --- Name: My Walden - 04:38
    --- Name: Endless Forms Most Beautiful - 05:07
    --- Name: Edema Ruh - 05:15
    --- Name: Alpenglow - 04:45
    --- Name: The Eyes of Sharbat Gula - 06:03
    --- Name: The Greatest Show on Earth - 24:00  
 */


namespace T11_CD
{
    class CD
    {
        public CD() { }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public float Price { get; set; }
        public string[] Tracks { get; set; }
        public string AlbumInfo(string arttu, string albbu, string genkku, float praikku)
        {

            return (arttu) + "\n" + (albbu) + "\n" + (genkku) + "\n" + (praikku);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CD NWEndless = new CD()
            {
                Artist = "Nightwish",
                Album = "Endless Forms Most Beautiful",
                Genre = "Symphonic metal",
                Price = 19.9F,
                Tracks = new string[] { "Shudder Before the Beautiful", "Weak Fantasy", "Elan", "Yours Is an Empty Hope", "Our Decades in the Sun", "My Walden", "Endless Forms Most Beautiful", "Edema Ruh", "Alpenglow", "The Eyes of Sharbat Gula", "The Greatest Show on Earth" }
            };

            Console.WriteLine(NWEndless.AlbumInfo(NWEndless.Artist, NWEndless.Album, NWEndless.Genre, NWEndless.Price));
            
        }
    }
}
