using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            byte nekiBajt;
            nekiBajt = 6;

            int ceoBroj; 
            ceoBroj = nekiBajt; //implicitan casting
            //implicitan cast je moguc jedino
            //u slucaju kada ne postoji sansa
            //da se izgubi ili osteti podatak
            //Znaci, po pravilu, kada castamo
            //manji tip podatka u veci


            int ceoBroj2 = 6;
            byte nekiBajt2;

            nekiBajt2 = (byte)ceoBroj2;//ekspicitan casting
            //Ako zelimo da prebacimo veci tip
            //podatka u manji cast moramo da 
            //naznacimo tako sto stavimo zeljeni
            //tip podatka u zagrade


            Console.WriteLine($"nekiBajt je: {nekiBajt2} vrednost inta je {ceoBroj2}");

            ceoBroj2 = 257;
            nekiBajt2 = (byte)ceoBroj2;
            Console.WriteLine($"nekiBajt je: {nekiBajt2} vrednost inta je {ceoBroj2}");
            //Kao sto vidimo na ovom primeru,
            //eksplicitno castanje odreze koliko mu treba :) 
            //U ovom slucaju, castamo int u bajt. On uzima
            //prvih osam bitova iz inta, ostatak u potpunosti zanemaruje


            int cBroj = 55;
            double brojSaOstatkom = cBroj;

            double brOstatak = 3.75;
            int cBroj2 = (int)brOstatak;

            Console.WriteLine($"{brOstatak} -- {cBroj2}");
            //Bitno je da razumemo da je eksplicitno
            //kastovanje "nasilno" skracivanje.
            //U ovom primeru, mi bi 3.75 zaokruzili pre
            //na 4, no cast samo zanenmari to sto mu je viska pa
            //3.75 postane celobrojno 3. Isto bi bilo
            //i sa 3.99999 :) 


            Console.ReadKey();
        }
    }
}
