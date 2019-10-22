using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pocetak: ");
            int pocetak = int.Parse(Console.ReadLine());
            Console.WriteLine("Kraj: ");
            int kraj = int.Parse(Console.ReadLine());
            Console.WriteLine("Koliko po liniji?");
            int linija = int.Parse(Console.ReadLine());

            if (kraj <= pocetak)
            {
                Console.WriteLine("Greska!");
                Console.ReadKey();
                return;
            }
            
            for (int brojac = 0; brojac <= kraj - pocetak; brojac++)
            {
                Console.Write($" {(char)(pocetak + brojac)} ");
                if ((brojac) % linija == 0)
                    Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
