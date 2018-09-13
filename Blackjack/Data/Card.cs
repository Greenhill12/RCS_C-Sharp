using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Data
{
    public class Card
    {
        // 1. īpašība - Suit (string)
        public string Suit;

        // 2. īpašība - Value (string)
        public string Value;

        // 3. konstruktors (aizpilda abas īpašības)
        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }

        // 4. getPoints() - atgriež kārts skaitlisko vērtību
        public int getPoints()
        {
            switch(Value)
            {
                case "A":
                    return 11;
                case "J":
                case "Q":
                case "K":
                    return 10;
                default:
                    //return Covert.ToInt32(Value);
                    return Int32.Parse(Value);
            }
        }

    }
}
