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
			origoY = (int)(Sinus.ActualHeight / 2);
			pontok.Add(new Point(origoX, origoY));

			int szog = 200;

			koordinataRendszer();
			//feketeKor(0);
			//pirosvonal(0);
			feketeKor(szog);

			pirosvonal(szog);

			//sugar(0);
			sugar(szog);

			kekKor(szog);
			szinuszGorbe(szog);

			koriv(szog);
			korivKicsi(szog);

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

			for (int i = 45; i < 500; i += 45)
			{
				Line vonalka = new Line();
				vonalka.Stroke = Brushes.Black;

				vonalka.X1 = i + origoX;
				vonalka.Y1 = origoY - 5;
				vonalka.X2 = i + origoX;
				vonalka.Y2 = origoY + 5;

				Sinus.Children.Add(vonalka);


			}

			for (int i = -2; i < 3; i++)
			{
				Line vonalka = new Line();
				vonalka.Stroke = Brushes.Black;

				vonalka.X1 = origoX - 5;
				vonalka.Y1 = origoY + i * r / 2;
				vonalka.X2 = origoX + 5;
				vonalka.Y2 = origoY + i * r / 2;

				Sinus.Children.Add(vonalka);
			}

		}

		void feketeKor(int x)
		{
			Ellipse kor = new Ellipse();
			kor.Width = r / 10;
			kor.Height = r / 10;
			kor.Margin = new Thickness(origoX + x - kor.Width / 2, origoY - kor.Height / 2, 0, 0);

			kor.Stroke = Brushes.Black;
			kor.Fill = Brushes.Black;

			Sinus.Children.Add(kor);
		}

		void pirosvonal(int x)
		{
			double magassag = Math.Sin(x / 180.0 * Math.PI) * r;

			Line v = new Line();
			v.Stroke = Brushes.Red;
			v.StrokeThickness = 3;

			v.X1 = origoX + x;
			v.Y1 = origoY;
			v.X2 = origoX + x;
			v.Y2 = origoY - magassag;

			Sinus.Children.Add(v);

		}

		void sugar(int x)
		{
			double dX = Math.Cos(x / 180.0 * Math.PI) * r;
			double magassag = Math.Sin(x / 180.0 * Math.PI) * r;

			Line v = new Line();
			v.Stroke = Brushes.Black;
			v.StrokeThickness = 3;

			v.X1 = origoX + x;
			v.Y1 = origoY - magassag;
			v.X2 = origoX + x - dX;
			v.Y2 = origoY;

			Sinus.Children.Add(v);

		}

		void kekKor(int x)
		{
			double dX = Math.Cos(x / 180.0 * Math.PI) * r;
			Ellipse kor = new Ellipse();
			kor.Stroke = Brushes.Blue;
			kor.StrokeThickness = 1;
			kor.Width = 2 * r;
			kor.Height = 2 * r;

			kor.Margin = new Thickness(origoX + x - dX - r, origoY - r, 0, 0);

			Sinus.Children.Add(kor);

		}


		PointCollection pontok = new PointCollection();
		void szinuszGorbe(int x)
		{
			double magassag = Math.Sin(x / 180.0 * Math.PI) * r;

			pontok.Add(new Point(x + origoX, origoY - magassag));

			Polyline vonal = new Polyline();

			vonal.Stroke = Brushes.Red;
			vonal.StrokeThickness = 3;

			vonal.Points = pontok;

			Sinus.Children.Add(vonal);



		}

		void koriv(int x)
		{
            double dX = Math.Cos(x / 180.0 * Math.PI) * r;
            double magassag = Math.Sin(x / 180.0 * Math.PI) * r;
            Path path = new Path();


			path.Stroke = Brushes.Blue;
			path.StrokeThickness = 3;
			//path.Fill = Brushes.Red;


			PathGeometry pathGeometry = new PathGeometry();
			PathFigure figure = new PathFigure();
			figure.StartPoint = new Point(origoX+x-dX+r, origoY);

			ArcSegment arc = new ArcSegment();
			arc.Point = new Point(x+origoX, origoY-magassag);
			arc.Size = new Size(r, r);
            arc.SweepDirection = SweepDirection.Counterclockwise;
            arc.IsLargeArc = x>180;

            figure.Segments.Add(arc);
			pathGeometry.Figures.Add(figure);
			path.Data = pathGeometry;

			Sinus.Children.Add(path);
		}

        void korivKicsi(int x)
        {
            double dX = Math.Cos(x / 180.0 * Math.PI) * r;
            double magassag = Math.Sin(x / 180.0 * Math.PI) * r;
            
			Path path = new Path();


            path.Stroke = Brushes.Blue;
            path.StrokeThickness = 1;
            //path.Fill = Brushes.Red;


            PathGeometry pathGeometry = new PathGeometry();

			/*
            vX1 = origoX + x;
            v.Y1 = origoY - magassag;
            v.X2 = origoX + x - dX;
            v.Y2 = origoY;
			*/

			double x1 = origoX + x - dX;
			double y1 = origoY;
			double x2 = origoX + x;
			double y2 = origoY -magassag;

			double x3 = x1-(x1 - x2)/10;
			double y3 = y1-(y1 - y2)/10;

            PathFigure figure = new PathFigure();
            figure.StartPoint = new Point(origoX + x - dX + r/10.0, origoY);

            ArcSegment arc = new ArcSegment();
            arc.Point = new Point(x3,y3);
            arc.Size = new Size(r*0.1, r*0.1);
            arc.SweepDirection = SweepDirection.Counterclockwise;
            arc.IsLargeArc = x > 180;

            figure.Segments.Add(arc);
            pathGeometry.Figures.Add(figure);
            path.Data = pathGeometry;

            Sinus.Children.Add(path);
        }

    }
}