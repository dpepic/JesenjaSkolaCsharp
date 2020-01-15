using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
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

namespace WPF_Entity_Framework
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Baza db = new Baza();

		public string Unos { get; set; }

		private string pretraga;
		public string Pretraga
		{
			get => pretraga;

			set
			{
				pretraga = value;

				db = new Baza();
				db.Probe.Where(p => p.tekst.Contains(pretraga)).ToList();
				dg.ItemsSource = db.Probe.Local;

				//if ((!string.IsNullOrEmpty(pretraga) && !string.IsNullOrWhiteSpace(pretraga)))
				//{
				//	ObservableCollection<Proba> p = new ObservableCollection<Proba>();
				//	foreach (Proba pb in db.Probe.Local)
				//	{
				//		if (pb.tekst.Contains(pretraga))
				//			p.Add(pb);
				//	}
				//	dg.ItemsSource = p;
				//}
				//else
				//	dg.ItemsSource = db.Probe.Local;

			}
		}

		public MainWindow()
		{
			InitializeComponent();
			dg.ItemsSource = db.Probe.Local;
			DataContext = this;
			db.Probe.ToList();

			//db.Probe.Add(new Proba("prva"));
			//db.Probe.Add(new Proba("druga"));
			//db.Probe.Add(new Proba("treca"));
			//db.SaveChanges();
		}

		private void unos_Click(object sender, RoutedEventArgs e)
		{
			if (!string.IsNullOrEmpty(Unos) && !string.IsNullOrWhiteSpace(Unos))
			{
				db.Probe.Add(new Proba(Unos));
				db.SaveChanges();
			}
		}

		private void izmena_Click(object sender, RoutedEventArgs e)
		{
			if (dg.SelectedItem != null)
				if (!string.IsNullOrEmpty(Unos) && !string.IsNullOrWhiteSpace(Unos))
				{
					(dg.SelectedItem as Proba).tekst = Unos;
					db.SaveChanges();
				}
		}

			private void brisanje_Click(object sender, RoutedEventArgs e)
		{
			if (dg.SelectedItem != null)
			{
				db.Probe.Remove(dg.SelectedItem as Proba);
				db.SaveChanges();
			}
		}

		private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (dg.SelectedItem != null)
			{
				Unos = (dg.SelectedItem as Proba).tekst;
			}
			else
				Unos = "";
		}
	}

	public class Baza : DbContext
	{
		public DbSet<Proba> Probe { get; set; }
	}

	public class Proba
	{
		[Key]
		public int broj { get; set; }
		public string tekst { get; set; }
		
		public Proba(string s)
		{
			tekst = s;
		}
		public Proba() { }
	}
}
