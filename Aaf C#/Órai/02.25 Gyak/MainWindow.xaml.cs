﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _02._25_Gyak
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		int szamlalo = 0;
		private void Button_Click(object sender, RoutedEventArgs e)
		{
		   if(szamlalo%2 == 1)
			{
				kep.Visibility = Visibility.Visible;
			}
			else {
			kep.Visibility = Visibility.Hidden; 
			}

			szamlalo++;


			//Hf: Egymás mellett kettő kép, egy gomb, gombnyomásra mindig csak az egyik látszik
		}
	}
}