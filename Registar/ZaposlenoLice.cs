using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar
{
	class ZaposlenoLice : Osoba
	{
		public string Poziciju { get; set; }
		public decimal Plata { get; set; }

		public ZaposlenoLice(string i,
			string p,
			string j,
			string poz,
			decimal pl) :base(i, p, j)
		{
			Poziciju = poz;
			Plata = pl;
		}

		public override string JaviSe()
		{
			return "Ja sam zaposleno lice!";
		}
	}
}
