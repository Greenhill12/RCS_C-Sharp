using Blackjack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();

            while(true)
            { 
                table.StartNewGame();
                table.PlayerTurn();
                table.DealerTurn();
                table.ShowResults();
                Console.WriteLine();

                // pārbauda, vai uzsākt jaunu spēli
                //if(table.PlayAgain() == false)
                if(!table.PlayAgain())
                {
                    break;
                }
            }

            // 1. ja spēlētājam ir virs 21, tad pārtraukt vaicāšanu --> Player

            // 2. pie rezultāta izvadīt abu dalībnieku punktus --> Table

            // 3. cikliski uzsākt jaunu spēli --> Main()



            Console.ReadLine();
        }
    }
}
