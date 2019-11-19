using System;
using System.Collections.Generic;
using System.Text;

namespace POSV2OOP.BO
{
	public class Racun
	{
		public static int brojac;
		public int brojRacun;
		public DateTime datumIzdavanja;
		public Dictionary<Artikal, int> Artikli = new Dictionary<Artikal, int>();
		public decimal total;

		public void SaberiStanje()
		{
			foreach (Artikal art in Artikli.Keys)
			{
				total += art.cena * Artikli[art];
			}
		}
		
	}
}
