using System.Diagnostics;
using System.IO;
using System.Security.Policy;
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

		List<Vers> versek = new List<Vers>();
		List<string> versKiir = new List<string>();
		List<string> URLek = new List<string>();
		string[] nevek = File.ReadAllLines("ember.txt");



		private void ablak_Loaded(object sender, RoutedEventArgs e)
		{


			string[] hetiVersek = File.ReadAllLines("eddigiversek.txt");

			for (int i = 0; i < hetiVersek.Length; i++)
			{
				//MessageBox.Show(hetiVersek[i]);
				string[] vag = hetiVersek[i].Split(';');
				versek.Add(new Vers(vag[0], vag[1], vag[2], vag[3]));
			}


			for (int i = 0; i < versek.Count; i++)
			{
				versKiir.Add($"{versek[i].felelos} ; {versek[i].versSzerzo} - {versek[i].versCim} ; {versek[i].datum}");
				//MessageBox.Show(versek[i].URL());
				URLek.Add(versek[i].URL());
			}
			

		}
		private void kuldes_Click(object sender, RoutedEventArgs e)
		{

			string szerzo = szerzoNeve.Text;
			string versCime = cim.Text;
			string datum = Datum.Text;
			string neve = nevKivalaszt.Text;



			StreamWriter sr = new StreamWriter("eddigiversek.txt", true, Encoding.UTF8);

			if (szerzo != "" && versCime != "" && datum != "" && neve != "")
			{
				versek.Add(new Vers(neve, szerzo, versCime, datum));

				sr.WriteLine($"{neve};{szerzo};{versCime};{datum}");

				versKiir.Add(versek[versek.Count-1].osszefuz());
			}

			sr.Close();

			nevKivalaszt.Text = "";
			szerzoNeve.Text = "";
			cim.Text = "";
			Datum.Text = "";

			listBox.Items.Refresh();

			//MessageBox.Show(versek.Count().ToString());
			//MessageBox.Show(versKiir.Count().ToString());


			//List <string> urlek = new List<string>();

			for (int i = 0 ; i < versek.Count; i++)
			{
				listBox.Tag = versek[i].URL();
			}





		//listBox.ItemsSource = versKiir;
		/*
		string[] hetiVersek = File.ReadAllLines("eddigiversek.txt");
		for (int i = 0; i < hetiVersek.Length; i++)
		{
			versAdatok.Add(hetiVersek[i]);
		}

		listBox.ItemsSource = versAdatok;*/
		}		
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			List<string> szures = new List<string>();
			string nev = vizsgaltNev.Text;
			string szerzo = vizsgaltSzerzo.Text;
			string verscim = vizsgaltVerscim.Text;

			//MessageBox.Show(versek[versek.Count() - 1].felelos);

			int adatSzam = 0;
			

			adatSzam = nev != "" ? adatSzam += 1 : adatSzam;
			adatSzam = szerzo != "" ? adatSzam += 1 : adatSzam;
			adatSzam = verscim != "" ? adatSzam += 1 : adatSzam;
			
			if (adatSzam == 3)
			{
				for (int i = 0; i < versek.Count; i++)
				{
					if (nev == versek[i].felelos && szerzo == versek[i].versSzerzo && verscim == versek[i].versCim)
					{
						szures.Add(versek[i].osszefuz());
					}

					//MessageBox.Show(versek[i].ToString());
				}
			}
			else if(adatSzam == 2)
			{
				for (int i = 0; i < versek.Count; i++)
				{
					if ((nev == versek[i].felelos && szerzo == versek[i].versSzerzo) || 
						(nev == versek[i].felelos && verscim == versek[i].versCim) ||
						(verscim == versek[i].versCim && szerzo == versek[i].versSzerzo))
					{
						szures.Add(versek[i].osszefuz());
					}

					//MessageBox.Show(versek[i].ToString());
				}
			}
			else
			{
				for (int i = 0; i < versek.Count; i++)
				{
					if (nev == versek[i].felelos || szerzo == versek[i].versSzerzo || verscim == versek[i].versCim)
					{
						szures.Add(versek[i].osszefuz());
					}

					//MessageBox.Show(versek[i].ToString());
				}
			}
			


			eredmeny.ItemsSource = szures;

			listBox.Items.Refresh();

		}

		private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if(listBox.SelectedItem is ListBoxItem SelectedItem)
			{

					/*string url = listBox.SelectedItem.Tag as string;
					if (!string.IsNullOrEmpty(url))
					{
						Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
					}

					// Visszaállítjuk a kiválasztást, hogy újra lehessen ugyanarra kattintani
					.SelectedItem = null;*/
				
			}
		}
	}
}