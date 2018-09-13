using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
    public class Iedzivotajs
    {
        public string Vards;

        public string Uzvards;

        // strukturizēta adrese
        public Adreses Dzivesvieta;

        public void Apraksts()
        {
            //Dzivesvieta.Pilseta
            Console.WriteLine(Vards);
            Console.WriteLine(Uzvards + " dzīvo " + Dzivesvieta.PilnaAdrese());
        }
    }
}
