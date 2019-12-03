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

namespace Calc
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Racunar r = new Racunar();

		public MainWindow()
		{
			InitializeComponent();
			DataContext = r;
		}

		private void br9_Click(object sender, RoutedEventArgs e)
		{
			r.uvecajBroj(9);
		}
	}
}
