using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena2_Uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            //AttalumaAprekins();
            //LietotajaDarbibas();
            LietotajaGradi();
        }

        static void AttalumaAprekins()
        {
            Console.Write("Ievadi attālumu metros: ");
            int attalums = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi patērētās stundas: ");
            int stundas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi patērētās minūtes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi paterētās sekundes: ");
            int sekundes = Convert.ToInt32(Console.ReadLine());

            double laiksKopa = sekundes + minutes * 60 + stundas * 60 * 60;
            double atrums = attalums / laiksKopa;
            double atrumsKm = (attalums / 1000) / (laiksKopa / 3600);
            double attalumsKm = attalums / 1000;
            double attalumsJudz = attalumsKm * 0.621371;

            Console.WriteLine();
            Console.WriteLine("Kopā pavadītais laiks ir " + laiksKopa + " sekundes");
            Console.WriteLine("Ātrums ir " + atrums + " m/s");
            Console.WriteLine("Ātrums ir " + atrumsKm + " km/h");
            Console.WriteLine("Attālums ir " + attalumsKm + " km");
            Console.WriteLine("Attālums ir " + attalumsJudz + " jūdzes");

            Console.ReadLine();
        }

        static void LietotajaDarbibas()
        {
           Console.Write("Ievadi skaitli Nr.1: ");
           double skaitlis1 = Convert.ToDouble(Console.ReadLine());

           Console.Write("Ievadi skaitli Nr.2: ");
           double skaitlis2 = Convert.ToDouble(Console.ReadLine());

           Console.Write("Ievadi darbību, kuru vēlies veikt ar skaitļiem: ");
           string darbiba = Console.ReadLine();
                    
           if (darbiba == "+")
            {
                double summa = skaitlis1 + skaitlis2;
                Console.WriteLine("Skaitļu summa ir " + summa);
            }
            else if (darbiba == "-")
            {
                double starpiba = skaitlis1 - skaitlis2;
                Console.WriteLine("Skaitļu starpība ir " + starpiba);
            }
            else if (darbiba == "*")
            {
                double reizinajums = skaitlis1 * skaitlis2;
                Console.WriteLine("Skaitļu reizinājums ir " + reizinajums);
            }
            else if (darbiba == "/")
            {
                double dalijums = skaitlis1 / skaitlis2;
                Console.WriteLine("Skaitļu dalījums ir " + dalijums);
            }
            else
            {
                Console.WriteLine("Rezultātu nav iespējams aprēķināt");
            }

            Console.ReadLine();
        }

        static void LietotajaGradi()
        {
            Console.Write("Ievadi temperatūru: ");
            double gradi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ievadi esošās temperatūras mērvienību (C, F, K): ");
            string mervienibaIn = Console.ReadLine().ToUpper();

            Console.Write("Ievadi vajadzīgo temperatūras mērvienību (C, F, K): ");
            string mervienibaOut = Console.ReadLine().ToUpper();

            if ((mervienibaIn != "C" && mervienibaIn != "F" && mervienibaIn != "K") || (mervienibaOut != "C" && mervienibaOut != "F" && mervienibaOut != "K"))
            {
                Console.WriteLine("Kļūda ievadē!");
            }
            else if (mervienibaIn == mervienibaOut)
            {
                Console.WriteLine("Temperatūra ir tik cik ievadīji");
            }
            else if (mervienibaIn == "C")
            {
                if (mervienibaOut == "F")
                {
                    double CtoF = (gradi * 1.8) + 32;
                    Console.WriteLine("Temperatūra ir " + CtoF + " fārenheiti");
                }
                else if (mervienibaOut == "K")
                {
                    double CtoK = gradi + 273.15;
                    Console.WriteLine("Temperatūra ir " + CtoK + " kelvini");
                }
            }
            else if (mervienibaIn == "F")
            {
                if (mervienibaOut == "C")
                {
                    double FtoC = (gradi - 32) / 1.8;
                    Console.WriteLine("Temperatūra ir " + FtoC + " celsija grādi");
                }
                else if (mervienibaOut == "K")
                {
                    double FtoK = (gradi + 459.67) * 1.8;
                    Console.WriteLine("Temperatūra ir " + FtoK + " kelvini");
                }
            }
            else if (mervienibaIn == "K")
            {
                if (mervienibaOut == "C")
                {
                    double KtoC = gradi - 273.15;
                    Console.WriteLine("Temperatūra ir " + KtoC + " celsija grādi");
                }
                else if (mervienibaOut == "F")
                {
                    double KtoF = (gradi * 1.8) - 459.67;
                    Console.WriteLine("Temperatūra ir " + KtoF + " fārenheiti");
                }
                else if (mervienibaOut == "K")
                {
                    Console.WriteLine("Temperatūra ir " + gradi + " kelvini");
                }
            }
            Console.ReadLine();
        }

    }
}
