using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<long> niz = new List<long>();
            //niz.Add(0);
            //niz.Add(1);

            Console.Write("Koliko elemenata? ");
            int ele = int.Parse(Console.ReadLine());

            long[] basBasNiz = new long[ele];
            basBasNiz[1] = 1;
            Console.WriteLine("0\n1");
            for (int i = 2; i < ele; i++)
            {
                basBasNiz[i] = basBasNiz[i - 1] + basBasNiz[i - 2];
                Console.WriteLine(basBasNiz[i]);
            }
            Console.ReadKey();
        }
    }
}
