namespace gyak10._25
{
	internal class Program
	{
		static Random rand = new Random();
		static int haromjegyu()
		{
			
			int haromjegyuszam = rand.Next(100, 1000);
			return haromjegyuszam;
		}

        /*
		* 012 058 098 007
		* 100 189 157
		* 254 221 223
		* 359 368 379
		* */
        static int[,] matrix()
		{
			int[,] visszaadott = new int[10, 10];
			for (int i = 0;i < visszaadott.GetLength(0);i++)
			{
				for (int j = 0;j < visszaadott.GetLength(1);j++)
				{
					visszaadott[i, j] = rand.Next();
				}
			}

			return visszaadott;
		}

		static void Main(string[] args)
		{
			Random rand = new Random();
			int haromjegyuszam = rand.Next(100, 1000);



			int[] szazszam = new int[100];

			for (int i = 0; i < 100; i++)
			{
				szazszam[i] = haromjegyu();
			}

			for (int i = 0; i < szazszam.Length; i++)
			{
				Console.WriteLine(szazszam[i]);
			}



		}
	}
}
