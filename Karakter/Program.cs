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

            Console.WriteLine("Koliko slova po redu? ");
            
            int slova = int.Parse(Console.ReadLine());

            while (Karakter <= 122)
            {
                Console.Write(Karakter);
                if ((Karakter - 96) % slova == 0)
                {
                    Console.WriteLine();
                }

                Karakter += (char)1; 
            }
            

            int brojac = 20;

            while (brojac < 10)
            {
                Console.WriteLine(brojac);
                brojac += 1;
            }

            do
            {
                //Console.WriteLine(brojac);
                brojac += 1;
            } while (brojac < 5);

            
            Console.ReadKey();

        }
    }
}
