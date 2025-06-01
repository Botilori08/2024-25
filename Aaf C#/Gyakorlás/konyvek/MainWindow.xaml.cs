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

		List<Konyv> konyvek = new List<Konyv>();
		private void Ablak_Loaded(object sender, RoutedEventArgs e)
		{
			string[] sorok = File.ReadAllLines("kiadas.txt");



			for (int i = 0; i < sorok.Length; i++)
			{
                //blokk.Text = sorok[i];
                string[] vag = sorok[i].Split(";");

				konyvek.Add(new Konyv(Convert.ToInt32(vag[0]), Convert.ToInt32(vag[1]), vag[2], vag[3], Convert.ToInt32(vag[4])));
			}
			
			MessageBox.Show(konyvek.Count+"");

		}

		
		private void masodikfeladat_Click(object sender, RoutedEventArgs e)
		{

		}

		private void harmadikfeladat_Click(object sender, RoutedEventArgs e)
		{
			int legnagyobbPeldany = 0;
			int alkalom = 0;

			
			for (int i = 0; i < konyvek.Count; i++)
			{
				if(legnagyobbPeldany < konyvek[i].peldanySzam)
				{
					legnagyobbPeldany = konyvek[i].peldanySzam;
					MessageBox.Show(legnagyobbPeldany.ToString());
				}
			}

			for(int i = 0; i < konyvek.Count();i++)
			{
				if (konyvek[i].peldanySzam == legnagyobbPeldany)
				{
					alkalom++;
				}
			}

			peldany.Content = legnagyobbPeldany.ToString();
			szama.Content = alkalom.ToString();

		}
	}
}