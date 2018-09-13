using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktiskaisDarbs
{
    public class Modinatajs
    {
        public static void Uzdevums()
        {
            Console.WriteLine("Ievadi nedēļas dienu (P, O, T, C, Pk, S, Sv): ");
            string diena = Console.ReadLine().ToLower();
            Console.WriteLine("Ievadi, vai esi avaļinājumā (J/N): ");
            char atvalinajums = Convert.ToChar(Console.ReadLine().ToLower());

            string modinatajs0700 = "Modinātājs 7:00";
            string modinatajs1000 = "Modinātājs 10:00";
            string modinatajsOff = "Modinātājs Off";

            switch (diena)
            {
                case "p":
                case "o":
                case "t":
                case "c":
                case "pk":
                    if(atvalinajums == 'j')
                    {
                        Console.WriteLine(modinatajs1000);
                    }
                    else
                    {
                        Console.WriteLine(modinatajs0700);
                    }
                    //Console.Write(atvalinajums == "j" ? "10:00" : "7:00")
                    break;
                case "s":
                case "sv":
                    if(atvalinajums == 'j')
                    {
                        Console.WriteLine(modinatajsOff);
                    }
                    else
                    {
                        Console.WriteLine(modinatajs1000);
                    }
                    break;

            }
        }
    }
}
