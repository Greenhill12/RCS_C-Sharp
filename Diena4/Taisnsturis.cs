using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    class Taisnsturis
    {
        public int malasGarums1;

        public int malasGarums2;

        public string krasasNosaukums;

        public void laukums()
        {
            int laukums = malasGarums1 * malasGarums2;
            Console.WriteLine("Taisnstūra laukums ir " + laukums);
        }

        public void perimetrs()
        {
            int perimetrs = 2 * malasGarums1 + 2 * malasGarums2;
            Console.WriteLine("Taisnstūra perimetrs ir " + perimetrs);
        }

        public void krasasNoteiksana()
        {
            Console.WriteLine("Taisnstūra krāsa ir " + krasasNosaukums);
        }
    }
}
