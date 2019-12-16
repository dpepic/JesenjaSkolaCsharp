using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje
{
	class ZaposlenoLice : Osoba
	{
		public decimal Plata;
		public string RadnoMesto;

		public ZaposlenoLice(string i, string p, decimal plata)
			:base(i, p)
		{
			this.Plata = plata;
		}

		public override string ToString()
		{
			return base.ToString() + 
				$" i plata mi je {Plata}";
		}
	}
}
