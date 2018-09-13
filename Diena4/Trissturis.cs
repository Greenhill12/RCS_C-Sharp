using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    class Trissturis
    {
        public double malasGarums1;
        public double malasGarums2;
        public double malasGarums3;
        public double perimetrs;
        public string krasasNosaukums;      
        
        public void laukums()
        {
            double pusp = (malasGarums1 + malasGarums2 + malasGarums3) / 2;
            double laukums = Math.Sqrt(pusp * (pusp - malasGarums1) * (pusp - malasGarums2) * (pusp - malasGarums3));
            Console.WriteLine("Trīsstūra laukums ir " + laukums);
        }

        public void perimetraNoteiksana()
        {
           perimetrs = malasGarums1 + malasGarums2 + malasGarums3;
            Console.WriteLine("Trīsstūra perimetrs ir " + perimetrs);
        }

        public void krasasNoteiksana()
        {
            Console.WriteLine("Trīsstūra krāsa ir " + krasasNosaukums);
        }
    }
}
