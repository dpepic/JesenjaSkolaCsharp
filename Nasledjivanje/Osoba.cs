using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje
{
	class Osoba
	{
		public string JMBG = "1233";
		public string Ime;
		public string Prezime;

		public Osoba(string i, string p)
		{
			Ime = i;
			Prezime = p;
		}

		public override string ToString()
		{
			return $"Ja sam {Ime} {Prezime}, JMBG mi je {JMBG}";
		}

	}
}
