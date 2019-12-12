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
using System.Collections.ObjectModel;

namespace MutliWindowEdit
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ObservableCollection<Artikal> artikli = new
			ObservableCollection<Artikal>();

		public MainWindow()
		{
			InitializeComponent();
			dg.ItemsSource = artikli;

			artikli.Add(new Artikal("Test", 123));
			artikli.Add(new Artikal("Drugi", 12));
			artikli.Add(new Artikal("Treci", 2345));
			artikli.Add(new Artikal("Peti", 987));
		}
		
		private void Button_Brisanje(object sender, RoutedEventArgs e)
		{
			artikli.Remove(dg.SelectedItem as Artikal);
		}

		private void Button_Izmena(object sender, RoutedEventArgs e)
		{
			if (dg.SelectedItem == null)
			{
				MessageBox.Show("Izaberite stavku!");
			} else
			{
				ArtikalED prozor = new ArtikalED();
				prozor.DataContext = dg.SelectedItem;
				prozor.Visibility = Visibility.Visible;
			}
		}

		private void Button_Dodavanje(object sender, RoutedEventArgs e)
		{
			ArtikalED prozor = new ArtikalED();
			prozor.DataContext = artikli;
			prozor.Visibility = Visibility.Visible;
		}
	}
}
