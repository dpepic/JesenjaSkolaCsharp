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

namespace Delegati
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Alarm a = new Alarm();
		Civil c = new Civil();

		public MainWindow()
		{
			InitializeComponent();
			Civil asd = new Civil();
			asd.Slusaj(a);

			
		}

		private void btn_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Bla bla");
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("asdasd");
			e.Handled = true;
		}
	}

	public class Alarm
	{
		public delegate void SlusamoEventHandler(object KoJe, SlusamoEventArgs e);
		public event SlusamoEventHandler Slusamo;

		public class SlusamoEventArgs
		{
			public string taj;
			public string onaj;
			public int x;
		}
		
		public void Neka()
		{
			//neka provera obavezno
			onSlusamo();
		}
		private void onSlusamo()
		{
			Slusamo?.Invoke(this, new SlusamoEventArgs());
		}
		/* hrpa koda koji u stvari radi nesto*/
	}

	public class Civil
	{
		public void Slusaj(Alarm neki)
		{
			neki.Slusamo += Reakcija;
		}
		
		private void Reakcija(object KoSalje, Alarm.SlusamoEventArgs e)
		{
			var nesto = KoSalje;
		}
	}
}
