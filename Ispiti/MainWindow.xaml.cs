using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Ispiti
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		IspitBaza db = new IspitBaza();

		private string pretraga;
		public string Pretraga
		{
			get => pretraga;
			set
			{
				pretraga = value;

				
				db = new IspitBaza();
				if (string.IsNullOrEmpty(pretraga) || string.IsNullOrWhiteSpace(pretraga))
					dgStudenti.ItemsSource = db.dbStudenti.ToList();
				else
					dgStudenti.ItemsSource = db.dbStudenti.Where(s => s.Ime.ToLower().Contains(pretraga.ToLower()) ||
																      s.Prezime.ToLower().Contains(pretraga.ToLower())).ToList();

				//ObservableCollection<Student> studenti = new ObservableCollection<Student>();
				//foreach (Student s in db.dbStudenti.Local)
				//	if (s.Ime.ToLower().Contains(pretraga.ToLower()) ||
				//		s.Prezime.ToLower().Contains(pretraga.ToLower()))
				//		studenti.Add(s);
				//dgStudenti.ItemsSource = studenti;



			}
		}

		public MainWindow()
		{
			InitializeComponent();
			db.dbStudenti.ToList();
			dgStudenti.ItemsSource = db.dbStudenti.Local;
			txtPretraga.DataContext = this;
			//db.dbStudenti.Add(new Student("A-001", "Pera", "Peric"));
			//db.dbStudenti.Add(new Student("A-002", "Neko", "Nekic"));
			//db.dbStudenti.Add(new Student("A-003", "Trecko", "Treckovic"));
			//db.SaveChanges();
		}

		private void dodavanje_Click(object sender, RoutedEventArgs e)
		{
			StudEd proz = new StudEd();
			proz.Owner = this;
			if (proz.ShowDialog() == true)
			{
				if (db.dbStudenti.Local.Contains(proz.DataContext as Student))
					db.SaveChanges();
				else
				{
					db.dbStudenti.Add(proz.DataContext as Student);
					db.SaveChanges();
				}
				db = new IspitBaza();
				dgStudenti.ItemsSource = db.dbStudenti.ToList();
			}
				
		}

		private void izmena_Click(object sender, RoutedEventArgs e)
		{
			if (dgStudenti.SelectedItem != null)
			{
				StudEd proz = new StudEd();
				proz.Owner = this;
				proz.DataContext = dgStudenti.SelectedItem;
				if (proz.ShowDialog() == true)
				{
					db.SaveChanges();
					db = new IspitBaza();
					dgStudenti.ItemsSource = db.dbStudenti.ToList();
				}
			}
		}

		private void brisanje_Click(object sender, RoutedEventArgs e)
		{
			if (dgStudenti.SelectedItem != null)
			{
				db.dbStudenti.Remove(dgStudenti.SelectedItem as Student);
				db.SaveChanges();
				db = new IspitBaza();
				dgStudenti.ItemsSource = db.dbStudenti.ToList();			
			}
		}
	}

	public class IspitBaza:DbContext
	{
		public DbSet<Student> dbStudenti { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Student>().HasKey(s => s.BrIndeksa);
		}
	}
}
