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

namespace Delegati
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Alarm a = new Alarm();
		Civil c = new Civil();
		Vatrogasac v = new Vatrogasac();
		public MainWindow()
		{
			InitializeComponent();
			Civil asd = new Civil();
			asd.Slusaj(a);
			v.Slusaj(a);
			c.Slusaj(a);
			
		}

		private void btn_Click(object sender, RoutedEventArgs e)
		{
		 a.OglasiSe();
		}

		
	}

	public class Alarm
	{
		public delegate void Slusamo();
		public Slusamo Slusaoci;

		public void OglasiSe()
		{
			Slusaoci?.Invoke();
		}
		/* hrpa koda koji u stvari radi nesto*/
	}

	public class Civil
	{
		public void Slusaj(Alarm neki)
		{
			neki.Slusaoci += Reakcija;
		}
		
		private void Reakcija()
		{
			//return "Beeeezim!";
		}
	}
	public class Vatrogasac
	{
		public void Slusaj(Alarm neki)
		{
			neki.Slusaoci += Rekacija;
		}
		public void Rekacija()
		{
			//return "Idem da gasim!!";
		}
	}

	
}
