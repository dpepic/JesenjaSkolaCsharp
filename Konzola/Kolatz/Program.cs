using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolatz
{
    class Program
    {
        static void Main(string[] args)
        {
            // paran, delimo sa 2
            //neparan, mnozimo sa 3, +1 

            Console.Write("Unesite broj: ");
            int broj = int.Parse(Console.ReadLine());

            while (broj != 1)
            {
                Console.WriteLine(broj);

                if (broj%2 == 0)
                {
                    broj /= 2;
                } else
                {
                    broj = broj * 3 + 1; 
                }
            }

            Console.WriteLine("1");
            Console.ReadKey();
        }
    }
}
