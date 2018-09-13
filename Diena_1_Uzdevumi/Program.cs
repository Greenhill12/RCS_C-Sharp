using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena_1_Uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            //VardaIzvade();

            //SkaitluSumma();

            //SkaitluDarbibas();

            //SkaitluReizinajums();

            Gradi();
        }

        static void VardaIzvade()
        {
            Console.Write("Ievadi vārdu: ");
            string vards = Console.ReadLine();

            Console.Write("Ievadi uzvārdu: ");
            string uzvards = Console.ReadLine();

            Console.Write("Ievadi vecumu: ");
            int vecums = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tevi sauc " + vards + " " + uzvards);
            Console.WriteLine("Tavs vecums ir " + vecums);

            Console.ReadLine();
        }

        static void SkaitluSumma()
        {
            Console.Write("Ievadi skaitli Nr.1: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi skaitli Nr.2: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            int summa = skaitlis1 + skaitlis2;
            Console.WriteLine("Skaitļu summa ir " + summa);

            Console.ReadLine();
        }

        static int SkaitlaIevade(string teksts)
        {
            Console.Write(teksts);
            return Convert.ToDouble(Console.ReadLine());
        }

        static void SkaitluDarbibas()
        {

            // koda optimizācija, skatīt iepriekš uzrakstīto SkaitlaIevade
            double skaitlis1 = SkaitlaIevade("Ievadi skaitli Nr.1: ");
         
            Console.Write("Ievadi skaitli Nr.2: ");
            double skaitlis2 = Convert.ToDouble(Console.ReadLine());

            double summa = skaitlis1 + skaitlis2;
            double starpiba = skaitlis1 - skaitlis2;
            double reizinajums = skaitlis1 * skaitlis2;
            double dalijums = skaitlis1 / skaitlis2;
            double atlikums = skaitlis1%skaitlis2;

            Console.WriteLine();
            Console.WriteLine("Skaitļu summa ir " + summa);
            Console.WriteLine("Skaitļu starpība ir " + starpiba);
            Console.WriteLine("Skaitļu reizinājums ir " + reizinajums);
            Console.WriteLine("Skaitļu dalījums ir " + dalijums);
            Console.WriteLine("Skaitļu dalīšanas atlikums ir " + atlikums);

            Console.ReadLine();
        }

        static void SkaitluReizinajums()
        {
            Console.Write("Ievadi skaitli Nr.1: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi skaitli Nr.2: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi skaitli Nr.3: ");
            int skaitlis3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            int reizinajums = skaitlis1 * skaitlis2 * skaitlis3;
            Console.WriteLine("Skaitļu reizinājums ir " + reizinajums);
         
            Console.ReadLine();
        }

       static void Gradi()
        {
            Console.Write("Ievadi grādus pēc Celsija: ");

            //float vietā var lietot double, tad pie Convert nav jāliet (float)
            float celsijs = (float)Convert.ToDouble(Console.ReadLine());

            double kelvini = celsijs + 273.15;

            float farenheiti = celsijs * 1.8f + 32;

            Console.WriteLine();
            Console.WriteLine("Grādi pēc Kelvina ir " + kelvini);         
            Console.WriteLine("Grādi pēc Fārenheita ir " + farenheiti);

            Console.ReadLine();
        }        
    }
}
