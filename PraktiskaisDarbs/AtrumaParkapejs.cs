using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktiskaisDarbs
{
    public class AtrumaParkapejs
    {
        public static void Uzdevums()
        {
            Console.WriteLine("Ievadi ātrumu:");
            int atrums = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Vai ir Tava dzimšanas diena (J/N):");
            char dzimsanasDiena = Convert.ToChar(Console.ReadLine().ToLower());

            if(dzimsanasDiena == 'j' || dzimsanasDiena == 'n')
            {
                /*
                if (dzimsanasDiena == 'j')
                {
                    atrums -= 5;
                }
                */
                atrums = dzimsanasDiena == 'j' ? atrums - 5 : atrums;
                
                if (atrums <= 60)
                {
                    Console.WriteLine("Soda punkti: 0");
                }
                else if (atrums <= 80)
                {
                    Console.WriteLine("Soda punkti: 1");
                }
                else
                {
                    Console.WriteLine("Soda punkti: 2");
                }
            }
            else
            {
                Console.WriteLine("Dzimšanas dienas formolējums ievadīts nepareizi");
            }
            
        }
    }
}
