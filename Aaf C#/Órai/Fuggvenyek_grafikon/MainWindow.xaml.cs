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

/*
https://youtu.be/Q55T6LeTvsA?si=DWIwDZpkj1GBv5Ti
Koordináta rendszer
körív
Piros magasság (szinusz érték)
Piros poligon
fekete pont (aktuális x hely)
Belső szög jelölése (körív)
Fekete sugár
Kék vízszintes vonal
Piros doboz benne szinusz értékek
 */


namespace Fuggvenyek
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
        private void Sinus_Loaded(object sender, RoutedEventArgs e)
        {
            origoX = r;
            origoY = (int)(Sinus.ActualHeight/2);
            koordinataRendszer();

        }
        int origoX = 0;
        int origoY = 0;
        int r = 100;


        void koordinataRendszer()
        {
            Line xTengely = new Line();
            xTengely.Stroke = Brushes.Black;
            xTengely.X1 = 0;
            xTengely.Y1 = origoY;
            xTengely.X2 = Sinus.ActualWidth;
            xTengely.Y2 = origoY;

            Sinus.Children.Add(xTengely);


            Line yTengely = new Line();
            yTengely.Stroke = Brushes.Black;
            yTengely.X1 = origoX;
            yTengely.Y1 = 0;
            yTengely.X2 = origoX;
            yTengely.Y2 = Sinus.ActualHeight;

            Sinus.Children.Add(yTengely);

            for (int i = 45; i < 500; i+=45)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;

                vonalka.X1 = i+origoX;
                vonalka.Y1 = origoY-5;
                vonalka.X2 = i+origoX;
                vonalka.Y2 = origoY+5;

                Sinus.Children.Add(vonalka);


            }

            for (int i = -2; i < 3; i ++)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;

                vonalka.X1 = origoX-5;
                vonalka.Y1 = origoY+i*r/2;
                vonalka.X2 = origoX + 5;
                vonalka.Y2 = origoY + i * r / 2;

                Sinus.Children.Add(vonalka);
            }

        }
    }
}