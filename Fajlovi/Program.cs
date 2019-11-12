using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp19
{
	class Program
	{
		static void Main(string[] args)
		{
			//File.WriteAllText("test.txt", "1-asdqwseqweasdasd");
			//File.WriteAllText("test.txt", "2-asdfasfd" + Environment.NewLine);
			//File.AppendAllText("test.txt", "3-asdasd");

			string[] niz = { "Prvi", "drugi", "treci" };
			File.WriteAllLines("test.txt", niz);
			File.AppendAllLines("test.txt", niz);

			//File.Copy("test.txt", "t1.txt");
			//File.Delete("t1.txt");

			if (File.Exists("test.txt"))
			{
				string nebitno = File.ReadAllText("test.txt");
				Console.WriteLine(nebitno);

				List<string> josJedanNizNije = new List<string>();
				josJedanNizNije.AddRange(File.ReadAllLines("test.txt"));

				foreach (string s in File.ReadLines("test.txt"))
				{

				}
			}

			Console.ReadKey();
		}
	}
}
