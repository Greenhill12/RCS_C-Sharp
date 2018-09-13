using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    class Program
    {

        static void Main(string[] args)
        {
            //Uzdevumi.Kvadrats();
            //Uzdevumi.Taisnsturis();
            //Uzdevumi.Aplis();
            //Uzdevumi.Trissturis();
            Skolens();

            Console.ReadLine();
        }

        static void Skolens()
        {
            U_Vertejums info = new U_Vertejums();
            info.Atzime = 7;
            info.Skolens = new U_Skolens();
            info.Skolens.Vards = "Andrejs";
            info.Skolens.Uzvards = "Kalniņš";
            info.Skolens.Epasts = "a.kalnins@mail.lv";
            info.Skolens.DzGads = 1988;
            info.Prieksmets = new U_MacibuPrieksmets();
            info.Prieksmets.Nosaukums = "Matemātika";
            info.Prieksmets.Pasniedzejs = new U_Skolotajs();
            info.Prieksmets.Pasniedzejs.Vards = "Juris";
            info.Prieksmets.Pasniedzejs.Uzvards = "Priede";
            info.Prieksmets.Pasniedzejs.Epasts = "jurcixxx@inbox.lv";
            info.Prieksmets.Telpa = new U_Telpa();
            info.Prieksmets.Telpa.Numurs = 23;
            info.Prieksmets.Telpa.Stavs = 5;
            info.Skolens.Klase = new U_Klase();
            info.Skolens.Klase.Nosaukums = "7b";
            info.Skolens.Klase.SkolenuSkaits = 29;
            
            info.informacija();
        }


        static void Piemers(string[] args)
        {
            Auto auto1 = new Auto();
            auto1.MaxAtrums = 200;
            auto1.Krasa = "sudrabotā";
            auto1.Braukt();
            auto1.KrasasNoteiksana();

            Auto auto2 = new Auto();
            auto2.MaxAtrums = 150;
            auto2.Krasa = "sarkanā";
            auto2.Braukt();
            auto2.KrasasNoteiksana();

            Console.ReadLine();
        }
    }
}
