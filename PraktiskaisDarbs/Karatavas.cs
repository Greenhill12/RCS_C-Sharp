using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktiskaisDarbs
{
    public class Karatavas
    {
        public static void Uzdevums()
        {
            string[] vardi = { "aka", "debesis", "maja", "lampa", "galds", "programma", "dators", "cepure" };
            int skaitsMasiva = vardi.Length;

            // tiek izvēlēts nejaušs skaitlis
            Random rnd = new Random();
            int vards = rnd.Next(skaitsMasiva);

            // tiek skaitlis ielikts masīvā un izvadīts vārds
            string uzminiVardu = vardi[vards];
            // izvēlētais vārds tiek sadalīts pa burtiem un ielikts jaunā masīvā
            char[] burti = uzminiVardu.ToCharArray();
            // burtu skaits vārdā
            int burtiVarda = burti.Length;

            // tiek izvadītas pirmās tukšās līnijas
            

            char[] burtiKopa = new char[burtiVarda];

            for(int i = 0; i < burtiVarda; i++)
            {
                burtiKopa[i] = '_';
            }

            foreach(char r in burtiKopa)
            {
                Console.Write(r + " ");
            }
            // šādu rindu vēl nemākam

            //Console.WriteLine(String.Join(" ", burtiKopa));

            for(int k = burtiVarda + 5; k >= 1; k--)
            {                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Mini burtu vēl " + k + " reizes: ");
                char burts = Convert.ToChar(Console.ReadLine());

                for(int j = 0; j < burtiVarda; j++)
                {
                    if (burts == burti[j])
                    {
                        burtiKopa[j] = burts;
                    }                   
                }

                foreach(char u in burtiKopa)
                {
                    Console.Write(u + " ");
                }

                // Izvada katru burtu vai atstarpi kas ir burtiKopa (vēl nemākam)

                //Console.WriteLine(String.Join(" ", burtiKopa));
            }
            Console.WriteLine();
            Console.WriteLine("Tu zaudēji!!!");             
        }
    }
}
