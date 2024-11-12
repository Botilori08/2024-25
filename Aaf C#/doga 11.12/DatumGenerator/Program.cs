namespace DatumGenerator
{
	internal class Program
	{

		static Random rand = new Random();

		static string datumos(string[] honap,int[] nap)
		{
			int honapszam =  rand.Next(0,13);

			int meddig = 0;
			for (int i = 0; i < nap.Length; i++)
			{
				meddig = nap[i];
			}


			int generaltNap = rand.Next(0,meddig);
			string Honap =  honap[honapszam];

			string Nap = Convert.ToString(generaltNap);

			string vissza = "."+Honap + "." + Nap;


			return vissza;
		}

		static string evhozzaad(string HoNap)
		{
			int evszam = rand.Next(1920,2024);
			int karakterPos = HoNap.IndexOf("e");

			return Convert.ToString(evszam)+HoNap;
		}
		static void Main(string[] args)
		{
			string[] honapnevek = { "Január", "Február", "Március", "Április", "Május", "Június", "Július", "Augusztus", "Szeptember", "Október", "November", "December" };

			int[] napszamok = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };



			Console.Write("Kérek egy 10 és 100 közötti egész számot");
			int bekert = 0;
			while (bekert > 0)
			{
				bekert = Convert.ToInt32(Console.ReadLine());
				if (bekert < 10)
				{
					Console.WriteLine("Túl kicsi a szám!");

                    bekert = Convert.ToInt32(Console.ReadLine());
                }

                if (bekert > 100)
                {
                    Console.WriteLine("Túl kicsi a szám!");

                    bekert = Convert.ToInt32(Console.ReadLine());
                }
				if (bekert > 10 && bekert < 100)
				{
					break;
				}
            }
			string[] generalt = new string[bekert];

			for (int i = 0; i < generalt.Length; i++)
			{
				generalt[i] = evhozzaad(datumos(honapnevek, napszamok));

            }



			
			//Console.ReadLine
		}
	}
}
