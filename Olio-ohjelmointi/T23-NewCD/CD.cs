using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T23_NewCD
{
    class CD
    {
        public string Name { get; set; } // Bändi - Levyn nimi
        public List<Song> Songs { get; set; }
        public int SongsCount
        {
            get
            {
                return Songs.Count;
            }
        }
        public int TotalLength
        {
            get
            {
                int total = 0;
                // käydään kaikki biisit läpi ja lasketaan sec-arvoista summa
                foreach (Song song in Songs)
                {
                    total += song.Length;
                }
                return total;
            }
        }
        public string TotalLengthMinSec
        {
            get
            {
                return
                    string.Format("{0} min {1:00}", TotalLength / 60, TotalLength % 60); // täydet minuutit minuuteiksi ja jakojäännös sekunneiksi! Nerokasta!
            }
        }

        // Alustetaan Songs-lista konstruktorissa eli 
        // "biisi-lista on tyhjä kun CD-luodaan"
        public CD()
        {
            Songs = new List<Song>();
        }

        public override string ToString()
        {
            return $"{Name} contains {SongsCount} songs, length is {TotalLengthMinSec}";
        }

        public void LoadSongs(string file)
        {
            // empty songs list
            Songs.Clear();
            string[] rows = File.ReadAllLines(file);
            foreach (string row in rows)
            {
                // row = "song name;length"
                string[] parts = row.Split(new char[] { ';' }); // käytetään csv. parsintaan tiedostossa käytettyä merkkiä
                // parts[0] = "song name", parts[1] = length
                Song song = new Song();
                song.Name = parts[0];
                song.Length = int.Parse(parts[1]);
                Songs.Add(song);
            }
        }
    }
}
