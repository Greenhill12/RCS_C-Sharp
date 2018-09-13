using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktiskaisDarbs
{
    public class FizzBuzz
    {
        public static void Uzdevums()
        {
            Console.WriteLine("Ievadi sākuma skaitli: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi beigu skaitli: ");
            int last = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (first > last)
            {
                Console.WriteLine("Ievadītais sākuma skaitlis ir lielāks par ievadīto beigu skaitli");
            }
            else
            {
                for (int i = first; i <= last; i++)
                {
                    if (i % 15 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }           
        }        
    }
}
