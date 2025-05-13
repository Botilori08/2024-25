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


namespace balkezesek
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
        List<Jatekos> jatekosok = new List<Jatekos>();
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            string[] sorok = File.ReadAllLines("balkezesek.csv");



            for (int i = 1; i < sorok.Length; i++)
            {
                jatekosok.Add(Jatekos.Factory(sorok[i]));
            }
        }

        private void gomb1_Click(object sender, RoutedEventArgs e)
        {
            Harmadikfeladat.Text = jatekosok.Count().ToString();
        }
        private void gomb2_Click(object sender, RoutedEventArgs e)
        {
            List<string> magassagok = new List<string>();

            for (int i = 0; i < jatekosok.Count; i++)
            {
                if (jatekosok[i].utolsoDatum < DateOnly.Parse("1999-11-01"))
                {
                    magassagok.Add(jatekosok[i].magassagCentimeter.ToString());
                }
            }
            listBox.ItemsSource = magassagok;
        }

        bool joEvszam = false;
        private void bekeres_TextChanged(object sender, TextChangedEventArgs e)
        {
            //kiiras.Content = bekeres.Text;
            kiiras.Content = "";

            try
            {
                int szam = Convert.ToInt32(bekeres.Text);
                if (szam < 1990 || szam > 1999)
                {
                    throw new Exception();
                }
                joEvszam = true;
            }
            catch 
            {
                joEvszam=false;
                kiiras.Content = "Hibás adat! Kérek egy 1990 és 1999 közötti évszámot!";
            }

        }

        private void gomb3_Click(object sender, RoutedEventArgs e)
        {
            if (joEvszam)
            {
            List<int> sulyok = new List<int>();

            for (int i = 0; i < jatekosok.Count; i++)
            {
                if (jatekosok[i].jatszottE(Convert.ToInt32(bekeres.Text)))
                {
                    sulyok.Add(jatekosok[i].suly);
                }
            }

            int osszesSuly = 0;

            for (int i = 0; i < sulyok.Count; i++)
            {
                osszesSuly += sulyok[i];
            }

            

            label5.Content = Math.Round(osszesSuly / (double)sulyok.Count,2);
            }
        }
    }

}