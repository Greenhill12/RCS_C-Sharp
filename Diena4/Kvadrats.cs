using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class Kvadrats
    {
        public int malasGarums;

        public string krasasNosaukums;

        public void laukums()
        {
            int laukums = malasGarums * malasGarums;
            Console.WriteLine("Kvadrata laukums ir " + laukums);
        }

        public void perimetrs()
        {
            int perimetrs = 4 * malasGarums;
            Console.WriteLine("Kvadrata perimetrs ir " + perimetrs);
        }

        public void krasasNoteiksana()
        {
            Console.WriteLine("Kvadrata krāsa ir " + krasasNosaukums);
        }
    }
}
