using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class Uzdevumi
    {
        public static void Kvadrats()
        {
            Kvadrats kvadrats1 = new Kvadrats();
            Console.WriteLine("Ievadi kvadrāta malas garumu: ");
            kvadrats1.malasGarums = Convert.ToInt32(Console.ReadLine());
            kvadrats1.laukums();
            kvadrats1.perimetrs();
            Console.WriteLine("Ievadi kvadrāta krāsu: ");
            kvadrats1.krasasNosaukums = Console.ReadLine();
            kvadrats1.krasasNoteiksana();
        }

        public static void Taisnsturis()
        {
            Taisnsturis taisnsturis1 = new Taisnsturis();
            Console.WriteLine("Ievadi taisnstūra vienas malas garumu: ");
            taisnsturis1.malasGarums1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi taisnstūra otras malas garumu: ");
            taisnsturis1.malasGarums2 = Convert.ToInt32(Console.ReadLine());
            taisnsturis1.laukums();
            taisnsturis1.perimetrs();
            Console.WriteLine("Ievadi taisnstūra krāsu: ");
            taisnsturis1.krasasNosaukums = Console.ReadLine();
            taisnsturis1.krasasNoteiksana();
        }
        public static void Aplis()
        {
            Aplis aplis1 = new Aplis();
            Console.WriteLine("Ievadi apļa rādiusu: ");
            aplis1.radiuss = Convert.ToInt32(Console.ReadLine());
            aplis1.laukums();
            aplis1.perimetrs();
            Console.WriteLine("Ievadi apļa krāsu: ");
            aplis1.krasasNosaukums = Console.ReadLine();
            aplis1.krasasNoteiksana();
        }
        public static void Trissturis()
        {
            Trissturis trissturis1 = new Trissturis();
            Console.WriteLine("Ievadi trīsstūra vienas malas garumu: ");
            trissturis1.malasGarums1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi trīsstūra otras malas garumu: ");
            trissturis1.malasGarums2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi trīsstūra trešās malas garumu: ");
            trissturis1.malasGarums3 = Convert.ToInt32(Console.ReadLine());
            trissturis1.perimetraNoteiksana();
            trissturis1.laukums();
            Console.WriteLine("Ievadi trisstūra krāsu: ");
            trissturis1.krasasNosaukums = Console.ReadLine();
            trissturis1.krasasNoteiksana();
        }
    }
}
