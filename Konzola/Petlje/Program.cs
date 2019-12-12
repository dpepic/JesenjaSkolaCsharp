using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlje
{
    class Program
    {
        static void Main(string[] args)
        {
            int brojac = 0;

            //While petlja. Prvo proverava uslov,
            //zatim izvrsava telo pa ponovo provera.
            //Kada uslov postane false, tada prestaje
            //da se izvrsava
            while (brojac < 10)
            {
                Console.WriteLine(brojac);
                brojac++;
            }

            //Do while petlja
            //Razlikuje se od while petlje po samo 
            //jednom. Do while petlja se garantovano
            //izvrsi jednom, pa tek onda proverava 
            //uslov da vidi ima li potrebe da radi jos
            do
            {
                Console.WriteLine(brojac);
                brojac--;
            } while (brojac > 0);


            //For petlja ima tri komponente:
            //   inicijalizacija     uslov        operacija
            for (int x = 0    ;        x < 10 ;       x++)
            {
                /* Tok for petlje je sledeci:
                 * Jednom i samo jednom se izvrsi inicijalizacija
                 * Proveri se uslov, ako je netacan to je to, kraj
                 * Ako je tacan, izvrsava se telo petlje
                 * Zatim ide operacija pa se ponovo proverava uslov */
                if (x == 2)
                {
                    continue;
                }
                Console.WriteLine("asd");
                if (x > 5)
                {
                    break;
                }
            }

            int[] niz = { 2, 5, 7, 8, 19 };

            //Za foreach petlju nam trebaju dve stvari
            //Damo joj promenljivu i kolekciju nekih vrednosti
            //Pri svakoj iteraciji, proverava ima li vrednosti u
            //kolekciji, ako ima, kopira iducu u promenljivu
            //Na vrednosti ne mozemo uticati iz foreach petlje
            //jer ih bas bas kopira, tako da nema nacina da
            //menjamo original. Kod nizova ih primarno koristimo
            //za ispis
            foreach (int broj in niz)
            {
                Console.WriteLine(broj);
            }

            Console.ReadKey();
        }
    }
}
