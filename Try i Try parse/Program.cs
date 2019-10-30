using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_i_Try_parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite element: ");
            //tryParse ne izaziva exception ako 
            //ne uspe da procita broj.
            //Koristimo ga cesto u if-u, 
            //jer on vrati true ako je uspeo da razume
            //prvi argument kao broj i smesti ga u drugi, 
            //kod nas int broj. Ako vrati false znamo da
            //korisnik nije uneo broj
            if (int.TryParse(Console.ReadLine(), out int broj))
            {
                int[] niz = { 3, 6, 10, 60, 45 };
                try //try blok nam je za rizicne operacije
                {  //ako nesto izazove exception, sto bi van try
                    //bloka izazvalo zaustavljane aplikacije
                    //ovde samo izazove izvrsavanje catch bloka
                    Console.WriteLine($"Element je: {niz[broj]}");
                }
                catch //catch blok nam je sta radimo kada dodje
                     //do izuzetka. 
                {
                    Console.WriteLine("Nema toliko elemenata!");
                }
                finally //finally ima garanciju da ce se izvrsiti
                {      //bez obzira na sve drugo
                    //van gasenja racunara tj :D
                    Console.WriteLine($"Niz ima {niz.Length} elemenata.");
                }
            } else
            {
                Console.WriteLine("Niste uneli broj!");
            }
            Console.ReadKey();
        }
    }
}
