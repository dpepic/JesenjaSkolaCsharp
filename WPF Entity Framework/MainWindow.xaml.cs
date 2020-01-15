using System;
using System.Collections.Generic;
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
		public MainWindow()
		{
			InitializeComponent();
			dg.ItemsSource = db.Probe.Local;

			db.Probe.ToList();
			
			//db.Probe.Add(new Proba("prva"));
			//db.Probe.Add(new Proba("druga"));
			//db.Probe.Add(new Proba("treca"));
			//db.SaveChanges();
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
