using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers();
            //Vecums();
            //SkaitluSalidzinasana();
            MenesuDienas();

            Console.ReadLine();
        }

        static void Vecums()
        {
            int vecums = AtgriezVecumu();

            if (vecums >= 18)
            {
                Console.Write("Tavs vecums ir vismaz 18 gadi");
            }
            else
            {
                Console.Write("Tavs vecums nav vēl 18 gadi");
            }
        }

        static int AtgriezVecumu()
        {
            Console.Write("Ievadi savu vecumu:");
            int vecums = Convert.ToInt32(Console.ReadLine());
            return vecums;
        }
        


        static void SkaitluSalidzinasana()
        {
            int skaitlis1 = AtgriezSkaitli1();
            int skaitlis2 = AtgriezSkaitli2();

            if (skaitlis1 == skaitlis2)
            {
                Console.Write("Skaitļi ir vienādi");
            }
            else
            {
                Console.Write("Skaitļi nav vienādi");
            }
        }

        static int AtgriezSkaitli1()
        {
            Console.Write("Ievadi skaitli Nr.1: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            return skaitlis1;
        }

        static int AtgriezSkaitli2()
        {
            Console.Write("Ievadi skaitli Nr.2: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());
            return skaitlis2;
        }


        static void MenesuDienas()
        {
            Console.Write("Ievadi mēneša pirmos trīs burtus: ");
            string menesis = Console.ReadLine().ToLower();

            if (menesis == "feb")
            {
                Console.Write("Mēnesī ir 28 dienas. Ja ir garais gads, tad 29 dienas");
            }
            else if (menesis == "apr" || menesis == "jun" || menesis == "sep" || menesis == "nov")
            {
                Console.Write("Mēnesī ir 30 dienas");
            }
            else if (menesis == "jan" || menesis == "mar" || menesis == "mai" || menesis == "jul" || menesis == "aug" || menesis == "okt" || menesis == "dec")
            {
                Console.Write("Mēnesī ir 30 dienas");
            }
            else
            {
                Console.Write("Ievadītais neatbilst prasītajam");
            }
        }



        static void Piemers()
        {
            int skaitlis = AtgriezSkaitli();

            if(skaitlis > 10)
            {
                Console.Write("Skaitlis ir lielāks par 10");
            }
            else if(skaitlis == 10)
            {
                Console.Write("Skaitlis ir vienāds ar 10");
            }
            else if (skaitlis == 9)
            {
                Console.Write("Skaitlis ir vienāds ar 9");
            }
            else
            {
                Console.Write("Skaitlis ir mazāks par 10");
            }
        }

        static int AtgriezSkaitli()
        {
            return 5;   
        }
    }
}
