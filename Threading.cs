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

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		BackgroundWorker radnik = new BackgroundWorker();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (!radnik.IsBusy)
			{
				radnik.WorkerReportsProgress = true;
				radnik.WorkerSupportsCancellation = true;
				radnik.ProgressChanged += Progres;
				radnik.RunWorkerCompleted += Gotov;
				radnik.DoWork += Posao;
				radnik.RunWorkerAsync();
			} else
			{
				radnik.CancelAsync();
			}
		}

		private void Gotov(object sndr, RunWorkerCompletedEventArgs a)
		{
			bla.Content = a.Result.ToString();
			prog.Value = 100;
		}

		private void Progres(object sndr, ProgressChangedEventArgs a)
		{
			bla.Content = a.UserState.ToString();
			prog.Value = a.ProgressPercentage;
		}

		private void Posao(object sndr, DoWorkEventArgs a)
		{
			for (int i = 0; i < 10000; i++)
			{
				if ((sndr as BackgroundWorker).CancellationPending)
				{
					a.Result="Prekinut";
					return;
				}
				(sndr as BackgroundWorker).ReportProgress((int)i/100, i);				
				System.Threading.Thread.Sleep(1);
			}
			a.Result = "Uspeh";
		}
	}
}
