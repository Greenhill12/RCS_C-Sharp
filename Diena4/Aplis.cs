using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    class Aplis
    {
        public double radiuss;

        public string krasasNosaukums;

        public void laukums()
        {
            double laukums = Math.PI * radiuss * radiuss;
            Console.WriteLine("Apļa laukums ir " + laukums);
        }

        public void perimetrs()
        {
            double perimetrs = 2 * Math.PI * radiuss;
            Console.WriteLine("Apļa perimetrs ir " + perimetrs);
        }

        public void krasasNoteiksana()
        {
            Console.WriteLine("Apļa krāsa ir " + krasasNosaukums);
        }
    }
}
