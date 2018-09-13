using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena6
{
    public class DzerienuAutomats_2
    {
        public double Summa;

        public DzerienuAutomats_2()
        {
            Summa = 0;
        }

        public void Iemaksat(double summa)
        {
            Summa += summa;
        }

        public void PirktDzerienu()
        {
            if(Summa < 0.8)
            {
                Console.WriteLine("Nepietiek līzekļu!");
            }
            else
            {
                Summa -= 0.8;
                Console.WriteLine("Atlikums: " + Summa);
            }
        }
        public void IzdotAtlikumu()
        {
            Console.WriteLine("Tu saņēmi: " + Summa);
            Summa = 0;
        }

        public void Darbibas()
        {
            Console.WriteLine("Izvēlies darbību: ");
            Console.WriteLine("- Iemaksāt (i)");
            Console.WriteLine("- Pirkt (p)");
            Console.WriteLine("- Izdot atlikumu (a)");
            Console.WriteLine("- Beigt darbu (b)");

            while(true)
            {
                Console.Write("Darbība: ");
                string darbiba = Console.ReadLine().ToLower();
                if(darbiba == "b")
                {
                    break;
                }
                
                switch(darbiba)
                {
                    case "i":
                        Console.Write("Ievadi summu: ");
                        double summa = Convert.ToDouble(Console.ReadLine());
                        Iemaksat(summa);
                        break;
                    case "p":
                        PirktDzerienu();
                        break;
                    case "a":
                        IzdotAtlikumu();
                        break;
                    default:
                        Console.WriteLine("Nezināma darbība!");
                        break;
                }
            }
        }
    }
}
