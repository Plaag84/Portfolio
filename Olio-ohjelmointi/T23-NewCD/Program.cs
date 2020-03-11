using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Tämä oli TTV19S2:lle tehty demo ja tiedosto lisätty myös
 * T23-NewCD

Projekti: T23-NewCD
Pisteet: 3

Aikaisemmissa demoissa tehtiin CD-luokka, joka sisälsi CD:lle yleisesti kuuluvia ominaisuuksia. CD:lla on oltava ainakin seuraavat tiedot: nimi, artisti, biisien määrä, kokonaispituus ja biisit.
CD:n sisällä olevat biisit ovat olioita Biisi-luokasta. Kustakin biisistä tallennetaan nimi ja pituus. CD:llä olevien  biisien määrää ei ole rajattu.
CD-luokan biisien määrä on vain luettavissa oleva ominaisuus, joka lasketaan CD:n biisi-olioiden lukumääränä.
CD-luokan kokonaispituus on vain luettavissa oleva ominaisuus, joka lasketaan CD:n biisi-olioiden pituuksien summana.
Ohjelmoi suunnittelemasi CD-luokka ja Biisi-luokka. Toteuta pääohjelmassa CD-olio. Tiedot CD:lle voit keksiä itse ja pääohjelma asettaa ne, niitä ei tarvitse kysyä käyttäjältä.
Tarkista huolellisella testauskella, että luokkasi varmasti osaa laskea biisien määrän ja kokonaispituuden oikein!
Esimerkkitoiminta:
You have a CD:
- name: Endless Forms Most Beautiful
- artist: Nightwish
- total lenght: **78min 36 sec**
- 11 songs:
  - Shudder Before the Beautiful, 6:29
  - Weak Fantasy, 5:23
  - Elan, 4:45
  - Yours Is an Empty Hope, 5:34
  - Our Decades in the Sun, 6:37
  - My Walden, 4:38
  - Endless Forms Most Beautiful, 5:07
  - Edema Ruh, 5:15
  - Alpenglow, 4:45
  - The Eyes of Sharbat Gula, 6:03
  - The Greatest Show on Earth, 24:00
 */

namespace T23_NewCD
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a CD
            //CD cd = new CD();
            //cd.Name = "RockBand - Human";
            CD cd = new CD() { Name = "RockBand - Human" };

            // create songs

            // biisien pituudet sekunneissa

            // 2 min 0 sec
            Song song1 = new Song() { Name = "First Song", Length = 120 };
            // 3 min 01 sec
            Song song2 = new Song() { Name = "Second Song", Length = 181 };
            // 4 min 02 sec
            Song song3 = new Song() { Name = "Third Song", Length = 242 };

            // add songs to cd
            cd.Songs.Add(song1);
            cd.Songs.Add(song2);
            cd.Songs.Add(song3);

            // print cd
            Console.WriteLine($"CD name is {cd.Name}");
            Console.WriteLine($"- songs count {cd.SongsCount}");
            foreach (Song song in cd.Songs)
            {
                Console.WriteLine($"  - {song.Name} {song.LengthMinSec}");
            }
            Console.WriteLine(cd.ToString());

            CD cd2 = new CD() { Name = "Nightwish - Endless Forms Most Beautiful" };
            string documents
                    = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // \\storage\homes\M3286\Dox\Documents\Songs.csv
            // Tiedostosta lataamista!
            
            cd2.LoadSongs(documents + @"\Songs.csv");
            // print cd
            Console.WriteLine($"CD2 name is {cd2.Name}");
            Console.WriteLine($"- songs count {cd2.SongsCount}");
            foreach (Song song in cd2.Songs)
            {
                Console.WriteLine($"  - {song.Name} {song.LengthMinSec}");
            }
            Console.WriteLine(cd2.ToString());


        }
    }
}
