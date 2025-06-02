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
using System.IO;

namespace konyvek
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

		List <Konyv> konyvek = new List <Konyv>();
		private void ablak_Loaded(object sender, RoutedEventArgs e)
		{
			string[] sorok = File.ReadAllLines("kiadas.txt");

			for(int i = 0; i < sorok.Length; i++)
			{
				string[] vag = sorok[i].Split(";");

				konyvek.Add(new Konyv(int.Parse(vag[0]), int.Parse(vag[1]), vag[2], vag[3], int.Parse(vag[4])));
			}
			
		}

		private void masodikFeladat_Click(object sender, RoutedEventArgs e)
		{
			string szerzoNev = megadottNev.Text;
			int kiadasSzam = 0;

			for (int i = 0; i < konyvek.Count; i++)
			{
				if (konyvek[i].leiras.Contains(szerzoNev))
				{
					kiadasSzam++;
				}
			}

			if (kiadasSzam > 0)
			{
				kiiras.Content = $"{kiadasSzam.ToString()} könyvkiadás";
			}
			else
			{
				kiiras.Content = "Nem adtak ki";
			}
		}

		private void harmadikFeladat_Click(object sender, RoutedEventArgs e)
		{
			int legnagyobbPeldany = 0;
			int darabszam = 0;

			for (int i = 0; i < konyvek.Count; i++)
			{
				if (konyvek[i].peldanySzam > legnagyobbPeldany)
				{
					legnagyobbPeldany = konyvek[i].peldanySzam;
				}
			}
			for (int i = 0; i < konyvek.Count; i++)
			{
				if (konyvek[i].peldanySzam == legnagyobbPeldany)
				{
					darabszam++;	
				}					
			}

			peldany.Content = legnagyobbPeldany.ToString();
			elofordult.Content = darabszam.ToString();


		}

        private void negyedikFeladat_Click(object sender, RoutedEventArgs e)
        {
			int ev = 0;
			int negyedev = 0;
			string leiras = "";


			for()
        }
    }
}