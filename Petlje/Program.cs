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
            int brojac = -15;

            while (brojac > 0)
            {
                Console.WriteLine(brojac);
                brojac++;
            }

            do
            {
                Console.WriteLine(brojac);
                brojac--;
            } while (brojac > 0);

            for (int x = 0;; x++)
            {
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

            Console.ReadKey();
        }
    }
}
