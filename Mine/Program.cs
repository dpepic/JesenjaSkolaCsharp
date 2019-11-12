using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
	class Mine
	{
		static void Main(string[] args)
		{
			int[,] polje = new int[10, 10];

			Random nasumicanBroj = new Random();

			for (int red = 0; red < polje.GetLength(0); red++)
			{
				for (int kol = 0; kol < polje.GetLength(1); kol++)
				{
					if (nasumicanBroj.Next(1, 10) <= 2)
					{
						polje[red, kol] = 9;
						for (int redMina = -1; redMina <= 1; redMina++)
						{
							for (int kolMina = -1; kolMina <= 1; kolMina++)
							{
								try
								{
									if (polje[red + redMina, kol + kolMina] != 9)
									{
										polje[red + redMina, kol + kolMina]++;
									}
								}
								catch { }
							}
						}
					}
				}
			}

			for (int red = 0; red < polje.GetLength(0); red++)
			{
				for (int kol = 0; kol < polje.GetLength(1); kol++)
				{
					if (polje[red, kol] == 9)
					{
						Console.Write(" * ");
					}
					else
					{
						Console.Write($" {polje[red, kol]} ");
					}
				}
				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}
