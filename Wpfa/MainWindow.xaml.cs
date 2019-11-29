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
using System.Diagnostics;
using System.ComponentModel;

namespace WpfApp7
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
			art.Naziv = "Plazam";
			art.Kolicina = 5;
			art.Cena = 200;

			DataContext = art;
		}
	}
	
	public class Artikal : INotifyPropertyChanged
	{
		private string naziv;
		public string Naziv 
		{
			get => naziv; 
			set
			{
				naziv = value;
				Update("Naziv");
			}
		} 

		private int kolicina;

		public event PropertyChangedEventHandler PropertyChanged;
		
		private void Update(string sta)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(sta));
		}

		public int Kolicina
		{
			get
			{
				return kolicina;
			}

			set
			{
				if (value < 0)
				{
					kolicina = 0;
				}
				else
				{
					kolicina = value;
				}
				Update("Kolicina");
				Update("VrednostLagera");
			}
		}

		private decimal cena;
		public decimal Cena 
		{
			get => cena;

			set
			{
				cena = value;
				Update("Cena");
				Update("VrednostLagera");
			}
		}

		public decimal VrednostLagera
		{
			get => Kolicina * Cena;
			
		}
	}
}
