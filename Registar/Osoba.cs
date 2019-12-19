using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar
{
	class Osoba
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string JMBG { get; set; }

		public Osoba(string i, string p, string j)
		{
			Ime = i;
			Prezime = p;
			JMBG = j;
		}

		public virtual string JaviSe()
		{
			return "Osoba sam!";
		}

		public override string ToString()
		{
			return $"{Ime} {Prezime}";
		}

		public override bool Equals(object obj)
		{
			if (obj is Osoba o && o.Ime == this.Ime &&
				o.Prezime == this.Prezime &&
				o.JMBG == this.JMBG)
			{
				return true;
			} else
			{
				return false;
			}
		}
	}
}
