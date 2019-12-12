using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Artikal art = new Artikal();

		public MainWindow()
		{
			InitializeComponent();
			art.Stanje = 32;
			DataContext = art;
		}

		private void Oduzmi_Click(object sender, RoutedEventArgs e)
		{
			art.Stanje--;
		}

		private void Nuliraj_Click(object sender, RoutedEventArgs e)
		{
		    art.Stanje = 0;
		}

		private void Dodaj_Click(object sender, RoutedEventArgs e)
		{
			art.Stanje++;
		}
	}

	public class Artikal : INotifyPropertyChanged
	{
		private string naziv = "Plazam";
		public string Naziv 
		{ 
			get
			{
				return naziv;
			}
			set
			{
				naziv = value;
				PropertyChanged?.Invoke(this,
								new PropertyChangedEventArgs("Naziv"));
			}
		}


		public decimal cena;

		public decimal VrednostLager
		{ //read only property
			get
			{
				return cena * Stanje;
			}
		}

		public decimal dajLager()
		{
			return cena * Stanje;
		}
		
		private int stanje;

		public event PropertyChangedEventHandler PropertyChanged;

		public int Stanje //property
		{
			get
			{
				return stanje;
			}

			set
			{
				if (value < 0)
				{
					stanje = 0;
				}
				else
				{
					stanje = value;
				}

				PropertyChanged?.Invoke(this,
						new PropertyChangedEventArgs("Stanje"));
				
				/*Ovo iznad je isto kao i ovo:
				if (PropertyChanged != null)
				{
					PropertyChanged.Invoke(this,
						new PropertyChangedEventArgs("Stanje"));
				}*/
			}
		}



		//Metoda za citanje stanja
		//getter
		public int procitajStanje()
		{
			return stanje;
		}
		//Metodu za podesavanje
		//setter
		public void unesiStanje(int st)
		{
			
			if (st < 0)
			{
				stanje = 0;
			} else
			{
				stanje = st;
			}

		}

	}
}
