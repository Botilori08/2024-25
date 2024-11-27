using System.Runtime.Serialization.Formatters;

namespace cbradio
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] adatok = File.ReadAllLines("cb.txt");

			int[,] idok = new int[adatok.Length - 1, 2];
			int[] adasok = new int[adatok.Length - 1];
			string[] nevek = new string[adatok.Length - 1];


			for (int i = 1; i < adatok.Length; i++)
			{
				string[] vag = adatok[i].Split(';');
				idok[i - 1,0] = int.Parse(vag[0]);
				idok[i - 1,1] = int.Parse(vag[1]);

				adasok[i - 1] = Convert.ToInt32(vag[2]);
				nevek[i - 1] = vag[3];
			}

			Console.WriteLine($"3.feladat: Bejegyzések száma: {nevek.Length} darab");

			//Vagy: Console.WriteLine("3. feladat: Bejegyzések száma: {0} db", nevek.Length);

			Console.Write("4.feladat: ");

			bool voltIlyen = false;

			for (int i = 0; i < adasok.Length; i++)
			{
				if (adasok[i]==4)
				{
					voltIlyen = true;
					break;
				}
			}


			voltIlyen = false;
			for (int i = 0; i < adasok.Length && !voltIlyen; i++)
			{
				voltIlyen |= adasok[i] == 4;
			}
			   
			
				
			if (voltIlyen == true)
			{
				Console.Write("Volt négy adást indító sofőr.");
			}
			else {
				Console.Write("Nem volt négy adást indító sofőr.");
			}


			Console.Write("5.feladat: Kérek egy nevet: ");
			string bekertNev = Console.ReadLine();
			int hivasSzam = 0;

            for (int i = 0;	i < nevek.Length;i++)
			{
				if (nevek[i]== bekertNev)
				{
					hivasSzam += adasok[i];
				}
			}

			if (hivasSzam > 0)
			{
                Console.WriteLine($"{bekertNev} {hivasSzam}x használta a CB rádiót");
            }
			else
			{

			}

			
			





		}
	}
}
