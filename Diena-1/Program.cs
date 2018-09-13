using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena1
{
    class Program
    {
        static void Main(string[] args)
        {
            string izvadamsTeksts = Teksts();
            izvadamsTeksts = izvadamsTeksts + " " + Skaitlis();

            Console.WriteLine(izvadamsTeksts);
            BezRezultata();

            // sagaidīt lietotāja ievadi
            Console.ReadLine();
        }

        static void BezRezultata()
        {
            Console.WriteLine("Izsaukta funkcija BezRezultata");
        }

        static string Teksts()
        {
            return "Hello world!";
        }

        static int Skaitlis()
        {
            return 5;
        }
    }
}
