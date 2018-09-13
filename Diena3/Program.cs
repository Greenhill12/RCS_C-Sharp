using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers();
            //Uzdevumi.Uzdevums1();
            //Uzdevumi.Uzdevums2();
            //Uzdevumi.Gadi();
            //Uzdevumi.Kvadrati();
            //Uzdevumi.Summa();
            //Uzdevumi.SkaitluIzvele();
            //Uzdevumi.Rezgis();
            //Uzdevumi.Trijsturis();
            //Uzdevumi.Rombs();
            Uzdevumi.WhilePiemers();

            Console.ReadLine();
        }



        static void Piemers()
        {
            string mervieniba = "C";

            switch(mervieniba)
            {
                case "C":
                    Console.Write("Ievadīti Celsiji");
                    break;
                case "F":
                    Console.Write("Ievadīti Fārenheiti");
                    break;
                case "K":
                    Console.Write("Ievadīti Kelvini");
                    break;
                default:
                    Console.Write("Nezināma mērvienība");
                    break;
            }
        }
    }
}
