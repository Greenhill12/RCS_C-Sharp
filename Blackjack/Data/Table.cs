using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Data
{
    public class Table
    {
        private Deck deck;
        private Dealer dealer;
        private Player player;

        // 1. void StartNewGame()
        public void StartNewGame()
        {
            // 1.1. paņem jaunu kāršu kavu
            deck = new Deck();
            dealer = new Dealer();
            player = new Player();
            // 1.2. samaisa kārtis
            deck.shuffle();
            // 1.3. spēlētājam piešķir 2 kārtis
            player.GiveCard(deck.getCard());
            player.GiveCard(deck.getCard());
            // 1.4. dīlerim piešķir 2 kārtis
            dealer.GiveCard(deck.getCard());
            dealer.GiveCard(deck.getCard());
        }

        // 2. bool PlayAgain()
        public bool PlayAgain()
        {
            // 2.1. vaicā lietotājam, vai uzsākt jaunu spēli
            Console.Write("Vai uzsākt jaunu spēli (j/n)? ");
            string answer = Console.ReadLine();

            return answer.ToLower() == "j";
        }

        // 3. void ShowResults()
        public void ShowResults()
        {
            // 3.1. izvada rezultātu - kurš uzvarēja
            int playerPoints = player.CountPoints();
            int dealerPoints = dealer.CountPoints();

            Console.WriteLine("Dīlera punkti: " + dealerPoints);
            Console.WriteLine("Spēlētāja punkti: " + playerPoints);

            if (playerPoints > 21)
            {
                Console.WriteLine("Tu zaudēji!");
            }
            else if (dealerPoints > 21)
            {
                Console.WriteLine("Tu uzvarēji!");
            }
            else if (playerPoints == dealerPoints)
            {
                Console.WriteLine("Neizšķirts.");
            }
            else if (playerPoints > dealerPoints)
            {
                Console.WriteLine("Tu uzvarēji!");
            }
            else
            {
                Console.WriteLine("Tu zaudēji!");
            }
        }



        // 4. void. PlayerTurn()
        public void PlayerTurn()
        {
            // 4.1. dod kārtis spēlētājam tik ilgi, kamēr vēlas
            while (player.NeedCard())
            {
                player.GiveCard(deck.getCard());
            }
        }


        // 5. void DealerTurn()
        public void DealerTurn()
        {
            // 5.1 dod kārtis dīlerim tik ilgi, kamēr nepieciešams
            while (dealer.NeedCard())
            {
                dealer.GiveCard(deck.getCard());
            }
        }
    }
}
