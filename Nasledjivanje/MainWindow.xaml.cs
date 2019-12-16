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

namespace Nasledjivanje
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ZaposlenoLice zl = new ZaposlenoLice("Djura", "Djurovica", 4000);
		Osoba o = new Osoba("Pera", "Peric");

		public MainWindow()
		{
			InitializeComponent();
		}

		private void d_Osoba_Click(object sender, RoutedEventArgs e)
		{
			lb.Content = o.ToString();
		}

		private void d_ZP_Click(object sender, RoutedEventArgs e)
		{
			lb.Content = zl.ToString();
		}
	}
}
