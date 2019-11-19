using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSV2OOP.BO;

namespace POSV2OOP
{
	class Program
	{
		static List<Artikal> Artikli = new List<Artikal>();

		static void Main(string[] args)
		{
			Console.ReadKey();
			ConsoleKeyInfo unos;
			do
			{
				StampajMeni();
				unos = Console.ReadKey();
				Console.WriteLine();

				switch (unos.KeyChar)
				{
					case '1':
						UnosArtikla();
						break;
					case '2':
						foreach (Artikal a in Artikli)
						{
							a.StampajSe();
						}
						break;
				}
			} while (unos.KeyChar != '5');
		}

		static void UnosArtikla()
		{
			Console.Write("Unesite sifru;naziv;kolicna;cena: ");
			string[] unos = Console.ReadLine().Split(';');
			foreach(Artikal art in Artikli)
			{
				if (unos[0] == art.sifra)
				{
					Console.WriteLine("Sifra vec postoji!");
					return;
				}
			}

			Artikli.Add(new Artikal(unos[0], unos[1], int.Parse(unos[2]),
									 decimal.Parse(unos[3])));

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
