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
using System.Windows.Threading;

namespace Geurija
{
	/// <summary>
	/// LodingWindow.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class LodingWindow : Window
	{
		private DispatcherTimer	_timer;
		private int				_time = 0;

		public LodingWindow()
		{
			InitializeComponent();

			_timer = new DispatcherTimer();
			_timer.Interval = TimeSpan.FromSeconds(1);
			_timer.Tick += new EventHandler(TimerTick);
			_timer.Start();
		}

		void TimerTick(object sender, EventArgs e)
		{
			if ( _time++ == 1 )
			{
				DialogResult = true;
				_timer.Stop();
				this.Close();
			}
		}
	}
}
