using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prvi broj: ");
            string unos = Console.ReadLine();
            //ReadLine uzima red unosa od korisnika.
            //To smestamo u string da bi mogli da iskoristimo kasnije
            int broj1 = int.Parse(unos);
            //int.Parse ce pokusati da procita celobrojnu vrednost
            //iz stringa. Ako uspe, smestamo je u broj1.
            //Ako ne ode program :D

            Console.Write("Unesite drugi broj: ");
            unos = Console.ReadLine();
            int broj2 = int.Parse(unos);

            int zbir = broj1 + broj2;


            //Matematicko i, tj && kod nas
            // False && False daje False
            // T && F daje F
            // F && T daje F
            // T && T daje T
            //Znaci, jedino ako su obe strane istinite
            //rezultat && ce biti true
            if (zbir > 10 && zbir < 20 ) //Prvi uslov
            {
                Console.WriteLine("Zbir je veci od 10 i manji od 20!!");
            } else if (zbir < 5) //Drugi uslov
            {
                Console.WriteLine("Manji od 5!");
            }
            else //Ako nista nije ispunjeno onda ovo
            {
                Console.WriteLine("Izmedju 5 i 10!");
            }

            //Kod lanca if uslova uvek ce se
            //izvrsiti jedna i samo jedna grana
            //Kao sto vidite ovde, obe su istinite,
            //no kako se izvrsi prva sve se ostalo
            //preskace
            int x = 5;
            int y = 5;
            if ( x == y) //duplo jednako kada poredimo
            {
                Console.WriteLine("Prva grana");
            } else if (x != y)
            {
                Console.WriteLine("Druga grana");
            }

            Console.WriteLine("Unesite slovo: ");
            string slovo = Console.ReadLine();

            switch (slovo)
            {
                case "a":
                    Console.WriteLine("Uneli ste \"a\"");
                    break;//asdasd
                case "b":
                case "c":
                    Console.WriteLine("Uneli ste \"c\" a mozda i \"b\"");
                    break;
                case "d":
                    Console.WriteLine("Uneli ste \"d\"");
                    break;
            }

            Console.WriteLine($"Zbir je: {broj1 + broj2} .");
            Console.ReadKey();
            
        }
    }
}
