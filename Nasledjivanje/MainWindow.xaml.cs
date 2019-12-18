using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Nasledjivanje
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ZaposlenoLice zl = new ZaposlenoLice("Djura", "Djurovica", 4000);
		Osoba o = new Osoba("Pera", "Peric");

		ObservableCollection<Osoba> sveOsobe = new 
			ObservableCollection<Osoba>();
		
		public MainWindow()
		{
			InitializeComponent();
			sveOsobe.Add(new Osoba("Pera", "Peric"));
			sveOsobe.Add(new ZaposlenoLice("Neko", "Nekic", 324));
			sveOsobe.Add(new PenzionisanoLice(200, "Trece", "Lice"));
			cmb.ItemsSource = sveOsobe;
		}

		private void d_Osoba_Click(object sender, RoutedEventArgs e)
		{
			lb.Content = o.ToString();
		}

		private void d_ZP_Click(object sender, RoutedEventArgs e)
		{
			Osoba a = new Osoba("Pera", "Peric");
			Osoba b = new Osoba("Pera", "Peric");

			lb.Content = a.Equals(b);
			
		}
	}
}
