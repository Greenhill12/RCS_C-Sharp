using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktiskaisDarbs
{
    public class Neveiksmigais13
    {
        public static void Uzdevums()
        {
            int summa = 0;

            while(true)
            {
                Console.WriteLine("Ievadi skaitli: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());

                if (skaitlis == 13)
                {
                    break;
                }
                else
                {
                    summa += skaitlis;
                }
            }
            Console.WriteLine("Skaitļu summa ir " + summa);
        }
    }
}
