using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tim
{

    class Program
    {
        static void Main(string[] args)
        {
            (string Ime, string Telefon)[] Imenik = new (string, string)[0]; //Niz tuplova
                                               //Kao i svaki niz, samo sto element na svakom
                                               //indeksu sadrzi po dva stringa
            
            while (true) //meni vrtimo beskonacno, druga solucija je da
                        //svaki put ovde proveravamo je li korisnik izabrao da izadje
            {
                Console.Write("Meni\n" + // \n znaci novi red
                              "=======\n" +
                              "1 - Unos\n" +
                              "2 - Ispis\n" +
                              "3 - Izlaz\n" +
                              "Izaberite: ");
                char izbor = Console.ReadKey().KeyChar; //citamo samo jedan karakter
                Console.WriteLine(); //samo da nam se ispis spusti u iduci red
                switch(izbor)
                {
                    case '1':
                        Console.Write("Unesite ime: "); //kupimo informacije
                        string ime = Console.ReadLine();
                        Console.Write("Unesite telefon: ");
                        string tel = Console.ReadLine();

                        Array.Resize(ref Imenik, Imenik.Length + 1); //niz treba da nam bude koliko je bio velik
                                                                     //plus jos jedan element
                        Imenik[Imenik.Length-1].Ime = ime; //Upisujemo podatke na zadnje mesto u nizu
                        Imenik[Imenik.Length - 1].Telefon = tel;

                        break;
                    case '2':
                        Console.WriteLine("Imenik: \n==========");
                        foreach ((string ime, string tel) broj in Imenik) //uzimamo po tuple iz imenika
                                                                         //i stampamo ga
                        {
                            Console.WriteLine($"Ime: {broj.ime}\nTelefon: {broj.tel}\n-------------------");
                        }
                        break;
                    case '3':
                        Console.WriteLine("Dovidjenja!");
                        Console.ReadKey();
                        return; //izlaz iz programa
                    default: //slucaj ako ni jedan drugi slucaj nije ispunjen
                        Console.WriteLine("Greska!"); 
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
