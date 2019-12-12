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

namespace Calculator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Racunar r = new Racunar();
		Binding b = new Binding();
		PropertyPath prvi = new PropertyPath("X");
		PropertyPath drugi = new PropertyPath("Y");
		public MainWindow()
		{
			InitializeComponent();
			DataContext = r;
			b.Source = r;
			b.Path = prvi;

			BindingOperations.SetBinding(Displej,
				Label.ContentProperty, b);
		}

		private void DodajBroj_Click(object sender, RoutedEventArgs e)
		{
			
			r.unosBroja(decimal.Parse(((Button)sender).Content.ToString()));
		}

		private void C_Click(object sender, RoutedEventArgs e)
		{
			r.Ocisti(true);
		}

		private void CE_Click(object sender, RoutedEventArgs e)
		{
			r.Ocisti(false);
		}

		private void Operacija_Click(object sender, RoutedEventArgs e)
		{
			BindingOperations.ClearBinding(Displej, Label.ContentProperty);
			var staraPutanja = b.Path;
			b = new Binding();
			b.Source = r;
			if (staraPutanja == prvi)
			{
				b.Path = drugi;
			} else
			{
				b.Path = prvi;
			}
			BindingOperations.SetBinding(Displej, Label.ContentProperty, b);
			r.Op = ((Button)sender).Content.ToString().ToCharArray()[0];
		}
	}
}
