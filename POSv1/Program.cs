using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSv1
{
	class Program
	{
		static void Main(string[] args)
		{
			List<(string sifra,
				string naziv,
				int kolicina,
				decimal cena)> Artikli = new List<(string sifra, string naziv, int kolicina, decimal cena)>();

			char unos;

			do
			{
				StampajMeni();
				unos = Console.ReadKey().KeyChar;
				Console.WriteLine();

				switch (unos)
				{
					case '1':
						UnosArtikla(Artikli);
						break;
					case '2':
						foreach (var art in Artikli)
						{
							Console.WriteLine(art);
						}
						break;
					case '3':
						IzdajRacun(Artikli);
						break;
					case '4':
						break;
					default:
						Console.WriteLine("Greska u unosu!");
						break;
				}

			} while (unos != '4');
			Console.WriteLine("Konec");
			Console.ReadKey();
		}

		static void IzdajRacun(List<(string sifra,
									string naziv,
									int kolicina,
									decimal cena)> ListaArtikala)
		{

		}

		static bool NadjiArtikal(List<(string sifra,
									string naziv,
									int kolicina,
									decimal cena)> ListaArtikala, string sfr,
								out int IndeksArtikla)
		{
			for (int indeks = 0; indeks < ListaArtikala.Count; indeks++)
			{
				var artikal = ListaArtikala[indeks];
				if (sfr == artikal.sifra)
				{
					IndeksArtikla = indeks;
					return true;
				}
			}
			IndeksArtikla = -1;
			return false;
		}

		static void UnosArtikla(List<(string sifra, //0
									string naziv,   //1
									int kolicina,   //2
									decimal cena    /*3*/   )> ListaArtikala)
		{
			Console.Write("Unesi sifra;artikal;kolicina;cena:  ");

			string[] podaci = Console.ReadLine().Split(';');


			if (podaci.Length == 4 &&
				int.TryParse(podaci[2], out int kol) &&
				decimal.TryParse(podaci[3], out decimal cena))
			{
				/*
				 * 	bool nijeNadjen = true;
				foreach (var artikal in ListaArtikala)
				{
					if (podaci[0] == artikal.sifra)
					{
						nijeNadjen = false;
						break;
					}
				}*/


				if (!NadjiArtikal(ListaArtikala, podaci[0], out _))
				{
					ListaArtikala.Add((podaci[0], podaci[1], kol, cena));
				}
				else
				{
					Console.WriteLine("Sifra vec postoji!");
				}
			}
			else
			{
				Console.WriteLine("Greska u unosu!");
			}
		}

		static void StampajMeni()
		{
			Console.Write("1 -- Unos artikla\n" +
						  "2 -- Ispis artikala\n" +
						  "3 -- Racun\n" +
						  "4 -- Izlaz\n" +
						  "---------------\n" +
						  "Izaberite opciju: ");
		}
	}
}
