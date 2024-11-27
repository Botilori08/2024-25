namespace GyakorlasDogara2
{
	internal class Program
	{
		static Random rand = new Random();
		static StreamWriter writer = new StreamWriter("gyak.txt");

		static int[] szamGeneral(int darab,int alsoH,int felsoH)
		{

			int[] szamok = new int[darab];
			for (int i = 0;i < szamok.Length;i++)
			{
				szamok[i] = rand.Next(alsoH,felsoH);
			}

			return szamok;
		}
		static void Main(string[] args)
		{

			Console.Write("Hány számot szeretnél? ");
			int darabszam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mennyi legyen a generálás alsó határa? ");
            int aHatar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mennyi legyen a generálás felső határa? ");
            int fHatar = Convert.ToInt32(Console.ReadLine());

            int[] tomb = szamGeneral(darabszam, aHatar, fHatar);


			for (int i = 0; i < tomb.Length; i++)
			{
				writer.Write(tomb[i]+";");
			}


			writer.Close();

		}
	}
}
