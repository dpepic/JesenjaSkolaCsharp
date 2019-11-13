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
			List<Artikal> Artikli = new List<Artikal>();

			do
			{
				Console.WriteLine("Unesite sifra;naziv;kolicina;cena");
				string[] unos = Console.ReadLine().Split(';');
				double d = 4.1234567899999999;

				Artikli.Add(new Artikal(int.Parse(unos[0]),
										unos[1],
										int.Parse(unos[2]),
										decimal.Parse(unos[3])));

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
