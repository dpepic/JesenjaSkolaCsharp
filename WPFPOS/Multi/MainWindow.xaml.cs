using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Multi
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private ObservableCollection<Artikal> lista = new ObservableCollection<Artikal>();

		public MainWindow()
		{
			InitializeComponent();
			lista.Add(new Artikal("Prvi", 100));
			lista.Add(new Artikal("Drugi", 125));
			lista.Add(new Artikal("Treci", 450));
			lista.Add(new Artikal("Cetvrti", 450));

			combo.ItemsSource = lista;
			combo.DisplayMemberPath = "Naziv";

			tabela.ItemsSource = lista;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Editor noviProzor = new Editor();
			noviProzor.DataContext = tabela.SelectedItem;
			noviProzor.Visibility = Visibility.Visible;
		}

		private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			DataContext = combo.SelectedItem;
		}
	}
}