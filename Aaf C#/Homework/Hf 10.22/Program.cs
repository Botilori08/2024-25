namespace Hf_10._22
{
	internal class Program
	{
		static void Main(string[] args)
		{


			Console.WriteLine("1.feladat");

			Random rand = new Random();
			int[] randomlista = new int[10];


			for (int i = 0; i < randomlista.Length; i++)
			{
				randomlista[i] = rand.Next(0,2000);
			}

			for (int i = 0;i < randomlista.Length; i++)
			{
				Console.Write(randomlista[i]+", ");
			}
			
			Console.WriteLine();
			Console.WriteLine("2.feladat");

			Console.Write("Kérek egy számot: ");
			int elsoSzam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérek egy számot: ");
            int masodikSzam = Convert.ToInt32(Console.ReadLine());
			
			
			int[,] lista = new int[elsoSzam,masodikSzam];


			for (int i = 0; i < lista.GetLength(0);i++)
			{
                for (int j = 0; j < lista.GetLength(1); j++)
                {

					lista[i,j] = rand.Next(100, 1000);
                }

			}

			foreach (int i in lista)
			{
                Console.WriteLine(i);
            }

			Console.WriteLine();
			Console.WriteLine("3. feladat");

			Console.Write("Mennyi legyen a lista elemszáma? ");
			int darabszam = Convert.ToInt32(Console.ReadLine());

			int[] szamLista = new int[darabszam];

			for (int i = 0;i < szamLista.Length;i++)
			{
				szamLista[i] = rand.Next(-300, 300);
			}
			foreach (int i in szamLista)
			{
				Console.Write(i + " ");
			}




			}
	}
}
