using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
    public class Uzdevumi
    {
        public static void Uzdevums24()
        {
            int[] saraksts = { 0, 10, 20, 30, 40, 50 };
            int skaitsMasiva = saraksts.Length;

            Console.WriteLine("Ievadi lūdzu skaitli: ");
            int sk = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < saraksts.Length; i++)
            {
                if (sk == saraksts[i])
                {
                    Console.WriteLine("Skaitlis ir masīvā.");
                    Console.WriteLine("Tas ir " + i + ". pozīcijā");
                    return;
                }                             
            }

            Console.WriteLine("Skaitlis nav atrasts!");
        }

        public static void Uzdevums25()
        {
            List<int> saraksts = new List<int>();
            while(true)
            {
                Console.WriteLine("Ievadi lūdzu skaitli vai 0, lai pārtrauktu: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if (skaitlis == 0)
                {
                    break; // pārtrauc while ciklu
                }
                saraksts.Add(skaitlis);
            }
            for (int i = saraksts.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(saraksts[i]);
            }
        }

        public static void Uzdevums26()
        {
            List<int> saraksts = new List<int>();
            while (true)
            {
                Console.WriteLine("Ievadi lūdzu skaitli vai 0, lai pārtrauktu: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if (skaitlis == 0)
                {
                    break; // pārtrauc while ciklu
                }
                saraksts.Add(skaitlis);
            }

            int skaits = 0;

            foreach(int sk in saraksts)
            {
                if (sk == 5)
                {
                    skaits++;
                }                    
            }

            Console.WriteLine("Kopā skaitļi 5 tika ievadīti " + skaits + " reizes");
        }

        public static void Uzdevums27()
        {
            List<int> saraksts = new List<int>();
            while (true)
            {
                Console.WriteLine("Ievadi lūdzu skaitli vai 0, lai pārtrauktu: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if (skaitlis == 0)
                {
                    break; // pārtrauc while ciklu
                }
                saraksts.Add(skaitlis);
            }
            // Pieejams tikai List
            //int MaxValue = saraksts.Min();
            //int MinValue = saraksts.Max();

            int MaxValue = saraksts[0];
            int MinValue = saraksts[0];

            foreach (int sk in saraksts)
            {
                if (sk < MinValue)
                {
                    MinValue = sk;
                }
                else if(sk > MaxValue)
                {
                    MaxValue = sk;
                }

            }

            Console.WriteLine("Minimālais skaitlis, kas tika ievadīts ir " + MinValue);
            Console.WriteLine("Maksimālais skaitlis, kas tika ievadīts ir " + MaxValue);
        }

        public static void Uzdevums28()
        {
            List<Prece> saraksts = new List<Prece>();

            /*
            saraksts.Add(new Prece()
            {
                Cena = 900,
                Nosaukums = "Dators"
            });

            */

            // vai

            saraksts.Add(new Prece("Dators", 900));
            saraksts.Add(new Prece("Bikses", 50));
            saraksts.Add(new Prece("Auto", 10000));
            saraksts.Add(new Prece("Mobilais", 200));
            saraksts.Add(new Prece("TV", 550));
            saraksts.Add(new Prece("Koferis", 100));
            saraksts.Add(new Prece("Cimdi", 20));
            saraksts.Add(new Prece("Cepure", 10));

            Console.WriteLine("Pieejamās preces: ");
            Console.WriteLine();

            //foreach (Prece pr in saraksts)
            foreach (var pr in saraksts)
            {
                Console.WriteLine(pr.Nosaukums + " $" + pr.Cena);
            }

            Console.WriteLine();

            List<string> saraksts2 = new List<string>();

            while (true)
            {
                Console.WriteLine("Lūdzu izvēlies, ko gribi un ievadi zemāk. Ja iepirkšanos vēlies beigt, ievadi 0: ");
                string item = Console.ReadLine();
                if (item == "0")
                {
                    break; // pārtrauc while ciklu
                }

                saraksts2.Add(item);
            }
            double summa = 0;

            foreach (string a in saraksts2)
            {
                foreach (Prece p in saraksts)
                {
                    if (a == p.Nosaukums)
                    {
                        summa += p.Cena;
                        break;
                    }
                }
            }

            Console.WriteLine(summa);
        }           
    }
}
