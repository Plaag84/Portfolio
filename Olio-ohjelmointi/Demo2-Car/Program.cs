using System;

namespace Demo2_Car
{
    public class Car // Näillä on aina jokin default näkyvyys (public, private, protected, internal, protected internal), mutta sen voi halutessaan itse määritellä
    {
        private readonly int maxSpeed = 200;
        public string Branch { get; set; }
        private int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value <= maxSpeed)
                    speed = value;
                else
                    speed = maxSpeed;
            }
        }
        // Metodit
        public int Accelarate (int morespeed)
        {
            // Nostetaan nopeutta mutta ei yli maxSpeedin
            if (speed + morespeed <= maxSpeed)
                speed = speed + morespeed;
            // Palautus
            return speed;
        }
        public int Brake (int lessSpeed)
        {
            // Jarrutetaan mutta ei alle nollan
            if (speed - lessSpeed >= 0)
                speed = speed - lessSpeed;
            else
                speed = 0;
            return speed;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Ostetaas oikea menopeli
            Car ferrari = new Car();
            ferrari.Branch = "Ferrari";
            ferrari.Speed = 50;
            Console.WriteLine("Autosi kulkee " + ferrari.Speed);
            // Kiihdytetään 10 km/h kerralla
            for (int i = 0; i < 20; i++)
            {
                ferrari.Accelarate(10);
                Console.WriteLine("Autosi kulkee nyt " + ferrari.Speed);
            }
            // Jarrutus
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine("Autosi nopeus {0}", ferrari.Brake(9));
            }



            // Ferrarin "palautus"
            // ferrari = null; // Tällä voidaan hävittää ferrarin tiedot niin halutessa
            

        }
    }
}
