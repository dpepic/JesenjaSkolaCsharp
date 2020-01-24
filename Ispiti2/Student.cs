using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispiti2
{
	public class Student
	{
		public string BrIndeksa { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public int BrojBodova { get; set; } = 0;

		public Student() { }
		public Student(string i, string ime, string p)
		{
			BrIndeksa = i;
			Ime = ime;
			Prezime = p;
		}
		public override string ToString()
		{
			return $"{BrIndeksa}, {Ime}, {Prezime}";
		}
	}
}
