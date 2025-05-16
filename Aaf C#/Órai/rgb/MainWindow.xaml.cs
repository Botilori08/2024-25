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

            }
            catch {
            
            };

            int sorszam = Convert.ToInt32(sor.Text);
            int oszlopszam = Convert.ToInt32(oszlop.Text);


        }
    }
}