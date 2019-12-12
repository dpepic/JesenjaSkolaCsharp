using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode
{
	class Program
	{
		static void Main(string[] args)
		{
			FooBar(); //pozivamo metodu

			int rez = Foo(5); //ako metoda zahteva ulazni parametar
							  //to moramo da ispostujemo
			int x = 5;

			Val(x); //saljemo po vrednosti, metoda dobija kopiju
			        //original se ne menja
			Ref(ref x); //saljemo referencu. Metoda ne dobija vrednost
			            //vrednost nego lokaciju ovog naseg x. Samim tim,
						//svaka izmena u metodi jeste izmena originala.
						//Nizovi i sve iznad nizova uvek idu po referenci,
						//tuplovi i standarde promenljive se salju po vrednosti
						//ako ne koristimo ref kao ovde

			//ne intresuje nas ostatak
			if (DeljivoSa5(35, out _))
			{
				Console.WriteLine("Jeste deljivo :) ");
			}

			//intresuje nas ostatak :) 
			if (!DeljivoSa5(44, out int ost))
			{
				Console.WriteLine($"Nije deljivo, ostatk {ost}");
			}
		}

		//out parametri su zgodan nacin da
		//posaljemo opcione podatke
		//U ovom primeru, metoda nam daje
		//true ili false primarno,
		//opciono salje i ostatak putem out-a
		static bool DeljivoSa5(int x, out int ostatak)
		{
			ostatak = x % 5;
			if (ostatak == 0)
			{
				return true;
			} else
			{
				return false;
			}
		}
		static void Val(int a)
		{
			a++; //primetite da i visual studio sam 
                 //kaze da ovo bas nema poente :)
		}
		static void Ref(ref int a)
		{
			a++;
		}
		//static je vezan											//ulazni 
		//za objektno, ignorisemo :)  //povratni tip    //naziv    //parameti
		static							 void			FooBar        ()
		{
			Console.WriteLine("Iz metode :)");
		}

		//Metoda koja prihavat jedan int kao parametar (x)
		//a takodje vraca int
		static int Foo(int x)
		{
			if (x > 5)
			{
				return x * 2;
			} else
			{
				return x * 5; //kada kazemo da vracamo nesto
				       //moramo da se osiguramo da cemo signurno
					   //vratiti neku vrednost 
			}
		}
	}
}
