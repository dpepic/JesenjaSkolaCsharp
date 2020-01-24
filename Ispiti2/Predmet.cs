using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispiti2
{
	public class Predmet
	{
		public string Naziv { get; set; }
		public int MaxBodova { get; set; }
		public string Predavac { get; set; }
		public int BrojCasova { get; set; }

		public Predmet() { }
		public Predmet(string n, int mb, string p, int bc)
		{
			Naziv = n;
			MaxBodova = mb;
			Predavac = p;
			BrojCasova = bc;
		}

		public override string ToString()
		{
			return $"{Naziv}, {Predavac}";
		}
	}
}
