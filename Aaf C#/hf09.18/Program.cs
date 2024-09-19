namespace hf09._18
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Szorzótábla:");

			for (int k = 1;k <=10;k++)
			{
				Console.WriteLine("");
                for (int elso = 1; elso <= 10; elso++)
                {
                    Console.Write(k * elso + ";");
                }
            }
			
		}
	}
}
