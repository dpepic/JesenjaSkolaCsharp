using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.PoslovniObjekti
{
	public class Artikal
	{
		public long sifra;
		public string naziv;
		public int kolicina;
		public decimal cena;
		public static long brojac;

		public void StampajSe()
		{
			Console.WriteLine($"Sifra: {sifra} Naziv: {naziv} Kolicina: {kolicina} Cena: {cena}");
		}

		public bool SkiniSaStanja(int kol)
		{
			if (this.kolicina >= kol)
			{
				this.kolicina -= kol;
				return true;
			}
			else
			{
				return false;
			}
		}

		public Artikal(long s,
					   string n,
					   int k)
		{
			sifra = s;
			naziv = n;
			kolicina = k;
		}

		public Artikal(long s,
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