using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
    public class Taisnsturis : GeometriskaFigura
    {

        public double Mala1;
        public double Mala2;

        public Taisnsturis(double mala1, double mala2)
        {
            this.Mala1 = mala1;
            this.Mala2 = mala2;
        }

        // void -> neatgriež rezultātu, tikai izvada
        public void Laukums()
        {
            double laukums = Mala1 * Mala2;
            Console.WriteLine("Laukums = " + laukums);
        }

        //double -> metode atgriež aprēķināto rezulātu, ko var izmantot tālākiem aprēķiniem programmā
        public double Perimetrs()
        {
            double perimetrs = (Mala1 + Mala2) * 2;

            return perimetrs;
        }
    }
}
