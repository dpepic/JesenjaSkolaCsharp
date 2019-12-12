using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pravougaonik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite sirinu: ");
            int sirinaUnos = int.Parse(Console.ReadLine());
            Console.Write("Unesite visinu: ");
            int visinaUnos = int.Parse(Console.ReadLine());

            for (int visina = 0; visina < visinaUnos; visina++)
            {
                for (int sirina = 0; sirina < sirinaUnos; sirina++)
                {
                    if ((visina == 0 || visina == visinaUnos - 1) ||
                        (sirina == 0 || sirina == sirinaUnos - 1))
                    {
                        Console.Write(" + ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
