using System;



namespace T22_Rajapinta
{
    public interface IRakennus
    {
        int UlkoOvet();
        bool Info();
        int Ikkunat();
    }
    public class Kauppa : IRakennus
    
    {
        public string Nimi { get; set; }
        public bool infodesk;
        public int ikkunat 
        { 
            get 
            {
                return ikkuna;
            } 
        }
        private int ikkuna;
        private int ulkoovi;
        public int ulkoovet { get { return ulkoovi; } }
        public bool Info()
        {
            infodesk = true;
            return true;
        }
        public int Ikkunat()
        {
            ikkuna++;
            return ikkunat;
        }

        public int UlkoOvet()
        {
            ulkoovi++;
            return ulkoovet;
        }
    }
    public class Grilli : IRakennus

    {
        public string Nimi { get; set; }
        public bool infodesk;
        public int ikkunat
        {
            get
            {
                return ikkuna;
            }
        }
        private int ikkuna;
        private int ulkoovi;
        public int ulkoovet { get { return ulkoovi; } }
        public bool Info()
        {
            infodesk = true;
            return true;
        }
        public int Ikkunat()
        {
            ikkuna++;
            return ikkunat;
        }

        public int UlkoOvet()
        {
            ulkoovi++;
            return ulkoovet;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kauppa prisma = new Kauppa() { Nimi = "Seppälä" };
            prisma.UlkoOvet();
            prisma.UlkoOvet();
            prisma.UlkoOvet();
            prisma.UlkoOvet();
            prisma.Ikkunat();
            prisma.Ikkunat();
            prisma.Ikkunat();
            prisma.Ikkunat();
            prisma.Ikkunat();
            prisma.Ikkunat();
            prisma.Ikkunat();
            prisma.Ikkunat();
            prisma.Ikkunat();
            prisma.Info();

            Console.WriteLine($"Tarvittavat määrät\nUlko ovia: {prisma.ulkoovet}\nIkkuinoita: {prisma.ikkunat}\nInfopiste elementtejä: {prisma.infodesk}");

            Grilli liisan = new Grilli() { Nimi = "Liisan grilli" };
            liisan.UlkoOvet();
            liisan.UlkoOvet();
            liisan.Ikkunat();
            liisan.Ikkunat();
            liisan.Ikkunat();
            liisan.Ikkunat();

            Console.WriteLine($"Tarvittavat määrät\nUlko ovia: {liisan.ulkoovet}\nIkkuinoita: {liisan.ikkunat}\nInfopiste elementtejä: {liisan.infodesk}");
        }

    }
}

