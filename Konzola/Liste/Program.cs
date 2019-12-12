using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] niz = { 3, 4, 5, 6, 15 };

			int[] niz2 = new int[0];
			List<int> lista = new List<int>();

			lista.Add(5);
			lista.AddRange(niz);
			lista.Insert(2, 10);
			lista.InsertRange(1, niz);

			lista.Remove(10);
			lista.RemoveAt(0);
			lista.Clear();

			lista.Contains(20);
			int x = 5;

			bool nasao = false;
			for (int indeks = 0; indeks < lista.Count; indeks++)
			{
				if (lista[indeks] == x)
				{
					nasao = true;
					break;
				}
			}

			if (nasao)
			{
				Console.WriteLine("Nadjen!");
			}
			else
			{
				Console.WriteLine("Nije :(");
			}
		}
	}
}
