using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class Racunar : INotifyPropertyChanged
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

		private decimal y;
		public decimal Y
		{
			get => y;

			set
			{
				y = value;
				PropertyChanged?.Invoke(this,
					new PropertyChangedEventArgs("Y"));
			}
		}

		private char op;
		public char Op
		{
			get => op;

			set
			{
				if (op == '\0' && value != '=')
				{
					op = value;
				} else if (value == '=')
				{
					if (!Gde)
					{
						X += Y;
						Y = 0;
					} else
					{
						Y += X;
						X = 0;
					}
					op = '\0';
				} else
				{
					if (!Gde)
					{
						X += Y;
						Y = 0;
					}
					else
					{
						Y += X;
						X = 0;
					}
				}
				Gde = !Gde;
				ZadnjaOperacija = true;
				PropertyChanged?.Invoke(this,
					new PropertyChangedEventArgs("Op"));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private bool Gde = true;
		private bool ZadnjaOperacija;

		public void unosBroja(decimal br)
		{
			if (Gde)
			{
				if (ZadnjaOperacija)
				{
					Y = X;
					X = 0;
					ZadnjaOperacija = false;
				}
				X = X * 10 + br;
			}
			else
			{
				if (ZadnjaOperacija)
				{
					X = Y;
					Y = 0;
					ZadnjaOperacija = false;
				}
				Y = Y * 10 + br;
			}
		}

		public void Ocisti(bool sve)
		{
			if (sve)
			{
				X = 0;
				Y = 0;
				op = '\0';
			}else
			{
				if (op == '\0')
				{
					X = 0;
				} else
				{
					Y = 0;
				}
			}
		}
	}
}
