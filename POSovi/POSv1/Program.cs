using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

			if (File.Exists("art.txt"))
			{	
				foreach(string art in File.ReadLines("art.txt"))
				{
					string[] polja = art.Split(';');
					Artikli.Add((polja[0], polja[1],
						int.Parse(polja[2]), decimal.Parse(polja[3])));
				}
			}
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

			try
			{
				File.Delete("art.txt");
			}
			catch { }

			foreach(var artikal in Artikli)
			{
				File.AppendAllText("art.txt", $"{artikal.sifra};{artikal.naziv};{artikal.kolicina};{artikal.cena}" +
									Environment.NewLine);
			}
			

			Console.WriteLine("Konec");
			Console.ReadKey();
		}

		static void IzdajRacun(List<(string sifra,
									string naziv,
									int kolicina,
									decimal cena)> ListaArtikala)
		{
			ConsoleKeyInfo unos;
			List<(string Naziv, int Kolicina, decimal Cenu)> Racun =
				new List<(string, int, decimal)>();
			do
			{
				Console.Write("Unos artikla(d/n): ");
				unos = Console.ReadKey();
				Console.WriteLine();

				if (unos.KeyChar == 'd')
				{
					Console.Write("Unesite sifru: ");
					if (NadjiArtikal(ListaArtikala,
						Console.ReadLine(), out int indeks))
					{
						Console.Write($"Unesite kolicinu(na stanju {ListaArtikala[indeks].kolicina}): ");
						int kol = int.Parse(Console.ReadLine());
						if (kol <= ListaArtikala[indeks].kolicina)
						{
							var artikal = ListaArtikala[indeks];
							ListaArtikala.RemoveAt(indeks);
							artikal.kolicina -= kol;
							ListaArtikala.Insert(indeks, artikal);

							int ind = -1;
							for (int i = 0; i < Racun.Count; i++)
							{
								if (Racun[i].Naziv == artikal.naziv)
								{
									ind = i;
									break;
								}
							}

							if (ind != -1)
							{
								var stavka = Racun[ind];
								Racun.RemoveAt(ind);

								stavka.Kolicina += kol;
								stavka.Cenu = stavka.Kolicina * artikal.cena;

								Racun.Insert(ind, stavka);
							} else
							{
								Racun.Add((artikal.naziv, kol,
									   artikal.cena * kol));
							}

							
						}else
						{
							Console.WriteLine("Nema na lageru!");
						}
					} else
					{
						Console.WriteLine("Losa sifra!");
					}

				} else if (unos.KeyChar != 'n')
				{
					Console.WriteLine("Greska u unosu!");
				}
			} while (unos.KeyChar != 'n');

			decimal total = 0;
			foreach(var stavka in Racun)
			{
				total += stavka.Cenu;
				Console.WriteLine($"{stavka.Naziv} --- {stavka.Kolicina} -- {stavka.Cenu}");
			}
			Console.WriteLine("======================");
			Console.WriteLine($"Total je: {total}");
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
