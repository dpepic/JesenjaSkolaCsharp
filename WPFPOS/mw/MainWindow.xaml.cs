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
using System.IO;

namespace mw
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		ObservableCollection<Artikal> lista = new ObservableCollection<Artikal>();

		public MainWindow()
		{
			InitializeComponent();
			
			if (File.Exists("art.txt"))
			{
				foreach (string art in File.ReadLines("art.txt"))
				{
					string[] a = art.Split(';');
					//0 naziv, 1 kol, 2 cena
					lista.Add(new Artikal(a[0], int.Parse(a[1]),
							  decimal.Parse(a[2])));
				}
			}
			cmb.ItemsSource = lista;
			cmb.DisplayMemberPath = "Naziv";
			dg.ItemsSource = lista;
		}

		private void Button_Izmeni(object sender, RoutedEventArgs e)
		{
			Editor noviProzor = new Editor();
			noviProzor.Visibility = Visibility.Visible;
			noviProzor.DataContext = dg.SelectedItem;
		}

		private void cmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			DataContext = cmb.SelectedItem;
		}

		private void Button_Obrisi(object sender, RoutedEventArgs e)
		{
			if (dg.SelectedItem == null)
			{
				MessageBox.Show("Izaberite nesto!", "Greska" );
			} else
			{
				lista.Remove(dg.SelectedItem as Artikal);
			}
		}

		private void Button_Dodaj(object sender, RoutedEventArgs e)
		{
			Editor noviProzor = new Editor();
			noviProzor.Visibility = Visibility.Visible;
			noviProzor.DataContext = lista;
		}

		private void Button_Prodaj(object sender, RoutedEventArgs e)
		{
			(dg.SelectedItem as Artikal).Lager--;
			
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (File.Exists("art.txt"))
			{
				File.Delete("art.txt");
			}
			foreach(Artikal a in lista)
			{
				File.AppendAllText("art.txt",
					$"{a.Naziv};{a.Lager};{a.Cena}" + Environment.NewLine);
			}
		}
	}
}
