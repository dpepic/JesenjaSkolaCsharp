using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutliWindowEdit
{
	public class Artikal
	{
		public string Naziv { get; set; }
		public decimal Cena { get; set; }
		
		public Artikal(string n, decimal c)
		{
			Naziv = n;
			Cena = c;
		}
	}
}
