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

namespace rgb
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

        List<List<Pixel>> pixelek = new List<List<Pixel>>();

        private void Ablak_Loaded(object sender, RoutedEventArgs e)
        {
            string[] sorok = File.ReadAllLines("kep-1.txt");

            for (int i = 0; i < sorok.Length; i++)
            {
                string[] vag = sorok[i].Split(" ");

                List<Pixel> temp = new List<Pixel>();

                for (int j = 0; j < vag.Length; j += 3)
                {
                    temp.Add(new Pixel(Convert.ToInt32(vag[j]), Convert.ToInt32(vag[j + 1]), Convert.ToInt32(vag[j + 2])));
                }
                pixelek.Add(temp);
            }
                

        }

        private void gomb_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int sorszam = Convert.ToInt32(sor.Text);
                int oszlopszam = Convert.ToInt32(oszlop.Text);

                Pixel p = pixelek[sorszam - 1][oszlopszam - 1];

                textblock.Text = "A képpont színe "+p.rgbkod();

                szinesdoboz.Fill = new SolidColorBrush(Color.FromRgb((byte)p.r, (byte)p.g, (byte)p.b));
            }
            catch 
            {
                
            };
        }

        private void vilagosSzamol_Click(object sender, RoutedEventArgs e)
        {
            int darab = 0;
            for (int i = 0; i < pixelek.Count; i++)
            {
                for(int j = 0; j < pixelek[i].Count; j++)
                {
                    if (pixelek[i][j].vilagos())
                    {
                        darab++;
                    }
                }
            }
            doboz.Text = darab.ToString();
        }

        private void sotetSzamol_Click(object sender, RoutedEventArgs e)
        {
            Pixel sotet = pixelek[0][0];

            for(int i = 0;i < pixelek.Count;i++)
            {
                for (int j = 0; j < pixelek[i].Count; j++)
                {
                    if (pixelek[i][j].komponensOsszeg() < sotet.komponensOsszeg())
                    {
                        sotet = pixelek[i][j];
                    }
                }
            }
            sotetOsszeg.Text = sotet.komponensOsszeg().ToString();
             
            List<Pixel>sotetek = new List<Pixel>();
            for (int i = 0; i < pixelek.Count; i++)
            {
                for (int j = 0; j < pixelek[i].Count; j++)
                {
                    if (pixelek[i][j].komponensOsszeg() == sotet.komponensOsszeg())
                    {
                        sotetek.Add(pixelek[i][j]);
                    }
                }
            }

            listbox.ItemsSource = sotetek;
            
            for(int i = 0;i < sotetek.Count;i++)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Width = 100;
                rectangle.Height = 100;

                rectangle.Fill = new SolidColorBrush(Color.FromRgb((byte)sotetek[i].r, (byte)sotetek[i].g, (byte)sotetek[i].b));

                panel.Children.Add(rectangle);  
            }

        }

        bool hatar(int sorSzam, int elteres)
        {
            for(int i = 0;i < pixelek[sorSzam].Count-1;i++)
            {
                if (Math.Abs(pixelek[sorSzam][i].b - pixelek[sorSzam][i+1].b) > elteres)
                {
                    return true;
                }
            }
            return false;
        }

        private void gomb3_Click(object sender, RoutedEventArgs e)
        {

            List <int> hatarok = new List<int>();

            for (int i = 0; i < pixelek.Count; i++)
            {
                if (hatar(i, 10))
                {
                    hatarok.Add(i);
                }
            }

            legfelso.Text = (hatarok[0]+1).ToString();
            legalso.Text = (hatarok[hatarok.Count -1]+1).ToString();

        }
    }
}