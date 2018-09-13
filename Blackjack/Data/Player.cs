using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Data
{
    public class Player
    {
        // 1. īpašība Cards (List<Card>)
        public List<Card> Cards;

        // 2. konstruktors (bez parametriem)
        // 2.1 definē Cards sarakstu
        public Player()
        {
            Cards = new List<Card>();
        }

        // 3. int countPoints() - saskaita visus Cards punktus
        public int CountPoints()
        {
            // 3.1 foreach()            
            // 3.2 getPoints()
            int points = 0;
            int aceCount = 0;
            foreach (Card c in Cards)
            {
                points += c.getPoints();
                // ja ir dūzis, tad palielinām to skaitu
                if(c.Value == "A")
                {
                    aceCount++;
                }
            }
            // 3.3 TODO - apstrādā dūžus
            // ja punktu skaits pārsniedz 21 un ir kāds dūzis, tad par katru ņem nost 10 punktus, kamēr nepārsniedz 21 vai beidzas dūži
            while(points > 21 && aceCount > 0)
            {
                points -= 10;
                aceCount--;
            }

            return points;
        }

        // 4. void giveCard(Card card) - pievieno kārti sarakstam
        public virtual void GiveCard(Card card)
        {
            Cards.Add(card);
            Console.WriteLine("Spēlētājas saņēma " + card.Suit + card.Value);
            Console.WriteLine("Punkti = " + CountPoints());
        }

        // 5. bool needCard() - vai nepieciešama vēl kārts?
        public virtual bool NeedCard()
        {
            if (CountPoints() > 21)
            {
                return false;
            }
            
            Console.Write("Vai nepieciešama kārts (j/n): ");
            string atbilde = Console.ReadLine();

            if(atbilde.ToLower() == "j")
            {
                return true;
            }
            else
            {
                return false;
            }
            // vai:
            // return atbilde.ToLower() =="j";           
        }
    }
}
