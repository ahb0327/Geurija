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

namespace Geurija
{
	/// <summary>
	/// MainWindow.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly Main _MAIN;

		public MainWindow()
		{
			InitializeComponent();

			_MAIN = null;
		}

		public MainWindow(Main main)
		{
			InitializeComponent();

			_MAIN = main;
		}

		private void OnClosed(object sender, EventArgs e)
		{
			_MAIN.Close();
		}

		private void NewFile_Checked(object sender, RoutedEventArgs e)
		{

		}

		private void Open_Checked(object sender, RoutedEventArgs e)
		{

		}

		private void Save_Checked(object sender, RoutedEventArgs e)
		{

		}
	}
}
