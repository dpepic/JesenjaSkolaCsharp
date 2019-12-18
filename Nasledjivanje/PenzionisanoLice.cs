using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje
{
	class PenzionisanoLice : Osoba
	{
		decimal Penzija;

		public PenzionisanoLice(decimal p,
			string i, string prez) : 
			base(i, prez)
		{
			Penzija = p;
		}
		public override string ToString()
		{
			return $"Ja sam penzionisan i ne pitaj me nista";
		}
	}
}
