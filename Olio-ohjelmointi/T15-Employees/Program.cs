using System;
using System.Collections.Generic; //for List<T>
using System.Linq;
using System.Text; // for € in console
using System.Threading.Tasks;

namespace T15_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //tällä € merkki konsoliin

            Console.WriteLine("Firman Boss & Dumps Ltd työntekijät ovat");
            //luodaan pari työntekijää ja yksi pomo
            Employee employee = new Employee();
            employee.Name = "Kirsi Kernel";
            employee.Profession = "programmer";
            employee.Salary = 3000F;
            Employee employee2 = new Employee()
            {
                Name = "Matti Mainio",
                Profession = "developer",
                Salary = 3000F
            };
            //työntekijät listaan
            List<Employee> staff = new List<Employee>();
            staff.Add(employee); // Kirsin tiedot sisältävät olio lisätään listaan
            staff.Add(employee2); // Matti tiedot sisältävät olio lisätään listaan
            //pomot
            Boss boss = new Boss()
            {
                Name = "John Doe",
                Profession = "Manager",
                Salary = 5000F,
                Car = "Lada",
                Bonus = 1000F
            };
            staff.Add(boss); //pomon tiedot sisältävä olio lisätään listaan (perityn luokan olioita voi laittaa listaan, jonka tyyppinä on kantaluokka
            float total = 0F;
            //näytetään kaikki listan työntekijät
            foreach (Employee item in staff)
            {
                Console.WriteLine(item.ToString());
                total += item.Salary;
                //total = total + item.Salary;
                //jos Boss-olio niin huomioidaan myös Bonus
                if (item is Boss)
                {
                    Boss b = (Boss)item;
                    total += b.Bonus;

                }


            }
            Console.WriteLine("Työn tekijöitä firmassa on : " + staff.Count);
            Console.WriteLine("Firman kokonais palkka on=" + total + "€");
        }
    }
}
