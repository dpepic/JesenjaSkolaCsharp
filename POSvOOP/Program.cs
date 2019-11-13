using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSvOOP
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Artikal art = new Artikal(4, "test", 15);
			do
			{
				Console.WriteLine($"Trenutna kolicina: {art.kolicina}");
				Console.Write("Unesite kolicinu: ");
				int kol = int.Parse(Console.ReadLine());

				if (art.SkiniSaStanja(kol))
				{
					Console.WriteLine($"Trenutna kolicina: {art.kolicina}");
				}
				else
				{
					Console.WriteLine("Neuspelo :(");
					Console.WriteLine($"Trenutna kolicina: {art.kolicina}");
				}

			} while (true);
		}
	}

	public class Artikal
	{
		public int sifra;
		public string naziv;
		public int kolicina;
		public decimal cena;

		public bool SkiniSaStanja(int kol)
		{
			if (this.kolicina >= kol)
			{
				this.kolicina -= kol;
				return true;
			} else
			{
				return false;
			}
		}

		public Artikal(int s, 
					   string n,
					   int k)
		{
			
			sifra = s;
			naziv = n;
			kolicina = k;
		}

		public Artikal(int s,
						string n,
						int k,
						decimal c)
		{
			sifra = s;
			naziv = n;
			kolicina = k;
			cena = c;
		}

	}
}
