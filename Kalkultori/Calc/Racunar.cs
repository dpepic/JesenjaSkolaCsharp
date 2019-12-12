using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	class Racunar : INotifyPropertyChanged
	{
		private decimal x;
		public decimal X
		{
			get => x;
			set
			{
				x = value;
				PropertyChanged?.Invoke(this,
					new PropertyChangedEventArgs("X"));
			}
		}

		public void UnesiBroj(int br)
		{
			if (BilaOperacija)
			{
				X = 0;
				BilaOperacija = false;
			}
			X = X * 10 + br;
		}

		private decimal Y { set; get; }

		private decimal mem;
		private decimal Mem
		{
			get => mem;
			set
			{
				if (value == 0)
				{
					mem = 0;
				}
				else
				{
					mem += value;
				}
			}
		}

		public void MemorijaOp(char o)
		{
			BilaOperacija = true;
			switch (o)
			{
				case 'C':
					Mem = 0;
					break;
				case 'R':
					if (Mem != 0)
					{
						X = Mem;
					}
					break;
				case '+':
					Mem = X;
					break;
				case '-':
					Mem = -X;
					break;
			}
		}

		private char op;
		public char Op
		{
			set
			{
				if (op == '\0')
				{
					Y = X;
					X = 0;
					op = value;
				}
				else
				{
					switch (op)
					{
						case '+':
							X += Y;
							break;
					}
					if (value != '=')
					{
						Y = X;
						BilaOperacija = true;
						op = value;
					}
					else
					{
						op = '\0';
					}
				}
			}
			get => op;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private bool BilaOperacija;

		public void Clear(bool error)
		{
			if (error)
			{
				X = 0;
			}
			else
			{
				X = 0;
				Y = 0;
				Op = '\0';
			}
		}
	}
}
