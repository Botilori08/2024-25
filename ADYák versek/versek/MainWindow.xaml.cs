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
        }

        private void kuldes_Click(object sender, RoutedEventArgs e)
        {
            string nev = Nev.Text;
            string szerzo = szerzoNeve.Text;
            string versCime = cim.Text;
            string datum = Datum.Text;

            StreamWriter sr = new StreamWriter("eddigiversek.txt",true,Encoding.UTF8);

            sr.WriteLine($"{nev};{szerzo} - {versCime};{datum}");
            
            Nev.Text = "";
            szerzoNeve.Text ="";
            cim.Text = "";
            Datum.Text = "";
            sr.Close();
        }
    }
}