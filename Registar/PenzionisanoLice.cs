using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar
{
	class PenzionisanoLice : Osoba
	{
		public decimal Penzija { get; set; }

		public PenzionisanoLice(string i,
			string p,
			string j,
			decimal pp) : base (i, p, j)
		{
			Penzija = pp;
		}

		public new string JaviSe()
		{
			return "ja sam penzionisan!";
		}

	}
}
