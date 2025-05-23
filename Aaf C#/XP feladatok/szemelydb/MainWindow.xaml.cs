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

namespace szemelydb
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

        static string nev;
        static string telepules;
        static string lakcim ;
        static string telefonszam;
        static string fizetes;

        private void hozzadas_Click(object sender, RoutedEventArgs e)
        {
            nev = Nev.Text;
            telepules = Telepules.Text;
            lakcim = Lakcim.Text;
            telefonszam = Telefonszam.Text;
            fizetes = Fizetes.Text;

            StreamWriter sr = new StreamWriter("szemely.txt",true);

            sr.WriteLine($"{nev};{telepules};{lakcim};{telefonszam};{fizetes}");

            sr.Close();
        }

        private void torles_Click(object sender, RoutedEventArgs e)
        {
            Nev.Text = "";
            Telepules.Text = "";
            Lakcim.Text = "";
            Telefonszam.Text = "";
            Fizetes.Text = "";
        }

        private void kilepes_Click(object sender, RoutedEventArgs e)
        {
            ablak.Close();
        }
    }
}