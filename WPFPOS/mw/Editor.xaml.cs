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

namespace mw
{
	/// <summary>
	/// Interaction logic for Editor.xaml
	/// </summary>
	public partial class Editor : Window
	{
		public Editor()
		{
			InitializeComponent();	
		}

		private void Button_OK(object sender, RoutedEventArgs e)
		{
			if (DataContext is ObservableCollection<Artikal> kolekcija)
			{
				if (string.IsNullOrEmpty(nzv.Text))
				{
					MessageBox.Show("Unesite naziv!");
				}
				else if (!decimal.TryParse(cena.Text, out _))
				{
					MessageBox.Show("Cena nije dobra!");
				}else
				{
					kolekcija.Add(new Artikal(nzv.Text, decimal.Parse(cena.Text)));
					this.Close();
				}
				//standardni cast
				//((ObservableCollection<Artikal>)DataContext)
				//(DataContext as ObservableCollection<Artikal>)
			}
			else
			{   
				BindingOperations.GetBindingExpression(nzv, TextBox.TextProperty).UpdateSource();
				BindingOperations.GetBindingExpression(cena, TextBox.TextProperty).UpdateSource();
				this.Close();
			}
			
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void Window_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (DataContext is ObservableCollection<Artikal>)
			{
				BindingOperations.ClearBinding(nzv,
					TextBox.TextProperty);
				BindingOperations.ClearBinding(cena,
					TextBox.TextProperty);
			}
		}
	}
}
