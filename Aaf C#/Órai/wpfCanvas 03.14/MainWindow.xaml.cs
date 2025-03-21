using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace wpfCanvas_03._14_
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

        DispatcherTimer timer = new DispatcherTimer();
        private void Vaszon_Loaded(object sender, RoutedEventArgs e)
		{
			/*
			Line myLine = new Line();
			myLine.Stroke = System.Windows.Media.Brushes.Red;
			myLine.X1 = 1;
			myLine.X2 = 50;
			myLine.Y1 = 6;
			myLine.Y2 = 40;
			myLine.HorizontalAlignment = HorizontalAlignment.Left;
			myLine.VerticalAlignment = VerticalAlignment.Center;
			myLine.StrokeThickness = 10;
			Vaszon.Children.Add(myLine);
			*/

            
			timer.Interval = TimeSpan.FromMilliseconds(4);
			//timer.Tick += korRajzol;
			//timer.Start();
			/*
            for (int i = 0; i < 36; i++)
			{
                kor(100, 100, 100, i*10);

            }*/

			szamlap(0, 0, 100);

			mutato(100, 100, "kismutato", 0, 50);
            mutato(100, 100, "nagymutato", 30, 80);
            mutato(100, 100, "masodpercmutato", 60, 95);
        }

		void mutato(int x, int y,string fajta,int szog,int hossz)
		{
            Line vonal = new Line();
            vonal.Stroke = Brushes.Black;

			switch(fajta)
			{
				case "kismutato":
                    vonal.Stroke = Brushes.Blue;
					vonal.StrokeThickness = 5;
                    break;
                case "nagymutato":
                    vonal.Stroke = Brushes.Green;
                    vonal.StrokeThickness = 2;
                    break;
                case "masodpercmutato":
                    vonal.Stroke = Brushes.Black;
                    vonal.StrokeThickness = 3;
                    break;
				default:
					vonal.Stroke = Brushes.Red;
					break;

            }

            double dY = hossz * Math.Sin(szog * Math.PI / 180.0);
            double dX = hossz * Math.Cos(szog * Math.PI / 180.0);


            vonal.X1 = x;
            vonal.Y1 = y;

            vonal.X2 = x+dX;
            vonal.Y2 = y+dY;

            Vaszon.Children.Add(vonal);
        }


		void szamlap(int X, int Y, int r)
		{
			Ellipse ellipse = new Ellipse();
			ellipse.Width = 2 * r;
			ellipse.Height = 2 * r;
			ellipse.Stroke = Brushes.Black;
			ellipse.StrokeThickness = 3;
			ellipse.Margin = new Thickness(X, Y, 0, 0);
			Vaszon.Children.Add(ellipse);

			for (int i = 0; i < 12; i++)
			{
				Line vonal = new Line();
				vonal.Stroke = Brushes.Black;


				double dY = r * Math.Sin(30 * i * Math.PI / 180.0);
				double dX = r * Math.Cos(30 * i * Math.PI / 180.0);

				double arany = 7/8.0;
				double arany2 = 8 / 8.0;


                double dY1 = arany * r * Math.Sin(30 * i * Math.PI / 180.0);
                double dX1 = arany*r* Math.Cos(30 * i * Math.PI / 180.0);

                double dY2 = arany2*r * Math.Sin(30 * i * Math.PI / 180.0);
                double dX2 = arany2*r* Math.Cos(30 * i * Math.PI / 180.0);

                vonal.X1 = X + dX1 + r;
                vonal.Y1 = Y + dY1 + r;

                vonal.X2 = X + dX2 + r;
                vonal.Y2 = Y + dY2 + r;

                Vaszon.Children.Add(vonal);
			}
		}


		int szogAllas = 0;



		void korRajzol(object sender, EventArgs e)
		{
            Vaszon.Children.Clear();
            kor(100, 100, 100, szogAllas * 10);
			

			szogAllas++;
			
			if(szogAllas >= 360)
			{
				szogAllas -= 360;
			}
        }

		void kor(int X,int Y,int sugar, int szog)
		{
			Ellipse ellipse = new Ellipse();
			ellipse.Width = 2 * sugar;
			ellipse.Height = 2 * sugar;
			ellipse.Stroke = Brushes.Turquoise;
			ellipse.StrokeThickness = 3;
			ellipse.Margin= new Thickness(X,Y,0,0);

			Vaszon.Children.Add(ellipse);
			
			Line vonal = new Line();
			vonal.Stroke = Brushes.Black;
			vonal.X1 = X+sugar;
			vonal.Y1 = Y+sugar;

			double dY = sugar*Math.Sin(szog*Math.PI/180.0);
			double dX = sugar * Math.Cos(szog * Math.PI / 180.0);

            vonal.X2 = X+dX+sugar;
			vonal.Y2 = Y + dY +sugar;
			Vaszon.Children.Add(vonal);

			//Hf: Keressünk olyan képletet vagy URL-t ami a koordinátás rajzolásra,vonalak szögek kapcsán
        }
	}
}