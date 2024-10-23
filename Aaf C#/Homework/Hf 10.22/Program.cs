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
			/*
			Console.WriteLine();
			Console.WriteLine("2.feladat");

			Console.Write("Kérek egy számot: ");
			int elsoSzam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérek egy számot: ");
            int masodikSzam = Convert.ToInt32(Console.ReadLine());
			
			
			int[,] lista = ;


			for (int i = 0; i < elsoSzam;i++)
			{
                lista[0, i] = rand.Next(100, 1000);
                for (int j = 0; j < masodikSzam; j++)
                {

					lista[1,j] = rand.Next(100, 1000);
                }

			}

			foreach (int i in lista)
			{
                Console.WriteLine(i);
            }
			*/





			}
	}
}
