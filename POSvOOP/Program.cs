using POS.PoslovniObjekti;
using System;
using System.Collections.Generic;
using System.IO;

namespace POS.GlavniProgram
{
	internal class Program
	{
		static List<Artikal> Artikli = new List<Artikal>();

		private static void Main(string[] args)
		{


			ConsoleKeyInfo unos;
			do
			{
				StampajMeni();
				unos = Console.ReadKey();
				Console.WriteLine();

				switch(unos.KeyChar)
				{
					case '1':
						unosArtikla();
						break;
					case '2':
						foreach(Artikal a in Artikli)
						{
							a.StampajSe();
						}
						break;
				}
			} while (unos.KeyChar != '5');
		}

		static void unosArtikla()
		{
			Console.WriteLine("Unesite naziv;kolicina;cena");
			string[] art = Console.ReadLine().Split(';');

			Artikli.Add(new Artikal(++Artikal.brojac,
									art[0],
									int.Parse(art[1]),
									decimal.Parse(art[2])));
		}

		
		static void StampajMeni()
		{
			Console.Write("1 -- Unos artikla\n" +
						  "2 -- Ispis artikala\n" +
						  "3 -- Racun\n" +
						  "4 -- Ispis racuna\n" +
						  "5 -- Izlaz\n" +
						  "---------------\n" +
						  "Izaberite opciju: ");
		}

	}
}