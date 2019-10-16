using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter
{
    class Program
    {
        static void Main(string[] args)
        {
            char Karakter = 'a';

            Console.WriteLine(Karakter);

            int brojac = 20;

            while (brojac < 10)
            {
                Console.WriteLine(brojac);
                brojac += 1;
            }

            do
            {
                Console.WriteLine(brojac);
                brojac += 1;
            } while (brojac < 5);

            Console.WriteLine(Karakter);
            Console.ReadKey();

        }
    }
}
