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

namespace Registar
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ObservableCollection<Osoba> osobe
			= new ObservableCollection<Osoba>();
		public MainWindow()
		{
			osobe.Add(new Osoba("Pera", "Peric", "123"));
			osobe.Add(new ZaposlenoLice("Neko", "Nekic", "321",
				"Tamo nesto", 500));
			osobe.Add(new PenzionisanoLice("Treca", "Osoba",
				"5566", 670));
			InitializeComponent();
			dg.ItemsSource = osobe;
			cmb.ItemsSource = osobe;
			//cmb.DisplayMemberPath = "Prezime";

		}

		private void DodajOsobu_Click(object sender, RoutedEventArgs e)
		{
			/*Editor ee = new Editor();
			ee.sp.Children.Add(new EditOsobe());
			ee.Visibility = Visibility.Visible;*/


			//lbl.Content = dg.SelectedItem.ToString();

			Osoba a = new Osoba("Pera", "Peric", "123");
			Osoba b = new Osoba("Pera", "Peric", "123");

			lbl.Content = a.Equals(b);
		}
	}
}
