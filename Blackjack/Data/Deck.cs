using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Data
{
    public class Deck
    {
        public string[] Suits = { "H", "D", "C", "S" };
        public string[] Values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        // 1. īpašība - Cards (List<Card>
        public List<Card> Cards;

        // 2. konstruktors (bez parametriem)
        public Deck()
        {
            Cards = new List<Card>();

            // 2.1. aizpilda kāršu sarakstu ar visām 52 kārtīm        
            foreach (string s in Suits)
            {
                foreach (string v in Values)
                {
                    Cards.Add(new Card(s, v));
                }
            }
        }

    // 3. void shuffle() - sajauc Cards
        public void shuffle()
        {
            Random rnd = new Random();
            // katrai kārtij iedod random skaitli, un pēc tam tiek sakārtots augošā secībā
            Cards = Cards.OrderBy(c => rnd.Next()).ToList();
        }
    // 4. Cards getCard() - atgriež vienu kārti no saraksta un dzēš no saraksta
        public Card getCard()
        {
            // 4.1 paņem kārti no saraksta
            Card card = Cards[0];

            // 4.2 izdzēš no saraksta
            Cards.Remove(card);

            // 4.3 atgriež kā rezultātu
            return card;
        }
    } 
}
