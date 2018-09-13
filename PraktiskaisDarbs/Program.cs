using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktiskaisDarbs
{
    class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzz.Uzdevums();
            //Karatavas.Uzdevums();
            //DilstosaVirkne.Uzdevums();
            //Modinatajs.Uzdevums();
            //AtrumaParkapejs.Uzdevums();
            //Neveiksmigais13.Uzdevums();

            Karatavas_2 k = new Karatavas_2();
            k.StartNewGame();

            while(!k.VaiIrAtminets() && k.VaiIrMeginajumi())
            {
                Console.Write("Ievadi burtu: ");
                string ievade = Console.ReadLine();

                k.MinetBurtu(Convert.ToChar(ievade));
            }

            if(k.VaiIrMeginajumi())
            {
                Console.WriteLine("Vārds ir atminēts!");
            }
            else
            {
                Console.WriteLine("Beidzās mēģinājumi! Minamais vārds bija:");
                Console.WriteLine(k.Vards());
            }
            
            Console.ReadLine();
        }
    }
}
