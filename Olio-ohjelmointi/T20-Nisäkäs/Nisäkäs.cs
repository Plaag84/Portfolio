using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T20_Nisäkäs
{
    abstract class Nisäkäs
    {
        public abstract float Ikä { get; set; }
        public abstract string Liiku();
    }
    class Ihminen : Nisäkäs
    {
        public override float Ikä { get; set; }
        public string Nimi { get; set; }
        public int Pituus { get; set; }
        public double Paino { get; set; }
        public override string Liiku()
        {
            return "Liikun";
        }
        public float Kasva()
        {
            return (Ikä += 1);
        }
        public override string ToString()
        {
            return $"Ihminen nimeltä {Nimi}, ikä={Ikä}, pituus={Pituus}, paino={Paino}";
        }
    }
    class Aikuinen : Ihminen
    {
        public override string Liiku()
        {
            return "Kävelee (ja välillä juoksee)";
        }
        public string Auto { get; set; }
        public override string ToString()
        {
            return base.ToString() + $", auto={Auto}";
        }
    }
    class Vauva : Ihminen
    {
        public override string Liiku()
        {
            return "Konttaa";
        }
        public string Vaippa { get; set; }
        public override string ToString()
        {
            return base.ToString() + $", vaippa={Vaippa}";
        }
    }
}
