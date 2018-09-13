using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class Auto
    {
           // Auto īpašība
        public string Krasa;

        public int MaxAtrums;

        public void Braukt()
        {
            Console.WriteLine("Auto brauc! MaxAtrums = " + MaxAtrums);
        }

        public void KrasasNoteiksana()
        {
            Console.WriteLine("Auto ir " + Krasa + " krāsā!");
        }
    }
}
