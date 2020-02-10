using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * T12-Tank

Projekti: T12-Tank
Pisteet: 1

Toteuta luokka Tank, jolla on seuraavat ominaisuudet:

Name (string)
Type (string)
CrewNumber(int)
Speed(float) {readonly}
SpeedMax(float) {readonly}

sekä metodit

AccerelateTo(float)
SlowTo(float).

Ominaisuudet Name ja Type ovat luettavissa sekä muutettavissa ilman rajoituksia.
Toteuta muut ominaisuudet niin, että niillä on luokan sisäinen taustamuuttuja, jota luokka käyttää.
Ominaisuus CrewNumber on
luettavissa ja asetettavissa, ja sen alkuarvo on 4. Sitä asetettaessa tarkistetaan, että annettu
ominaisuus on sallitulla välillä: minimi on kaksi ja maksimi kuusi.
SpeedMax-ominaisuus on pelkästään luettavissa, ja sen arvo on asetettu oletuksena
pysyvästi arvoon 100. Speed-ominaisuuden lähtöarvo on nolla ja sitä ei voi asettaa
suoraan, mutta sen arvon voi lukea. Speed-omainaisuuden arvoa voi muuttaa ainoastaan
metodien AccerelateTo(float) ja SlowTo(float) kautta kuitenkin niin, että Speed
ei voi olla nollaa pienempi eikä Speedmax-arvoa suurempi; minimi on nolla ja
maksimi 100. Jos metodeille annettu arvo ei ole sallitulla välillä, niin metodi ei muuta Speed-arvoa.
Toteuta pääohjelma TestTank, jolla testaat eri ominaisuuksien asettamista.
Kysymys: Pitääkö pääohjelman ja käyttäjän metodeja kutsuessaan jotenkin tietää,
että metodi ei asettanutkaan nopeutta pyydettyyn arvoon?
 */



namespace T12_Tank
{
    class Tank
    {
        public readonly float maxSpeed = 100;
        private float speed = 0;

        public float Speed
        {
            get
            {
                return speed;
            }
        }
        public string Name { get; set; }
        public string Type { get; set; }
        private int crewNumber = 4;
        public int CrewNumber
        {
            get
            {
                return crewNumber;
            }
            set
            {
                if (value < 2)
                    crewNumber = 2;
                if (value > 6)
                    crewNumber = 6;
                else
                    crewNumber = value;
            }


        }


        public float Accelarate(float morespeed)
        {
            // Nostetaan nopeutta mutta ei yli maxSpeedin
            if (speed + morespeed <= maxSpeed)
                speed = speed + morespeed;
            // Palautus
            return speed;
        }
        public float Brake(float lessSpeed)
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
            Tank TestTank = new Tank();
            TestTank.Name = "Panssari";
            TestTank.Type = "Vau-Nu";
            TestTank.CrewNumber = 4;
            Console.WriteLine("Panssarivaunusi {0} ja sen tyyppi on {1}, siellä on tällä hetkellä {2}kpl henkilöstöä", TestTank.Name, TestTank.Type, TestTank.CrewNumber);
            
            // Kiihdytetään 10 km/h kerralla
            for (int i = 0; i < 11; i++)
            {
                TestTank.Accelarate(10);
                Console.WriteLine("Tankkisi kulkee nyt " + TestTank.Speed);
            }
            // Jarrutus
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Tankkisi nopeus {0}", TestTank.Brake(9));
            }
        }
    }
}
