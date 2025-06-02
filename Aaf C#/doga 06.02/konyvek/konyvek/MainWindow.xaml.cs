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


			List <int> evek = new List <int>();
			List<int> magyarkiadasSzam = new List<int>();
			List <int> magyarPeldanyszam = new List<int>();
			List <int> kulfoldikiadasSzam = new List<int>();
            List<int> kulfoldiPeldanyszam = new List<int>();


			int peldanyMagyar = 0;
			for (int i = 0; i < konyvek.Count; i++)
			{
				if (!evek.Contains(konyvek[i].ev))
				{
					evek.Add(konyvek[i].ev);
				}
            }

			int magyarSzam20 = 0;
            int magyarSzam21 = 0;
            int magyarSzam22 = 0;
            int magyarSzam23 = 0;

            int kulfoldiSzam20 = 0;
            int kulfoldiSzam21 = 0;
            int kulfoldiSzam22 = 0;
            int kulfoldiSzam23 = 0;

            int ev = 2020;
            for (int i = 0; i < konyvek.Count; i++)
			{
				if (konyvek[i].ev == 2020 && konyvek[i].konyvEredete=="ma")
				{
				magyarSzam20++; 
				}
                
                if (konyvek[i].ev == 2021 && konyvek[i].konyvEredete == "ma")
                {
                    magyarSzam21++;
                }
                if (konyvek[i].ev == 2022 && konyvek[i].konyvEredete == "ma")
                {
                    magyarSzam22++;
                }
                if (konyvek[i].ev == 2023 && konyvek[i].konyvEredete == "ma")
                {
                    magyarSzam23++;
                }

                
                if (konyvek[i].ev == 2020 && konyvek[i].konyvEredete == "kf")
                {
                    kulfoldiSzam20++;
                }
                if (konyvek[i].ev == 2021 && konyvek[i].konyvEredete == "kf")
                {
                    kulfoldiSzam21++;
                }
                if (konyvek[i].ev == 2022 && konyvek[i].konyvEredete == "kf")
                {
                    kulfoldiSzam22++;
                }
                if (konyvek[i].ev == 2023 && konyvek[i].konyvEredete == "kf")
                {
                    kulfoldiSzam23++;
                }
            }

            magyarkiadasSzam.Add(magyarSzam20);
            magyarkiadasSzam.Add(magyarSzam21);
            magyarkiadasSzam.Add(magyarSzam22);
            magyarkiadasSzam.Add(magyarSzam23);

            kulfoldikiadasSzam.Add(kulfoldiSzam20);
            kulfoldikiadasSzam.Add(kulfoldiSzam21);
            kulfoldikiadasSzam.Add(kulfoldiSzam22);
            kulfoldikiadasSzam.Add(kulfoldiSzam23);

            magyarSzam20 = 0;
            magyarSzam21 = 0;
            magyarSzam22 = 0;
            magyarSzam23 = 0;

            kulfoldiSzam20 = 0;
            kulfoldiSzam21 = 0;
            kulfoldiSzam22 = 0;
            kulfoldiSzam23 = 0;

            for (int i = 0; i < konyvek.Count; i++)
            {
                if (konyvek[i].ev == 2020 && konyvek[i].konyvEredete == "ma")
                {
                    magyarSzam20 += konyvek[i].peldanySzam;
                }
                if (konyvek[i].ev == 2021 && konyvek[i].konyvEredete == "ma")
                {
                    magyarSzam21 += konyvek[i].peldanySzam;
                }
                if (konyvek[i].ev == 2022 && konyvek[i].konyvEredete == "ma")
                {
                    magyarSzam22 += konyvek[i].peldanySzam;
                }
                if (konyvek[i].ev == 2023 && konyvek[i].konyvEredete == "ma")
                {
                    magyarSzam23 += konyvek[i].peldanySzam;
                }


                if (konyvek[i].ev == 2020 && konyvek[i].konyvEredete == "kf")
                {
                    kulfoldiSzam20 += konyvek[i].peldanySzam;
                }
                if (konyvek[i].ev == 2021 && konyvek[i].konyvEredete == "kf")
                {
                    kulfoldiSzam21+= konyvek[i].peldanySzam;
                }
                if (konyvek[i].ev == 2022 && konyvek[i].konyvEredete == "kf")
                {
                    kulfoldiSzam22 += konyvek[i].peldanySzam;
                }
                if (konyvek[i].ev == 2023 && konyvek[i].konyvEredete == "kf")
                {
                    kulfoldiSzam23 += konyvek[i].peldanySzam;
                }
            }

            magyarPeldanyszam.Add(magyarSzam20);
            magyarPeldanyszam.Add(magyarSzam21);
            magyarPeldanyszam.Add(magyarSzam22);
            magyarPeldanyszam.Add(magyarSzam23);

            kulfoldiPeldanyszam.Add(kulfoldiSzam20);
            kulfoldiPeldanyszam.Add(kulfoldiSzam21);
            kulfoldiPeldanyszam.Add(kulfoldiSzam22);
            kulfoldiPeldanyszam.Add(kulfoldiSzam23);

            Evek.ItemsSource = evek;
			magyarkiadas.ItemsSource = magyarkiadasSzam;
			kulfoldikiadas.ItemsSource = kulfoldikiadasSzam;
            magyarpeldany.ItemsSource = magyarPeldanyszam;
            kulfoldipeldany.ItemsSource = kulfoldiPeldanyszam;
              
            /*
            <table>
            <tr><th> Év </th><th> Magyar kiadás </th><th> Magyar példányszám </th><th> Külföldi kiadás </ th >< th > Külföldi példányszám </th></tr>
            <tr><td> 2020 </ td >< td > 45 </ td >< td > 834005 </td><td> 29 </td><td> 416000 </td ></tr>
            <tr><td> 2021 </ td >< td > 49 </ td >< td > 779130 </td><td> 52 </td><td> 736900 </td ></tr>
            <tr><td> 2022 </ td >< td > 63 </ td >< td > 1115210 </td><td> 42 </td><td> 649639 </td></tr>
            <tr><td> 2023 </ td >< td > 41 </ td >< td > 625185 </td><td> 40 </td><td> 536000 </td></tr>
            </table>*/
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

			kiiras3.Content = $"Legnagyobb példányszám: {legnagyobbPeldany.ToString()}, előfordult {darabszam.ToString()} alkalommal";




		}

        private void negyedikFeladat_Click(object sender, RoutedEventArgs e)
        {
			/*
			int ev = 0;
			int negyedev = 0;
			string leiras = "";*/

			for (int i = 0; i < konyvek.Count; i++)
			{
				if (konyvek[i].konyvEredete == "kf" && konyvek[i].peldanySzam >= 40000)
				{
					kiir.Content = $"{konyvek[i].ev}/{konyvek[i].negyedEv} {konyvek[i].leiras}";
					break;
				}
			}
			
        }


    }
}