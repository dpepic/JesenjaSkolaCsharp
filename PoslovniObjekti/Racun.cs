using System;
using System.Collections.Generic;
using System.Text;

namespace POS.PoslovniObjekti
{
	public class Racun
	{
		public DateTime datumIzdavanja;
		public Dictionary<Artikal, int> artikli =
			new Dictionary<Artikal, int>();
		public List<int> kol = new List<int>();
		public decimal total;

		public Racun(DateTime d, Dictionary<Artikal, int> a, decimal t)
		{
			this.datumIzdavanja = d;
			this.artikli = a;
			this.total = t;
		}

		public void SvediTotal()
		{
			foreach(Artikal a in artikli.Keys)
			{
				total += a.cena * artikli[a];
			}
		}
	}
}
