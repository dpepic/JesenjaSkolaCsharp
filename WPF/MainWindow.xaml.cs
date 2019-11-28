using System;
using System.Collections.Generic;
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
		int broj;

		public MainWindow()
		{
			InitializeComponent();
			
		}

		private void Oduzmi_Click(object sender, RoutedEventArgs e)
		{    
			lbNesto.Content = --broj;
		}

		private void Nuliraj_Click(object sender, RoutedEventArgs e)
		{
			broj = 0;
			lbNesto.Content = broj;
		}

		private void Dodaj_Click(object sender, RoutedEventArgs e)
		{
			lbNesto.Content = ++broj;
			Artikal a = new Artikal();
			a.unesiStanje(-15);
			a.Stanje = -15;
			lbNesto.Content = a.VrednostLager;

		}
	}

	public class Artikal
	{
		public string Naziv { get; private set; }


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
