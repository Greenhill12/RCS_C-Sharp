using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
    public class Uzdevumi
    {
        public static void Uzdevums1()
        {
            Console.Write("Ievadi valsti (Igaunija, Somija, Ukraina, Zviedrija, Krievija): ");
            string valsts = Console.ReadLine().ToLower();
            string teksts = Char.ToUpper(valsts[0]) + valsts.Substring(1) + "s galvaspilsēta ir ";

            switch (valsts)
            {
                case "igaunija":
                    Console.Write(teksts + "Tallina");
                    break;
                case "somija":
                    Console.Write(teksts + "Helsinki");
                    break;
                case "ukraina":
                    Console.Write(teksts + "Kijeva");
                    break;
                case "zviedrija":
                    Console.Write(teksts + "Stokholma");
                    break;
                case "krievija":
                    Console.Write(teksts + "Maskava");
                    break;
                default:
                    Console.Write("Valsts nav ievadīta pareizi");
                    break;
            }
        }

        public static void Uzdevums2()
        {
            for (int skaitlis = 1; skaitlis <= 10; skaitlis++)
            //i = i + 1;
            //i++;
            //i+=1;

            //i = i +2;
            //i+=2;
            {
                Console.WriteLine(skaitlis);
            }
        }

        public static void Gadi()
        {
            Console.Write("Ievadi lūdzu gada skaitli: ");
            int gads = Convert.ToInt32(Console.ReadLine());
            int gadsNow = Convert.ToInt32(DateTime.Now.Year);

            for (int i = gads; i <= gadsNow; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Kvadrati()
        {
            Console.Write("Ievadi lūdzu skaitli, līdz kuram Tu vēlies iegūt šo skaitļu kvadrātus: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= skaitlis; i++)
            {
                int kvadrats = i * i;
                Console.WriteLine(kvadrats);
            }
        }

        public static void Summa()
        {
            Console.Write("Ievadi lūdzu skaitli, līdz kuram Tu vēlies iegūt šo skaitļu summu: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            int summa = 0;

            for (int i = 1; i <= skaitlis; i++)
            {
                Console.WriteLine(i);
                summa = +i;
            }

            Console.WriteLine(summa);
        }

        public static void SkaitluIzvele()
        {
            Console.Write("Ievadi lūdzu cik ciparus ievadīsi: ");
            int skaits = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
            double videjais = 0;

            for (int i = 1; i <= skaits; i++)
            {
                Console.Write("Ievadi lūdzu " + i + ". skaitli: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());

                summa += skaitlis;
            }

            videjais = (double)summa / skaits;

            Console.WriteLine("Summa ir " + summa);
            Console.WriteLine("Vidējais ir " + videjais);
        }

        public static void Rezgis()
        {
            Console.Write("Ievadi lūdzu cik lielu režģi Tu vēlies: ");
            int lielums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= lielums; i++)
            {
                for (int a = 1; a <= lielums; a++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }

        public static void Trijsturis()
        {
            Console.Write("Ievadi lūdzu cik lielu trijstūri Tu vēlies: ");
            int rindas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= rindas; i++)
            {
                for (int a = 1; a <= i; a++)
                {
                    Console.Write(a);
                }

                Console.WriteLine();
            }
        }

        public static void Rombs()
        {
            Console.Write("Ievadi lūdzu cik lielu rombu Tu vēlies: ");
            int sk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int r = 1; r <= sk; r++)
            {
                for (int a = 1; a <= sk - r; a++)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z <= 2 * r - 1; z++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int r = 1; r <= sk - 1; r++)
            {
                for (int a = 1; a <= r; a++)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z <= 2 * (sk - r) - 1; z++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            /*

            for (int i = rindas - 1; i >= 1; i--)
            {
                for (int k = 1; k <= rindas - i; k++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            
            */
        }

        public static void WhilePiemers()
        {

            // lietotajs ievada skaitlus
            // ievadi partrauc ar -1

            /*

            int sk = 0;
            int summa = 0;
            while (sk != -1)
            {
                Console.Write("Ievadi lūdzu skaitli, vai -1 lai pārtrauktu: ");
                sk = Convert.ToInt32(Console.ReadLine());

                if (sk != -1)
                {
                    summa += sk;
                }
            }

            Console.Write("Visu ievadīto skaitļu summa ir " + summa);

            */

            int summa2 = 0;
            while (true)
            //for(; ; )
            {
                Console.Write("Ievadi lūdzu skaitli, vai -1 lai pārtrauktu: ");
                int sk2 = Convert.ToInt32(Console.ReadLine());
                if (sk2 == -1)
                {
                    break;
                }
                else
                {
                    summa2 += sk2;
                }
            }
            Console.Write("Visu ievadīto skaitļu summa ir " + summa2);            
        }
    }
}
