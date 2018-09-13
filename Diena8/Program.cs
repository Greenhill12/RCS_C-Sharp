using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
    class Program
    {
        static void Main(string[] args)
        {
            Kvadrats kvadrats = new Kvadrats(10);

            Aplis aplis = new Aplis(5);

            Taisnsturis taisnsturis = new Taisnsturis(5, 3);

            VeiktAprekinus("Kvadrāts: ", kvadrats);
            VeiktAprekinus("Aplis: ", aplis);
            VeiktAprekinus("Taisnstūris: ", taisnsturis);
                        
            Console.ReadLine();
        }

        static void VeiktAprekinus(string nosaukums, GeometriskaFigura fig)
        {
            Console.WriteLine(nosaukums);

            //izvada rezultātu
            fig.Laukums();

            //saņem aprēķināto rezultātu un tad izvada
            double perimetrs = fig.Perimetrs();
            Console.WriteLine("Perimetrs = " + perimetrs);

        }





        static void Piemers(string[] args)
        {
            Auto auto = new Auto();
            Lidmasina lidmasina = new Lidmasina();

            /*
            ParvietotAuto(auto);
            ParvietotLidmasinu(lidmasina);
            */

            Parvietot(auto);
            Parvietot(lidmasina);

            Console.ReadLine();
        }

        static void Parvietot(Transportlidzeklis tr)
        {
            tr.Parvietoties();
        }


        /*
        static void ParvietotAuto (Auto auto)
        {
            auto.Parvietoties();
        }

        static void ParvietotLidmasinu(Lidmasina lidmasina)
        {
            lidmasina.Parvietoties();
        }
        */
    }
}
