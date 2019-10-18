using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promenljive
{
    class Program
    {
        static void Main(string[] args)
        {  //Za sada, sve sto radimo pocinje od ove viticaste zagrade ovde, ovo iznad nas nista ne intresuje

            byte bajt = 4; //Bajt je od 0 do 255 
            sbyte bajtSaZnakom = -4; //sbyte (Signed Byte) je, pak, od -128 do 127 jer koristimo polovinu
                                     //opsega standardnog bajta da bi prikazali negativne brojeve

            int ceoBroj = 100; //int -- kratko od integer -- nam je standardan i podrazumevani nacin da predstavimo ceo 
                               //broj. Do te mere da, kada u C# bilo gde napisemo nesto poput 5, -34 ili 868, on automatski
                               //smatra da se radi o int vrednosti

            /*
             * Console.WriteLine -- to nam je metoda koju koristimo
             * Unutar zagrada idu ulazni parametri, tj. informacije koje joj trebaju
             * Ovde koristimo par stvari. sizeof() ce da nam da velicinu tipa, u bajtovim. Njen
             * Ulazni parametar je, naravno, tip. 
             * Pored toga, svaki tip je u stanju da nam kaze koja je minimalna vrednost koju mozemo da stavimo
             * u njega, kao i maksimalna, tako sto kazmo tip.Min ili MaxValue. Npr, long.MaxValue */
            Console.WriteLine("Jedan int zauzima " + sizeof(int) + " bajta.");
            Console.WriteLine("Minimalna vrednost mu je " + int.MinValue + " a maksimalna " + int.MaxValue +".");
            Console.WriteLine(); //Posto WriteLine ispise jednu liniju pa se onda spusti u drugu, ako hocu samo
                                 //da napravim razmak izmedju dve linije teksta, pozovem ga bez parametara,
                                 //kao sto sam spominjao, zagrade ipak moraju da su tu, bukvalista :), i on napravi
                                 //bas to, samo prazan red

            uint ceoBrojBezZnaka = 56; //Za razliku od bajta, kod svih ostalih tipova moramo da naznacimo
                                       //kada nam negativne vrednosti NE trebaju (uint -- unsigned integer)

            /*
             * Primetili ste, verovatno, da je pri ispisu dosta nezgodno kombinovati promenljive sa tekstkom,
             * non sto moramo "tekst " + promenljiva + " jos teksta.". Postoji laksi nacin.
             * Ako string zapocnemo sa $" onda mozemo promenljiva da stavimo unutar {} u njemu i sve lepo radi :)
             * Evo kako izgleda u praksi: */
            Console.WriteLine($"Jedan uint zauzima {sizeof(uint)} bajta."); //Primetite koliko je ovo lakse
                                                                            //od proslih WriteLine poziva :)
            Console.WriteLine($"Minimalna vrednost mu je {uint.MinValue} a maksimalna {uint.MaxValue}.");
            Console.WriteLine();

            long velikiCeoBroj = 5;
            Console.WriteLine($"Jedan long zauzima {sizeof(long)} bajta."); 
            Console.WriteLine($"Minimalna vrednost mu je {long.MinValue} a maksimalna {long.MaxValue}.");
            Console.WriteLine();
            ulong velikiCeoBrojBezZnaka = 33;
            Console.WriteLine($"Jedan ulong zauzima {sizeof(ulong)} bajta.");
            Console.WriteLine($"Minimalna vrednost mu je {ulong.MinValue} a maksimalna {ulong.MaxValue}.");
            Console.WriteLine();

            //Brojevi sa ostatkom -- primetite da oni nemaju varijante koje su samo pozitivne
            float ostatak = (float)5.5; //Relativno neprecizan broj sa ostatkom, float se retko kada koristi
                                        //za c#, cim vidi nesto sa ostatkom, smatra da je to double, koji se
                                        //koristi vecinu vremena
            Console.WriteLine($"Jedan float zauzima {sizeof(float)} bajta.");
            Console.WriteLine($"Minimalna vrednost mu je {float.MinValue} a maksimalna {float.MaxValue}.");
            Console.WriteLine(); //primetite kod ispisa da se koristi naucna notacija, posto su brojevi veliki
                                 //3.402823E+38 mu dodje 3.402823 * 10 na 38 :)

            double ostatakPrecizan = 5.8; //Double koristimo za brojeve sa ostatkom uobicajeno
            Console.WriteLine($"Jedan double zauzima {sizeof(double)} bajta.");
            Console.WriteLine($"Minimalna vrednost mu je {double.MinValue} a maksimalna {double.MaxValue}.");
            Console.WriteLine();

            decimal ostatakUltraPrecizan = (decimal)3.5; //izrazito precizan broj sa ostatkom,
                                                         //vecinom ga koristimo za finansijske podatke
            Console.WriteLine($"Jedan decimal zauzima {sizeof(decimal)} bajta.");
            Console.WriteLine($"Minimalna vrednost mu je {decimal.MinValue} a maksimalna {decimal.MaxValue}.");
            Console.WriteLine();

            char karakter = 'a'; //Tip promenljive koji pamti jedan i samo jedan karakter, pricacemo o ovome jos :) 
            string nizKaraktera = "Ja pamtim gomilu slova :) ";

            bool logika = false; //Boolean moze imati samo dve vrednost, true ili false.
                                 //Spada u domen logicke matematike, cesto cemo da ga koristimo

            int nekiBroj = 5;
            nekiBroj = nekiBroj + 3;
            nekiBroj += 3;
            nekiBroj *= 2; //isto kao
                           //nekiBroj = nekiBroj * 2
            nekiBroj++; //nekiBroj = nekiBroj + 1
                        //postfix se izvrsava apsolutno zadnji
            --nekiBroj; //nekiBroj = nekiBroj - 1
                        //prefix se izvrsava apsolutno prvi
            nekiBroj = 5;
            Console.WriteLine(nekiBroj++); //u trenutku stampanja
                                           //jos uvek 5, jer se postfix
                                           //radi tek kada se zavrsi sve ostalo
            Console.WriteLine(++nekiBroj); //U ovoj liniji koda brojac nam je 6,
                                           //prefix ++ ide prvi, pa prvo dodaje, imamo 7,
                                           //i tek onda stampa :)


            //Niz je skup vrednosti. U jednoj promenljivoj
            //mozemo da imamo koliko zelimo (tj. koliko ima RAM-a :D) vrednosti
            
            //Kada vec znamo sta ce biti u nizu mozemo da ga napisemo ovako:
            int[] nizCelihBrojeva = { 1, 6, 7, 20, 409 };

            //Bitna stvar je da su nam nizovi adresirani od 0,
            //znaci prvi element je na indeksu 0, ne 1 :)
            Console.WriteLine(nizCelihBrojeva[0]);

            Console.WriteLine("Unesite velicinu: ");
            int elemenata = int.Parse(Console.ReadLine());
            
            
            int[] drugiNiz = new int[elemenata];

            for (int i = 1; i <= elemenata; i++)
            {
                drugiNiz[i - 1] = i * 2;
            }

            Console.WriteLine($"Niz je dugacak: {drugiNiz.Length}");
            
            foreach (int broj in drugiNiz)
            {
                Console.WriteLine(broj);
            }

            Console.ReadKey(); //ReadKey nam inace sluzi da poslusamo sta ce korisnik da pritisne, no u ovom slucaju
                               //ga koristimo da bi zadrzali aplikaciju da se ne zatvori pre no sto vidimo sta je
                               //to ispisala :) 
        } //Dovde je nase :) 
    }
}
