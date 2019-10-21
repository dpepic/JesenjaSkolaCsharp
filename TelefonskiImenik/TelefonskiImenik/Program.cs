using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonskiImenik
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                (string ImeIPrezime, string Telefon)[] imenik = new (string ImeIPrezime, string Telefon)[5];


                Console.ReadKey();


                Console.Write("Meni\n" +
                                  "==============\n" +
                                  "1 -- Unos\n" +
                                  "2 -- Ispis\n" + 
                                  "3 -- Izlaz\n" +
                                  "==============\n" +
                                  "Izaberite: ") ;
                char unos = Console.ReadKey().KeyChar;

                Console.WriteLine();
                switch(unos)
                {
                    case '1':
                        Console.WriteLine("Izabra liste unos!");
                        break;
                    case '2':
                        Console.WriteLine("Izabrali ste ispis!");
                        break;
                    case '3':
                        Console.WriteLine("Dovidjenja :)");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Greska u unosu!");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
