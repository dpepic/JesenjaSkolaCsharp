using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Ispiti2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		DB baza = new DB();

		private string pretraga;

		public event PropertyChangedEventHandler PropertyChanged;

		public string Pretraga
		{
			get => pretraga;
			set
			{
				pretraga = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pretraga"));
				baza = new DB();
				if (string.IsNullOrEmpty(pretraga) || string.IsNullOrWhiteSpace(pretraga))
					dgPredmeti.ItemsSource = baza.dbPredmeti.ToList();
				else
				{
					//ObservableCollection<Predmet> pre = new ObservableCollection<Predmet>();
					//baza.dbPredmeti.ToList();
					//foreach (Predmet p in baza.dbPredmeti.Local)
					//{
					//	if (p.Naziv.ToLower().Contains(pretraga.ToLower()) ||
					//		p.Predavac.ToLower().Contains(pretraga.ToLower()))
					//		pre.Add(p);
					//}

					dgPredmeti.ItemsSource = baza.dbPredmeti.Where(p =>
						   p.Naziv.ToLower().Contains(pretraga.ToLower()) ||
						   p.Predavac.ToLower().Contains(pretraga.ToLower())).ToList();
				}
			}
		}

		public MainWindow()
		{
			InitializeComponent();
			//baza.dbPredmeti.Add(new Predmet("Probni predmet", 230, "Neko Nekic", 42));
			//baza.dbPredmeti.Add(new Predmet("Tamo neki", 100, "Pera Peric", 10));
			//baza.dbPredmeti.Add(new Predmet("Treci predmet", 300, "Trecko Treckovic", 33));
			//baza.dbPredmeti.Add(new Predmet("Anominan", 180, "NN", 9));
			//baza.SaveChanges();
			DataContext = this;
			dgPredmeti.ItemsSource = baza.dbPredmeti.ToList();
		}

		private void dodavanje_Click(object sender, RoutedEventArgs e)
		{
			PredmetEd pe = new PredmetEd();
			pe.Owner = this;
			if (pe.ShowDialog() == true)
			{
				baza.dbPredmeti.Add(pe.DataContext as Predmet);
				baza.SaveChanges();
				Pretraga = null;
			}
		}

		private void izmena_Click(object sender, RoutedEventArgs e)
		{
			if (dgPredmeti.SelectedItem != null)
			{
				PredmetEd pe = new PredmetEd();
				pe.Owner = this;
				pe.DataContext = dgPredmeti.SelectedItem;
				if (pe.ShowDialog() == true)
					baza.SaveChanges();
			}
		}

		private void brisanje_Click(object sender, RoutedEventArgs e)
		{
			if (dgPredmeti.SelectedItem != null)
			{
				baza.dbPredmeti.Remove(dgPredmeti.SelectedItem as Predmet);
				baza.SaveChanges();
				Pretraga = null;
			}
		}
	}
}
