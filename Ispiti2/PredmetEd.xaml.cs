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
using System.Windows.Shapes;

namespace Ispiti2
{
	/// <summary>
	/// Interaction logic for PredmetEd.xaml
	/// </summary>
	public partial class PredmetEd : Window
	{
		public PredmetEd()
		{
			InitializeComponent();
			if (DataContext == null)
				DataContext = new Predmet();
		}

		private void odustani_Click(object sender, RoutedEventArgs e)
		{
			this.DialogResult = false;
			this.Close();
		}

		private void ok_Click(object sender, RoutedEventArgs e)
		{
			this.BindingGroup.CommitEdit();
			this.DialogResult = true;
			this.Close();
		}
	}
}
