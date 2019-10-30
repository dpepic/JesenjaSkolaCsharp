using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifriranje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite tekst: ");
            string txt = Console.ReadLine();
            Console.WriteLine("Unesite broj: ");
            int broj = int.Parse(Console.ReadLine());
            string sifrovano = "";
            foreach (char karakter in txt)
            {
                if ((karakter < (int)'a' ||
                    karakter > (int)'z') &&
                    (karakter < (int)'A' ||
                    karakter > (int)'Z'))
                {
                    sifrovano += karakter;
                } else if ( (karakter + broj > (int)'Z' &&
                            karakter < (int)'a') ||
                            karakter + broj > (int)'z')
                {
                    sifrovano += (char)(karakter + broj - 26);
                } else
                {
                    sifrovano += (char)(karakter + broj);
                }
            }
            Console.WriteLine($"Sifrovano je: {sifrovano}");
            Console.ReadKey();
        }
    }
}
