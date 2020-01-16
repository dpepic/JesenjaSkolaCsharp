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

namespace Ispiti
{
	/// <summary>
	/// Interaction logic for StudEd.xaml
	/// </summary>
	public partial class StudEd : Window
	{
		public StudEd()
		{
			InitializeComponent();
			if (DataContext == null)
				DataContext = new Student();
		}

		private void odust_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void ok_Click(object sender, RoutedEventArgs e)
		{
			this.DialogResult = true;
			this.BindingGroup.CommitEdit();
			this.Close();
		}
	}
}
