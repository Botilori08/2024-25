namespace ketootutan
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] sorok = File.ReadAllLines("dolgozok.txt");

			List <Dolgozo> dolgozok = new List <Dolgozo>();

			
			for (int i = 1; i == sorok.Length; i++)
			{
				dolgozok.Add(new Dolgozo(sorok[i]));
			}

			Console.WriteLine("2005 után érkezett dolgozók (név:nettó fizetés)");

			for (int i = 0; i < dolgozok.Count; i++)
			{
				Console.WriteLine(dolgozok[i].Ev());
			}

			/*
			for (int i = 0; i < nevek.Count; i++)
			{
                Console.Write(nevek[i]);
            }
			for (int j = 0; j < fizetesek.Count; j++)
			{
				Console.Write($":{fizetesek[j]} Ft");
			}
				*/

			

		}
	}
}
