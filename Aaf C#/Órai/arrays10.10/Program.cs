namespace arrays10._10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] szamLista = new int[6];


			int szamlalo = 1;
			for (int i = 0; i < szamLista.Length; i++)
			{
				Console.Write("Kérem a(z) " + szamlalo+ ". számot!: ");
                szamlalo++;
                szamLista[i] = Convert.ToInt32(Console.ReadLine());
				

			}

			Console.WriteLine();
			foreach (int i in szamLista)
			{
				Console.Write(i+", ");
			}

			Console.Write("Kérek egy számot ");
            int elso = Convert.ToInt32(Console.ReadLine());


		}
	}
}
