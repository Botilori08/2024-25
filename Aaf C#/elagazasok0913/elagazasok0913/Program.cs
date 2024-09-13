namespace elagazasok0913
{
	internal class Program
	{
		static void Main(string[] args)
		{


			int kitalaltszam = 12;

			Console.Write("Kérek egy egész számot! ");

			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.BackgroundColor = ConsoleColor.Blue;

			kitalaltszam = Convert.ToInt32(Console.ReadLine());
			Console.ResetColor();


			if (kitalaltszam > 10)
			{
				Console.WriteLine("A szám nagyobb tíznél!");
			}
			else if (kitalaltszam < 10)
			{
				Console.WriteLine("A szám kisebb tíznél!");
			}

			if (kitalaltszam%2 == 0)
			{
				Console.WriteLine("Páros");
			}
			else
			{
				Console.WriteLine("Páratlan");
			}
			// 4,5,6 osztható-e Vagy csak 5-6-tal

			if (kitalaltszam %4 == 0 && kitalaltszam %5 == 0 && kitalaltszam%6 ==0 )
			{
				Console.WriteLine("A szám osztható 4-gyel 5-tel 6-tal");
			}
			else if (kitalaltszam%5 == 0 && kitalaltszam%6 ==0 )
			{
				Console.WriteLine("5, 6-tal");
			}
			else if (kitalaltszam%4 ==0 )
			{
				Console.WriteLine("A szám 4-gyel osztható");
			}
			else if (kitalaltszam%5 == 0)
			{
				Console.WriteLine("A szám 5-tel osztható");
			}
            else if (kitalaltszam % 6 == 0)
            {
                Console.WriteLine("A szám 6-tal osztható");
            }
			else
			{
				Console.WriteLine("nem osztható se 4-gyel, se 5-tel, se 6-tal");
			}
        }
	}
}
