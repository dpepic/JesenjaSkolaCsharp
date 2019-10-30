using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj:\na");
            
            int broj = int.Parse(Console.ReadLine());

            //Ako je broj /3 -- Fizz
            //Ako je broj /5 -- Buzz
            //Ako je /3 i /5 -- FizzBuzz

            for (int i = 1; i <= broj; i++)
            {
                Console.Write($"{i} --- ");
                    
                if (i%3==0)
                {
                    Console.Write("Fizz");
                } 

                if (i%5==0)
                {
                    Console.Write("Buzz");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
