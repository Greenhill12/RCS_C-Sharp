using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
    public class Kvadrats : Taisnsturis
    {
        public Kvadrats(double mala)
            // base() -> izsaukts 'virsklases' konstruktors
            : base(mala, mala)
        { 

        }

        /*
        public double MalasGarums;

        public Kvadrats(double mala)
        {
            this.MalasGarums = mala;
        }


        // void -> neatgriež rezultātu, tikai izvada
        public void Laukums()
        {
            double laukums = MalasGarums * MalasGarums;
            Console.WriteLine("Laukums = " + laukums);
        }

        //double -> metode atgriež aprēķināto rezulātu, ko var izmantot tālākiem aprēķiniem programmā
        public double Perimetrs()
        {
            double perimetrs = MalasGarums * 4;
            return perimetrs;
        }
        */
    }
}
