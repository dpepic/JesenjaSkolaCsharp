using POS.PoslovniObjekti;
using System;
using System.Collections.Generic;
using System.IO;

namespace POS.GlavniProgram
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			List<Artikal> Artikli = new List<Artikal>();

			do
			{
				Console.WriteLine("Unesite sifra;naziv;kolicina;cena");
				string[] unos = Console.ReadLine().Split(';');

				Artikli.Add(new Artikal(int.Parse(unos[0]),
										unos[1],
										int.Parse(unos[2]),
										decimal.Parse(unos[3])));
			} while (true);
		}
	}
}