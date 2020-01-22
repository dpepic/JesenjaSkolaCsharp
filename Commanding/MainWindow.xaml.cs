using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Commanding
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		public bool? Moguce { get; set; }

		public static RoutedUICommand komanda;

		public MainWindow()
		{
			InitializeComponent();

			komanda = new RoutedUICommand
				(
					"Ovo je komanda",
					"Komanda",
					typeof(RoutedUICommand),
					new InputGestureCollection
					{
						new KeyGesture(Key.Up),
						new KeyGesture(Key.Down, ModifierKeys.Shift),
						new MouseGesture(MouseAction.LeftDoubleClick)
					}
				) ;
			CommandBinding cb = new CommandBinding();
			cb.Command = komanda;
			cb.CanExecute += MozeDaSeIzvrsi;
			cb.Executed += StaDaRadi;

			this.CommandBindings.Add(cb);

			//test.Command = komanda;
			//test.CommandTarget = lbl;
			DataContext = this;
		}

		public void MozeDaSeIzvrsi(object sender, CanExecuteRoutedEventArgs a)
		{
			if (Moguce == true)
				a.CanExecute = true;
			else
				a.CanExecute = false;
		}

		public void StaDaRadi(object sender, ExecutedRoutedEventArgs a)
		{
			MessageBox.Show("asdsd");
		}
	}
}
