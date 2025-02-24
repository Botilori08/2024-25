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

namespace _02._14_gyak
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			listBox.ItemsSource = adatok;

		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

        private List<string> adatok = new List<string>();
        private void Button_Click(object sender, RoutedEventArgs e)
		{

			adatok.Add(textBox.Text + ":" + jelszo.Text);


			/*
			string csere = textBox.Text;
			textBox.Text = jelszo.Text;

			jelszo.Text = csere;*/

			
		}
	}
}