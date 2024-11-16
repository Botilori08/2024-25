namespace gyakorlasaDogara
{
	internal class Program
	{

		static Random rand = new Random();

		static int[] random()
		{
            Console.WriteLine("Ha helyes számot adsz meg annyi darab random számot kapsz vissza");
            int szam = 1;
			while (szam %5!= 0 && szam %2!=0)
			{
				
                Console.Write("Kérek egy számot!");
				szam = Convert.ToInt32(Console.ReadLine());
            }

            int[] randomLista = new int[szam];
            for (int i = 0; i < randomLista.Length; i++)
            {
                randomLista[i] = rand.Next(-1000, 1000);
            }

            return randomLista;
        }
		static void Main(string[] args)
		{
			//Kérjünk be egy számot, majd ha öttel vagy kettővel osztható akkor annyi számot generáljunk random.Ezt írjuk ki és függvényben legyen
			int[] tomb = random();
			for (int i = 0; i < tomb.Length; i++)
			{
				Console.Write(tomb[i]+" ");
			}
		}
	}
}
