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

		private void Broj_Click(object sender, RoutedEventArgs e)
		{
			Button b = sender as Button; //jednako sa (Button)sender
			r.UnesiBroj(int.Parse(b.Content.ToString()));

			//Moze da se resi i u jednom redu, ovako:
			//r.uvecajBroj(int.Parse((sender as Button).Content.ToString()));
		}

		private void Clear_Click(object sender, RoutedEventArgs e)
		{
			r.Clear(false);
		}

		private void Sabiranje_Click(object sender, RoutedEventArgs e)
		{
			r.Op = '+';
		}

		private void Jednako_Click(object sender, RoutedEventArgs e)
		{
			r.Op = '=';
		}

		private void ClearErr_Click(object sender, RoutedEventArgs e)
		{
			r.Clear(true);
			
		}

		private void Mem_Click(object sender, RoutedEventArgs e)
		{
			r.MemorijaOp((sender as Button).Content.ToString().ToCharArray()[1]);
		}
	}
}
