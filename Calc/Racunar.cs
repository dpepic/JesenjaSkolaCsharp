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

		public decimal Y { set; get; }

		public char Op { set; get; }

		public event PropertyChangedEventHandler PropertyChanged;

		public void UnesiOperaciju(char o)
		{
			if (Op == '\0')
			{
				Y = X;
				X = 0;
				Op = o;
			} else
			{
				switch(Op)
				{
					case '+':
						X += Y;
						break;
				}
				if (o != '=')
				{
					Y = X;
					X = 0;
					Op = o;
				} else
				{
					Op = '\0';
				}
			}
			
		}

		public void uvecajBroj(int br)
		{
			X = X * 10 + br;
		}

		public void Clear(bool error)
		{
			if (error)
			{					
				X = 0;
			} else
			{
				X = 0;
				Y = 0;
				Op = '\0';
			}
		}
	}
}
