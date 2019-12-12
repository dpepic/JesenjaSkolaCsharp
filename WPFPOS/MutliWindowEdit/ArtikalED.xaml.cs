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
using System.Windows.Shapes;

namespace MutliWindowEdit
{
	/// <summary>
	/// Interaction logic for ArtikalED.xaml
	/// </summary>
	public partial class ArtikalED : Window
	{
		public ArtikalED()
		{
			InitializeComponent();
		}

		private void Button_OK(object sender, RoutedEventArgs e)
		{
			if (DataContext is ObservableCollection<Artikal> lista)
			{
				lista.Add(new Artikal(nzv.Text, decimal.Parse(cn.Text)));
			}
			else
			{
				BindingOperations.GetBindingExpression(nzv,
					TextBox.TextProperty).UpdateSource();
				BindingOperations.GetBindingExpression(cn,
					TextBox.TextProperty).UpdateSource();
			}
			this.Close();
		}

		private void Button_C(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
