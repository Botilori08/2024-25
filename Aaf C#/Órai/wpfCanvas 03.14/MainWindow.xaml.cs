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

		private void Vaszon_Loaded(object sender, RoutedEventArgs e)
		{
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

			kor(100,100,100, 0);
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
            vonal.X2 = X+sugar*2;
			vonal.Y2 = Y + sugar ;
			Vaszon.Children.Add (vonal);

			//Hf: Keressünk olyan képletet vagy URL-t ami a koordinátás rajzolásra,vonalak szögek kapcsán
        }
	}
}