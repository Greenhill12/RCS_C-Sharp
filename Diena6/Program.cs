using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena6
{
    public class Program
    {
        static void Main(string[] args)
        {
            DzerienuAutomats_2 aut = new DzerienuAutomats_2();
            aut.Darbibas();

            
            /*
            Console.WriteLine("Lai nopirktu dzērienu iemaksā vismaz 0,80 eur.");         

            DzerienuAutomats dzerienuAutomats = new DzerienuAutomats();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Lūdzu ievēlieties darbību kuru vēlies veikt (Iemaksat/Pirkt/Atlikums/Partraukt): ");

                string darbiba = Console.ReadLine().ToLower();
            
                if(darbiba == "iemaksat")
                {
                    dzerienuAutomats.Iemaksat();                    
                }
                else if(darbiba == "pirkt")
                {
                    dzerienuAutomats.Pirkt();
                }
                else if (darbiba == "atlikums")
                {
                    dzerienuAutomats.SanemtAtlikumu();
                }
                else if (darbiba == "partraukt")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ievadītā darbība neatbilst automāta iespējām!");
                }

            }

            */


            Console.WriteLine();
        }
    }
}
