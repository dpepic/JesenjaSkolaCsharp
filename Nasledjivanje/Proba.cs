using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje
{
	class Proba
	{
		public int broj;
		private string naziv;

		public Proba()
		{
			this.broj = 88;
		}

		public int FooBar(int x)
		{
			return ++x;
		}
	}
}
