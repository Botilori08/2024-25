using System.Text;

namespace file_kezeles_dolgozat
{
	internal class Program
	{
		static StreamReader reader = new StreamReader("kod_B.txt");
		static void Main(string[] args)
		{
			string kod = reader.ReadLine();

			Console.WriteLine(kod);

			string kodok = reader.ReadToEnd();

			string[] tomb = kodok.Split("\n");

			int[] ujtomb = new int[tomb.Length];
			for (int i = 0; i < tomb.Length; i++)
			{
				for (int j = 0; j < ujtomb.Length; j++)
				{
					ujtomb[j] = int.Parse(tomb[i]);
				}
				
			}

			for (int i = 0; i < ujtomb.Length; i++)
			{
				Console.WriteLine(ujtomb[i]);
			}

			
		}
	}
}
