using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;

namespace IPCheckerApp
{
	/*
	 Тема: DNS, Socket

     Написать графическое оконное приложение (WPF или Windows Form)
     для определения IP-адресов по URL-имени сервера, сетевого ресурса
     и наоборот - по IP-адресу определеить связанное с ним имя серевера,
     сетевого ресурса, если таковой существует.
	 */
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();			
		}

		private void AdressInfoButtonClick(object sender, RoutedEventArgs e)
		{

			try
			{
				//IPHostEntry ipAddress = Dns.GetHostByName(addressTextBox.Text);
				IPHostEntry ipAddress = Dns.GetHostEntry(addressTextBox.Text);
				infoTextBlock.Text = ipAddress.HostName + "\n";
				foreach (var ip in ipAddress.AddressList)
				{
					infoTextBlock.Text += ip.ToString() + "\n";
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Ошибка: " + exception);
			}
		}
	}
}
