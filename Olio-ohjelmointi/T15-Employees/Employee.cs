using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T15_Employees
{
    class Employee
    {
            public Employee() { }
            public string Name { get; set; }
            public string Profession { get; set; }
            public float Salary { get; set; }
        //korvataan ToString-metodi omalla toteutuksella
        public override string ToString()
        {
            return $"Työntekijä: {Name} , {Profession}, palkka={Salary}€"; // $ mahdollistaa {asioiden} käyttämisen
        }
    }
    class Boss : Employee
    {
        public Boss() { }
        public string Car { get; set; }
        public float Bonus { get; set; }
        //korvataan ToString-metodi omalla toteutuksella
        public override string ToString()
        {
            return base.ToString() + ", bonus " + Bonus + "€, auto=" + Car;
        }
    }
}
