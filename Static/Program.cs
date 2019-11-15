using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
	class Zklj
	{
		static void Main(string[] args)
		{
			Osoba.FooBar();
		}
	}

	class Osoba
	{
		public int brojac = 0;
		public string naziv = "nesto"; 
		public static int brojac2 = 0;

		public static void FooBar()
		{
			Console.WriteLine("Ovo je staticna metoda :)");
		}
	}
}
