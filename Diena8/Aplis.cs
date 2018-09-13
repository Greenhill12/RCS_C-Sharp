using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
    public class Aplis : GeometriskaFigura
    {
        public double Radiuss;

        public Aplis(double radiuss)
        {
            this.Radiuss = radiuss;
        }

        // void -> neatgriež rezultātu, tikai izvada
        public void Laukums()
        {
            double laukums = Math.PI * Radiuss * Radiuss;
            Console.WriteLine("Laukums = " + laukums);
        }

        //double -> metode atgriež aprēķināto rezulātu, ko var izmantot tālākiem aprēķiniem programmā
        public double Perimetrs()
        {
            double perimetrs = Math.PI * Radiuss * 2;
            return perimetrs;
        }
    }
}
