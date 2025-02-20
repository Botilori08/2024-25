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

namespace teljesenmindegy
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int eredmeny = 0;

            int Aszam = Convert.ToInt32(A.Text);

            int Bszam = Convert.ToInt32(B.Text);

            eredmeny = Aszam + Bszam;

            Eredmeny.Content = eredmeny;


        }
    }
}