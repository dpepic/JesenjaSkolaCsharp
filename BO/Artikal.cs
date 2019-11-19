using System;

namespace POSV2OOP.BO
{
	public class Artikal
	{
		public string sifra;
		public string naziv;
		public int kolicina;
		public decimal cena;

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

		public Artikal(string s,
					   string n,
					   int k)
		{
			sifra = s;
			naziv = n;
			kolicina = k;
		}

		public Artikal(string s,
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

