namespace maghang
{
	internal class Program
	{

		static int maganhangzoSzam(string szoveg)
		{
			int szam = 0;
			List<char> maganhangzok = new List<char>();

			char[] mgh = { 'a','A', 'á','Á', 'e','E', 'é','É', 'i','I','í','Í', 'o','O', 'ó','Ó', 'ö','Ö', 'ő','Ő', 'u','U', 'ú','Ú', 'ü','Ü', 'ű','Ű' };
			
			for (int i = 0; i < mgh.Length; i++)
			{
				maganhangzok.Add(mgh[i]); 
			}


			for(int i = 0;i < szoveg.Length; i++) 
			{
				if (maganhangzok.Contains(szoveg[i]))
				{
					szam++;
				}
			}

			return szam;
			
		}

		static void Main(string[] args)
		{
			Console.Write("Kérek egy szöveget: ");

			string bekertSzoveg = Console.ReadLine();

			Console.WriteLine("A megadott szövegben {0} magánhangzó van",maganhangzoSzam(bekertSzoveg));
		}
	}
}
