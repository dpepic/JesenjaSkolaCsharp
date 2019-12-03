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

		public event PropertyChangedEventHandler PropertyChanged;

		public void uvecajBroj(int br)
		{
			X = X * 10 + br;
		}
	}
}
