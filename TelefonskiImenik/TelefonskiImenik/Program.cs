using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tim
{

    class Program
    {
        static void Main(string[] args)
        {
            List<(string Ime, string Telefon)> Imenik = new List<(string, string)>(); //Niz tuplova
                                                                                      //Kao i svaki niz, samo sto element na svakom
                                                                                      //indeksu sadrzi po dva stringa

            if (File.Exists("Imenik.txt"))
            {
                foreach (string red in File.ReadLines("Imenik.txt"))
                {
                    string[] razdvojeno = red.Split(';');
                    Imenik.Add((razdvojeno[0], razdvojeno[1]));
                }
            }

            while (true) //meni vrtimo beskonacno, druga solucija je da
                        //svaki put ovde proveravamo je li korisnik izabrao da izadje
            {
                Console.Write("Meni\n" + // \n znaci novi red
                              "=======\n" +
                              "1 - Unos\n" +
                              "2 - Ispis\n" +
                              "3 - Brisanje\n" +
                              "4 - Izlaz\n" +
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
                        Imenik.Add((ime, tel));
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
                        Console.Write("Unesite ime ili indeks: ");
                        string unos = Console.ReadLine();
                        if (int.TryParse(unos, out int indeks))
                        {
                            if (indeks - 1 < Imenik.Count)
                            {
                                Imenik.RemoveAt(indeks - 1);
                            }
                            else
                            {
                                Console.WriteLine("Nepostojeci indeks!");
                            }
                        } else
                        {
                            for (int i = 0; i < Imenik.Count; i++)
                            {
                                if (Imenik[i].Ime.Contains(unos))
                                {
                                    Imenik.RemoveAt(i);
                                    break;
                                }
                            }
                        }
                        break;
                    case '4':
                        Console.WriteLine("Dovidjenja!");
                        File.Delete("Imenik.txt");
                        foreach ((string ime, string tel) osoba in Imenik)
                        {
                            File.AppendAllText("Imenik.txt",
                                osoba.ime + ";" + osoba.tel + Environment.NewLine);
                        }
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
