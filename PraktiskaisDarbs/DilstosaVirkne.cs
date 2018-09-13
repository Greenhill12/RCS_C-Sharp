using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktiskaisDarbs
{
    public class DilstosaVirkne
    {
        public static void Uzdevums()
        {
            Console.WriteLine("Ievadi skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            if (skaitlis == 1)
            {
                Console.Write(1);
            }
            else
            {
                for (int i = skaitlis; i > 1; i--)
                {
                    Console.Write(i + ", ");
                }
                Console.Write(1);
            }
        }
    }
}
