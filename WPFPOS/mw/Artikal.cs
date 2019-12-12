using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mw
{
	class Artikal : INotifyPropertyChanged
	{
		private string naziv;
		public string Naziv
		{
			get => naziv;

			set
			{
				naziv = value;
				PropertyChanged?.Invoke(this,
					new PropertyChangedEventArgs("Naziv"));
			}
		}



		private decimal cena;
		public decimal Cena 
		{
			get => cena;

			set
			{
				cena = value;
				PropertyChanged?.Invoke(this,
					new PropertyChangedEventArgs("Cena"));
			}
		}
		private int lager = 10;
		public int Lager 
		{ 
			get => lager; 
			set
			{
				lager = value;
				PropertyChanged?.Invoke(this,
					new PropertyChangedEventArgs("Lager"));
			}
		} 

		public Artikal(string n, decimal c)
		{
			Naziv = n;
			Cena = c;
		}

		public Artikal(string n, int kol, decimal c)
		{
			Naziv = n;
			Cena = c;
			Lager = kol;
		}
		public Artikal() { }

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
