using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POSv2
{
	class Program
	{
		static void Main(string[] args)
		{
			int brojac;
			if (File.Exists("brojac.txt"))
			{
				int.TryParse(File.ReadAllText("brojac.txt"), out brojac);
			}
			else
			{
				brojac = 0;
			}

			List<(int sifra,
				  string naziv,
				  int kol,
				  decimal cena)> Artikli = new List<(int, string, int, decimal)>();

			if (File.Exists("art.txt"))
			{
				foreach (string red in File.ReadLines("art.txt"))
				{
					string[] polja = red.Split(';');
					if (polja.Length == 4)
					{
						Artikli.Add((int.Parse(polja[0]),
									polja[1],
									int.Parse(polja[2]),
									decimal.Parse(polja[3])));
					}
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
						UnosArtikla(Artikli, ref brojac);
						break;
					case '2':
						foreach (var Artikal in Artikli)
						{
							Console.WriteLine(Artikal);
						}
						break;
					case '3':
						IzdavanjeRacuna(Artikli);
						break;
					case '4':
						break;
					default:
						Console.WriteLine("Greska u unosu!");
						Console.ReadKey();
						break;
				}
			} while (unos != '4');
			Console.WriteLine("Konec");
			File.WriteAllText("brojac.txt", $"{brojac}");
			if (File.Exists("art.txt"))
			{
				File.Delete("art.txt");
			}

			foreach (var art in Artikli)
			{
				File.AppendAllText("art.txt", $"{art.sifra};{art.naziv};{art.kol};{art.cena}"
												+ Environment.NewLine);
			}
		}

		static bool PretraziArtikal(List<(int sifra,
									  string naziv,
									  int kolicna,
									  decimal cena)> art, int sifra,
									  out int indeks)
		{
			for (int i = 0; i < art.Count; i++)
			{
				if (art[i].sifra == sifra)
				{
					indeks = i;
					return true;
				}
			}
			indeks = -1;
			return false;
		}

		static void IzdavanjeRacuna(List<(int sifra,
									  string naziv,
									  int kolicna,
									  decimal cena)> art)
		{
			List<(string naziv, int kol, decimal cena)> Racun = new List<(string naziv, int kol, decimal cena)>();
			char unos;
			do
			{
				Console.WriteLine("Dodajte artikal na racun(d/n)?");
				unos = Console.ReadKey().KeyChar;
				Console.WriteLine();
				if (unos == 'd')
				{
					Console.WriteLine("Unesite sifru: ");
					if (int.TryParse(Console.ReadLine(), out int sifra))
					{
						if (PretraziArtikal(art, sifra, out int indeks))
						{
							Console.WriteLine($"Unesite kolicinu(na stanju:{art[indeks].kolicna}): ");
							if (int.TryParse(Console.ReadLine(), out int kol))
							{
								if (kol <= art[indeks].kolicna)
								{
									var artikal = art[indeks];
									art.RemoveAt(indeks);
									artikal.kolicna -= kol;
									art.Insert(indeks, artikal);

									int stavka = -1;
									for (int i = 0; i < Racun.Count; i++)
									{
										if (Racun[i].naziv == artikal.naziv)
										{
											stavka = i;
											break;
										}
									}

									if (stavka == -1)
									{
										Racun.Add((artikal.naziv, kol, artikal.cena * kol));
									}
									else
									{
										var st = Racun[stavka];
										Racun.RemoveAt(stavka);
										st.kol += kol;
										st.cena = st.kol * artikal.cena;
										Racun.Insert(stavka, st);
									}
								}
								else
								{
									Console.WriteLine("Nema kolicine na lageru!");
								}
							}

						}
						else
						{
							Console.WriteLine("Nema te sifre!");
						}
					}
					else
					{
						Console.WriteLine("Greska u unosu!");
					}

				}
				else if (unos != 'n')
				{
					Console.WriteLine("Greska u unosu!");
				}

			} while (unos != 'n');

			decimal total = 0;
			foreach (var stavka in Racun)
			{
				Console.WriteLine($"{stavka.naziv} -- {stavka.kol} -- {stavka.cena}");
				total += stavka.cena;
			}
			Console.WriteLine("===================");
			Console.WriteLine($"Total je: {total}");
		}

		static void UnosArtikla(List<(int sifra,
									  string naziv, //0
									  int kolicna,  //1
									  decimal cena  /*2*/  )> Artikli,
								ref int brArtikla)
		{
			while (true)
			{
				Console.Write("Unesite naziv;kolicinu;cenu: ");

				string[] unos = Console.ReadLine().Split(';');

				if (unos.Length == 3 &&
					int.TryParse(unos[1], out int kol) &&
					decimal.TryParse(unos[2], out decimal cena))
				{
					Artikli.Add((brArtikla, unos[0], kol, cena));
					brArtikla++;
					break;
				}
				else
				{
					Console.WriteLine("Greska u unosu!");
				}
			}
		}

		static void StampajMeni()
		{
			Console.Write("1 -- Unos artikla\n" +
						  "2 -- Ispis artikala\n" +
						  "3 -- Racun\n" +
						  "4 -- Izlaz\n" +
						  "-----------------\n" +
						  "Vas izbor: ");
		}
	}
}
