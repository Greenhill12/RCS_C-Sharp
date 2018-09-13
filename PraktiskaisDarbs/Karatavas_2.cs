using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktiskaisDarbs
{
    public class Karatavas_2
    {
        // ĪPAŠĪBAS:
        // 1. vārdu saraksts (List<string>)
        List<string> Vardi;

        // 2. minamais vārds
        char[] MinamaisVards;

        // 3. atminētais vārds (char[])
        char[] AtminetaisVards;

        int atlikusieMeginajumi;



        // KONSTRUKTORS:
        // 1. aizpilda vārdu sarakstu
        public Karatavas_2()
        {
            Vardi = new List<string>()
            {
                "APPLE",
                "SUN",
                "ICE",
            };
        }

        // METODES
        // 1. uzsākt jaunu spēli
        public void StartNewGame()
        {
            // 1.1 random jāizvēlas vārds no saraksta
            Random rnd = new Random();
            Vardi = Vardi.OrderBy(v => rnd.Next()).ToList();
            string vards = Vardi[0];

            // 1.2 aizpildīt 'minamais vārds' ar vārda burtiem
            MinamaisVards = new char[vards.Length];

            // 1.3. aizpildīt 'atminamais vārds ar '_'
            AtminetaisVards = new char[vards.Length];

            atlikusieMeginajumi = 5;

            for (int i = 0; i < vards.Length; i++)
            {
                MinamaisVards[i] = vards[i];
                AtminetaisVards[i] = '_';
            }

            // 1.4. lietotājam izvada 'atminamais vārds' saturu
            Console.WriteLine(String.Join(" ", AtminetaisVards));
        }

        // 2. minēt burtu, saņem vienu parametru - burtu
        public void MinetBurtu(char burts)
        {
            bool vaiIrVarda = false;
            // 2.1. pārbaudīt, vai burts ir 'minamais vards'
            for (int i = 0; i < MinamaisVards.Length; i++)
            { 
                // 2.2. ja ir, tad aizstāj 'atminētais vārds' svītriņas tajā pašā pozīcijā ar burtu
                if(Char.ToUpper(MinamaisVards[i]) == Char.ToUpper(burts))
                {
                    if(AtminetaisVards[i] != Char.ToUpper(burts))
                    {
                        AtminetaisVards[i] = Char.ToUpper(burts);
                        vaiIrVarda = true;
                    }
                    else
                    {
                        Console.WriteLine("Šis burts jau ir atminēts");
                        break;
                    }
                }
            }

            if(vaiIrVarda)
            { 
                Console.WriteLine(String.Join(" ", AtminetaisVards));
            }
            else
            {
                atlikusieMeginajumi--;
                Console.WriteLine("Burts šajā vārdā nav. Atlikušie mēģinājumi: " + atlikusieMeginajumi);
            }
        }

        public string Vards()
        {
            return new string(MinamaisVards);
        }

        public bool VaiIrMeginajumi()
        {
            return atlikusieMeginajumi > 0;
        }

        // 3. vai vārds ir atminēts
        public bool VaiIrAtminets()
        {
            bool irAtminets = true;

            // 3.1. vai 'arminētais vārds satur '_'
            foreach(char burts in AtminetaisVards)
            {
                if (burts == '_')
                {
                    irAtminets = false;
                    break;
                }
            }

            return irAtminets;
        }
    }
}
