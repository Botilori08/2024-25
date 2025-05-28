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

namespace utca_WPF
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
        List<Telek> telkek = new List<Telek>();
        Dictionary<string, string> szinNevek = new Dictionary<string, string>()
        {
            {"A","arany"},
            {"B","bézs"},
            {"C","ciklámen"},
            {"D","arany"},
            {"E",""},
            {"F","fekete"},
            {"G",""},
            {"H","arany"},
            {"I","arany"},
            {"J","arany"},
            {"K","kék"},
            {"L","lila"},
            {"M","mályva"},
            {"N",""},
            {"O","okkel"},
            {"P","piros"},
            {"Q","arany"},
            {"R","rózsaszín"},
            {"S","sárga"},
            {"T","türkíz"},
            {"U","umbra"},
            {"W","Weöres"},
            {"Z","zafírkék"},
            {"Y","ylang-ylang sárga"},
            {"X","Xanadu"},

        }
        Dictionary <string, SolidColorBrush> szinSzinek = new Dictionary<string, SolidColorBrush>();
        private void ablak_Loaded(object sender, RoutedEventArgs e)
        {
            string[] sorok = File.ReadAllLines("kerites.txt");

            for(int i = 0; i < sorok.Length; i++)
            {
                string[] vag = sorok[i].Split(' ');
                telkek.Add(new Telek(vag[0] == "0",
                    int.Parse(vag[1]),
                    new KeritesSzin(vag[2],);
            }
        }
    }
}