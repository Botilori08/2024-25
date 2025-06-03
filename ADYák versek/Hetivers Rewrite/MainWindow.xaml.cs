using System.IO;
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

namespace versek
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			nevKivalaszt.ItemsSource = nevek;
			listBox.ItemsSource = versKiir;
		}

		List <Vers> versek = new List <Vers>();
		List<string> versKiir = new List<string>();
		string[] nevek = File.ReadAllLines("ember.txt");

		private void ablak_Loaded(object sender, RoutedEventArgs e)
		{

			

			string[] hetiVersek = File.ReadAllLines("eddigiversek.txt");

			for (int i = 0; i < hetiVersek.Length; i++)
			{
				string[] vag = hetiVersek[i].Split(';');
				versek.Add(new Vers(vag[0], vag[1], vag[2], vag[3]));
			}


			for (int i = 0; i < versek.Count; i++)
			{
				versKiir.Add($"{versek[i].felelos} ; {versek[i].versSzerzo} - {versek[i].versCim} ; {versek[i].datum}");
			}

			

		}

		
		
		private void kuldes_Click(object sender, RoutedEventArgs e)
		{

			string szerzo = szerzoNeve.Text;
			string versCime = cim.Text;
			string datum = Datum.Text;
			string neve = nevKivalaszt.Text;

			

			StreamWriter sr = new StreamWriter("eddigiversek.txt",true,Encoding.UTF8);

			if(szerzo !="" && versCime !="" && datum != "" && neve != "")
			{
				versek.Add(new Vers(szerzo, versCime, neve, datum));

				sr.WriteLine($"{neve};{szerzo};{versCime};{datum}");

				versKiir.Add($"{neve} ; {szerzo} - {versCime} ; {datum}");
			}

			sr.Close();
			
			nevKivalaszt.Text = "";
			szerzoNeve.Text ="";
			cim.Text = "";
			Datum.Text = "";

			listBox.Items.Refresh();

			//listBox.ItemsSource = versKiir;
			/*
			string[] hetiVersek = File.ReadAllLines("eddigiversek.txt");
			for (int i = 0; i < hetiVersek.Length; i++)
			{
				versAdatok.Add(hetiVersek[i]);
			}

			listBox.ItemsSource = versAdatok;*/
		}


	}
}