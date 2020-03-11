using System;
using System.Text;

/*T21-Kassa

Projekti: T21-Kassa
Pisteet: 2

Seniorikoodari on määritellyt aiemmin valmiiksi rajapinnan. Se on seuraavanlainen:

public interface ITransaction {
  // interface members 
  string ShowTransaction(); 
  float GetAmount();
}

Toteuta pienimuotoinen Kassa-ohjelma, jolla voi suorittaa sekä Käteismaksuja että Korttimaksuja.
Luo luokat PaidWithCash ja PaidWithCard. Kumpikin luokkaa toteuttaa ITransaction-rajapinnan vaatimat metodit,
kumpikin omalla tavallaan. Interfacessa määritelty palauttaa suomenkielisen viestin miten maksu
suoritettiin viesti myös näyttää maksun määrän Euroina. Metodi GetAmount palauttaa maksetun määrän lukuna.
PaidWithCash-luokalle toteuta metodi public float ShowCash(), joka kertoo paljonko rahaa kassasa on,
eli se tallentaa itselleen kaikki kassaan laitetut rahat.

Tee Testi-ohjelma, jossa suoritat kaksi maksua kummallakin tavalla, siis käteisellä ja kortilla.
Tee Testi-ohjelmaan myös toteutus siitä että se osaa kertoa päivän myynnin yhteensä.

Katso oheinen esimerkkiajo:
Transaction to bank: charge from card 0001-0002 date 1.1.2020 amount 78.95
Transaction to bank: charge from card 0003-0004 date 1.1.2020 amount 45.65
Total money at bank account: 124.60
Paid with cash: billnumber 1 date 1.1.2020 amount 100
Paid with cash: billnumber 2 date 1.1.2020 amount 50
Total money in cash: 150
Total sales today Keskiviikko 1. Tammikuuta 2020 is 274.60 ?:
Ohjelma suoritettu onnistuneesti. Press any key to quit.*/

namespace T21_Kassa
{
    public interface ITransaction
    {
        // interface members 
        string ShowTransaction();
        float GetAmount();
    }
    class CashRegister
    {
        public string date = DateTime.UtcNow.ToString("dd.MM.yyyy");
        /*
        public float summa;
        public float Summa 
        {
            get
            {
                return summa;
            }
            
        }


        public float Amount(float määrä)
        {
            summa = määrä;
            return summa;
        }
        */
    }

    class PaidWithCash : CashRegister, ITransaction
    {
        int nro = 0;
        public float summa;
        public float sales;
        public float Cash { get; set; }
        public string ShowTransaction()
        {
            nro++;
            return "Paid with cash: billnumber " + nro.ToString() + " date " + date + " amount " + summa.ToString() + "€";
        }
        public float GetAmount()
        {
            Cash = Cash - summa;
            sales = sales + summa;
            return summa;
        }
        public string ShowCash()
        {
            return Cash.ToString();
        }
    }
    class PaidWithCard : CashRegister, ITransaction
    {
        int nro = 0;
        int nro2 = 1;
        public float total_sales;
        public float sales;
        public float GetAmount()
        {
            total_sales = total_sales + sales;
            return sales;
        }
        public string ShowTransaction()
        {
            nro++;
            nro2++;
            return "Charge from card " + nro.ToString("0000") + "-" + nro2.ToString("0000") + " date " + date + " amount " + sales.ToString() + "€";
        }
        public string ShowBank()
        {
            return total_sales.ToString("0.00");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Kassa 1.2");
            CashRegister kassa = new CashRegister();
            PaidWithCash käteinen = new PaidWithCash() { Cash = 1250.75F }; //pohjakassa
            PaidWithCard kortti = new PaidWithCard();
            kortti.sales = 78.95F;
            kortti.GetAmount();
            Console.WriteLine(kortti.ShowTransaction());
            kortti.sales = 45.65F;
            kortti.GetAmount();
            Console.WriteLine(kortti.ShowTransaction());
            Console.WriteLine("Total money at bank account: " + kortti.ShowBank() + "€");
            Console.WriteLine("Alku kassa:" + käteinen.ShowCash() + "€");
            käteinen.summa = 100F;
            käteinen.GetAmount();
            Console.WriteLine(käteinen.ShowTransaction());
            käteinen.summa = 50F;
            käteinen.GetAmount();
            Console.WriteLine(käteinen.ShowTransaction());
            Console.WriteLine("Loppu kassa: " + käteinen.ShowCash() + "€");
            Console.WriteLine("Total sales today " + DateTime.UtcNow.ToLongDateString() + " is " + (käteinen.sales + kortti.total_sales).ToString("0.00") + "€");
        }
    }

}
