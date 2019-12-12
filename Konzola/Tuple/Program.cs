using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tuple je struktura u koju mozemo da stavimo vise od jedne promenljive
            (int sirina, int visina, int povrsina) Pravougaonik;
            Pravougaonik.sirina = 5;
            Pravougaonik.visina = 10;
            Pravougaonik.povrsina = Pravougaonik.visina * Pravougaonik.sirina;

            //U tuple mozemo da stavimo razlicite tipove
            (string naziv, int kolicina, decimal cena) Artikal = ("primer", 5, (decimal)3.55);

            //Mozemo da napravimo niz tuplova
            (int RedniBroj, string Ime)[] klijent = new (int, string)[5];

        }
    }
}
