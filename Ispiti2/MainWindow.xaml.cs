using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
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
					switch (aktivniGrid.Name)
					{
						case "dgStudenti":
							aktivniGrid.ItemsSource = baza.dbStudenti.ToList();
							break;
						case "dgPredmeti":
							aktivniGrid.ItemsSource = baza.dbPredmeti.ToList();
							break;
					}
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
					switch (aktivniGrid.Name)
					{
						case "dgStudenti":
							aktivniGrid.ItemsSource = baza.dbStudenti.Where(s =>
								s.Ime.ToLower().Contains(pretraga.ToLower()) ||
								s.Prezime.ToLower().Contains(pretraga.ToLower())).ToList();
							break;
						case "dgPredmeti":
							aktivniGrid.ItemsSource = baza.dbPredmeti.Where(p =>
								p.Naziv.ToLower().Contains(pretraga.ToLower()) ||
								p.Predavac.ToLower().Contains(pretraga.ToLower())).ToList();
							break;
					}
					
				}
			}
		}

		public DataGrid aktivniGrid;
		public RoutedUICommand Brisanje;

		public MainWindow()
		{
			InitializeComponent();
			//baza.dbPredmeti.Add(new Predmet("Probni predmet", 230, "Neko Nekic", 42));
			//baza.dbPredmeti.Add(new Predmet("Tamo neki", 100, "Pera Peric", 10));
			//baza.dbPredmeti.Add(new Predmet("Treci predmet", 300, "Trecko Treckovic", 33));
			//baza.dbPredmeti.Add(new Predmet("Anominan", 180, "NN", 9));
			//baza.SaveChanges();

			//baza.dbStudenti.Add(new Student("123", "Pera", "Peric"));
			//baza.dbStudenti.Add(new Student("233", "Neko", "Nekic"));
			//baza.dbStudenti.Add(new Student("1f32r", "Trecko", "Treckovic"));
			//baza.SaveChanges();
			DataContext = this;
			dgPredmeti.ItemsSource = baza.dbPredmeti.ToList();
			dgStudenti.ItemsSource = baza.dbStudenti.ToList();


			Brisanje = new RoutedUICommand
				(
					"Brisanje podatka iz datagrida",
					"Brisanje",
					typeof(RoutedUICommand),
					new InputGestureCollection
					{
						new KeyGesture(Key.Up, ModifierKeys.Shift)
					}
				);
			CommandBinding cb = new CommandBinding();
			cb.Command = Brisanje;
			cb.CanExecute += MozeDaSeIzvrsi;
			cb.Executed += StaDaRadi;
			this.CommandBindings.Add(cb);
			brisanje.Command = Brisanje;
		}

		public void MozeDaSeIzvrsi(object posiljaoc, CanExecuteRoutedEventArgs a)
		{
			if (aktivniGrid?.SelectedItem != null)
				a.CanExecute = true;
			else
				a.CanExecute = false;
		}

		public void StaDaRadi(object posiljaoc, 
			ExecutedRoutedEventArgs a)
		{
			
			lbl.Content = (a.Source as DataGrid).SelectedItem;
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

		private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			this.aktivniGrid = ((sender as TabControl).SelectedItem as TabItem).Content as DataGrid;
			brisanje.CommandTarget = aktivniGrid;
			//Pretraga = null;
		}
	}
}
