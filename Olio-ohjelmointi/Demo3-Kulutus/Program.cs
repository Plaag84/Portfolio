using System;
using System.Text;

/*     _____________       _____________________
 *  o  |Auto       |       |Ajomatka           |
 * / \ |-----------|       |-------------------|
 *  |->|+kulutus   | ----->|+auto              |
 * / \ |___________|       |+km                |
 *     |___________|       |                   |
 *                         |                   |
 *                         |___________________|
 *                         |+LaskeKustannukset()
 *                         |___________________|
 * 
 * 
 * 
 */


namespace Demo3_Kulutus
{
    class Distance
    {
        public float Kilometers { get; set; }
        public Car UsedCar { get; set; }
        public float CountCost(float fuelprice)
        {
            //lasketaan tosiaan matkan kustannukset
            return ((Kilometers * UsedCar.Consumption * fuelprice) / 100F);
        }
    }
    class Car
    {
        public string Model { get; set; }
        public float Consumption { get; set; }
    }
    class CarUtils

    {
        public static float CountCost
        (float distance, float consumption, float fuelprice) 
        {
            return (distance * consumption * fuelprice) / 100F;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //staattisen metodin kutsuminen
            Console.WriteLine("250 km matka kulutus 7,5ltr/100km bensa 1,5€/ltr maksaa {0}", 
                CarUtils.CountCost(250F,7.5F,1.5F));

            //oliomainen ratkaisu
            Car car = new Car()
            {
                Model = "Saab",
                Consumption = 7.5F
            };
            Distance distance = new Distance();
            distance.Kilometers = 250F;
            distance.UsedCar = car;
            Console.WriteLine("Sama olioilla {0}", distance.CountCost(1.5F));
            
        }
    }
}
