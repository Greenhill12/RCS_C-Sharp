using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class U_Vertejums
    {

        public U_Skolens Skolens;
        public U_MacibuPrieksmets Prieksmets;
        public int Atzime;

        public void informacija()
        {
            Console.WriteLine("Skolēna vārds: " + Skolens.Vards);
            Console.WriteLine("Skolēna uzvārds: " + Skolens.Uzvards);
            Console.WriteLine("Mācību priekšmets: " + Prieksmets.Nosaukums);
            Console.WriteLine("Atzīme: " + Atzime);
            Console.WriteLine("Pasniedzējs: " + Prieksmets.Pasniedzejs.Vards + " " + Prieksmets.Pasniedzejs.Uzvards);
        }
    }
}
