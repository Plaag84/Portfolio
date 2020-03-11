using System;
using System.Collections.Generic;

namespace Demo_Rajapinta
{
    public interface ICanMakeNote
    {
        string MakeNote(string txt);
    }
    public interface ICanShowVideo
    {
        void ShowVideo(string url);
    }
    // kantaluokka
    public class Device
    {
        public string Manufacturer { get; set; }
    }
    // luokat jotka toteuttavat rajapinnan
    public class Tablet : Device, ICanMakeNote, ICanShowVideo
    {
        public string CPU { get; set; }
        //methods
        public void ShowVideo(string url)
        {
            //TODO
        }
        public string MakeNote(string textToSave)
        {
            return "Your text is saved to harddisk successfully";
        }
    }
    public class Paper : ICanMakeNote
    {
        public string Size { get; set; }
        public string MakeNote(string txt)
        {
            return $"Sinun muistiinpanosi {txt} on kirjoitettu kauniilla käsialalla paperille";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testataan rajapintaa");
            Tablet ipad = new Tablet();
            Console.WriteLine("Anna muistiinpano");
            string txt = Console.ReadLine();
            Console.WriteLine(ipad.MakeNote(txt));
            Paper a4 = new Paper() { Size = "A4" };
            Console.WriteLine(a4.MakeNote(txt));
            // esimerkki 1 tyyppiyhteensopivuudesta 
            List<ICanMakeNote> noottientekoväline = new List<ICanMakeNote>();
            noottientekoväline.Add(ipad);
            noottientekoväline.Add(a4);
            Console.WriteLine("Anna toinen muistiinpano");
            txt = Console.ReadLine();
            foreach (var item in noottientekoväline)
            {
                // Console.WriteLine(item.MakeNote(txt));  //esimerkki 1 toteutus
                TeeMuistiinpano(item, txt); // esimerkki 2 toteutus
            }
            // esimerkki 2 tyyppiyhteensopivuudesta kirjoitettu pääohjelman ulkopuolelle
        }
        static void TeeMuistiinpano(ICanMakeNote väline, string teksti)
        {
            Console.WriteLine(väline.MakeNote(teksti));
        }
    }
}

