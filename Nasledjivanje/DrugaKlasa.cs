using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje
{
	class DrugaKlasa : Proba
	{
		public DrugaKlasa()
		{
			this.izDrugeKlase = this.broj * 2;
		}
		public int izDrugeKlase;
	}
}
