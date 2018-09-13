using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena6
{
    public class DzerienuAutomats
    {
        public double Summa;
        public string Valuta;

        public DzerienuAutomats()
        {
            Summa = 0;
            Valuta = " eur";
        }

        public string GetSum()
        {
            return Summa.ToString("0.00") + Valuta;
        }
        
        public void Iemaksat()
        {
            Console.WriteLine("Jūs izvēlējāties iemaksāt naudu. Pašreiz Jūs esat iemaksājis " + GetSum() + ". Lūdzu iemaksājiet vēlamo summu: ");
            double iemaksa = Convert.ToDouble(Console.ReadLine());

            Summa += iemaksa;

            Console.WriteLine("Jūsu atlikums ir " + GetSum());            
        }
        
        public void Pirkt()
        {
            Console.WriteLine("Jūs izvēlējāties pirkt dzērienu");
            
            if(Summa < 0.8)
            {
                Console.WriteLine("Dzērienu nav iespējams nopirkt, jo iemaksātā summa ir " + GetSum() + ". Lai nopirktu dzērienu nepieciešams vismaz 0.80 eur.");
            }
            else
            {
                Summa = Summa - 0.8;
                Console.WriteLine("Jūs nopirkāt dzērienu. Jūsu atlikums ir " + GetSum()); 
            }         
        }

        public void SanemtAtlikumu()
        {
            Console.WriteLine("Jūs izvēlējāties saņemt atlikumu");

            if(Summa == 0)
            {
                Console.WriteLine("Jūs nevarat saņemt atlikumu, jo automātā nav iemaksāta nauda");
            }
            else
            {
                Console.WriteLine("Jūsu saņemat " + GetSum());
                Summa = 0;
                Console.WriteLine("Jūsu atlikums ir " + GetSum());
            } 
        }
    }
}
