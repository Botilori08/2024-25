using System.ComponentModel;

namespace kraterek
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] sorok = File.ReadAllLines("felszin_tvesszo.txt");

			List <Krater> kraterek = new List <Krater>();

			for (int i = 0; i < sorok.Length; i++)
			{
				kraterek.Add(new Krater(sorok[i]));
			}

			Console.WriteLine("2. feladat");
			Console.WriteLine($"A kráterek száma: {kraterek.Count}");

			Console.WriteLine("3.feladat");
			Console.Write("Kérem egy kráter nevét: ");

			string bekert = Console.ReadLine();

			string kraterNeve = "Nincs ilyen nevű kráter.";

			for (int i = 0; i < kraterek.Count; i++)
			{
				if(bekert == kraterek[i].nev)
				{
					kraterNeve = kraterek[i].ToString();
				}
				
			}
            Console.WriteLine(kraterNeve);

            Console.WriteLine("4. feladat");

            Krater legnagyobb = kraterek[0];
            for (int i = 0; 1 < kraterek.Count; i++)
            {
                if (kraterek[i].r > legnagyobb.r)
                {
                    legnagyobb = kraterek[i];
                }
            }
            Console.WriteLine("A legnagyobb kráterek neve és sugara: {0} {1}", legnagyobb.nev, legnagyobb.r);

        }
    }
}
