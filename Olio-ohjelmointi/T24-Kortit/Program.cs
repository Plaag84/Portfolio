using System;
using System.Collections.Generic;


/*
 * T24-Kortit

Projekti: T24-Kortit
Pisteet: 3

Toteuta luokat: Kortti/Card ja Korttipakka/CardDeck. Toteuta ohjelma, joka luo kaikki
korttipelin kortit olioina (maat: hertta, ruutu, risti ja pata; arvot: A,K,Q,J, 10,9...2, kortteja siis 52.)
valitsemaasi tietorakenteeseen ja tulostaa tietorakenteen sisällön.
Jatkoa edelliseen. Kuinka voisit toteuttaa korttipakan sekoittamisen?
Toteuta Korttipakka-luokalle Sekoita/Shuffle-metodi, joka sekoittaa pakan
kortit satunnaiseen järjestykseen. Kutsua metodin toimintaa pääohjelmasta.
 */


using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24_Kortit
{
    public struct Card
    {
        public Card(string rank, string suit) : this()
        {
            Rank = rank;
            Suit = suit;
        }

        public string Rank { get; }
        public string Suit { get; }

        public override string ToString() => $"{Rank} of {Suit}";
    }

    public class Deck : IEnumerable<Card>
    {
        /*
        static readonly string[] ranks = { "Two", "Three", "Four", "Five", "Six",
        "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
        static readonly string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        */
        static readonly string[] ranks = { "2", "3", "4", "5", "6", // Lyhempi tuloste
        "7", "8", "9", "10", "J", "Q", "K", "A" };
        static readonly string[] suits = { "C", "D", "H", "S" };
        readonly List<Card> cards;

        public Deck()
        {
            cards = (from suit in suits
                     from rank in ranks
                     select new Card(rank, suit)).ToList();
        }

        public int Count => cards.Count;

        public void Shuffle()
        {
            // using Knuth Shuffle (see at http://rosettacode.org/wiki/Knuth_shuffle)
            var random = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int r = random.Next(i, cards.Count);
                var temp = cards[i];
                cards[i] = cards[r];
                cards[r] = temp;
            }
        }
        
        public IEnumerator<Card> GetEnumerator()
        {
            //Reverse enumeration of the list so that they are returned in the order they would be dealt.
            //LINQ's Reverse() copies the entire list. Let's avoid that.
            for (int i = cards.Count - 1; i >= 0; i--)
                yield return cards[i];
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Deck cards = new Deck();
            Console.WriteLine("----------------------------------------\nSekoittamaton pakka\n----------------------------------------");
            foreach (var item in cards)
            {
                Console.Write(item + "\t\t");
            }

            Console.WriteLine("\n----------------------------------------\nSekoitettu pakka\n----------------------------------------");

            cards.Shuffle();
            foreach (var item in cards)
            {
                Console.Write(item + "\t\t");
            }
            Console.WriteLine();
        }
    }
}
