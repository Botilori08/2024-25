namespace belepteto
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] sorok = File.ReadAllLines("bedat.txt");

			List <Belepes> belepesek =new List<Belepes> ();

			for (int i = 0; i < sorok.Length; i++)
			{
				belepesek.Add(new Belepes(sorok[i]));
			}

			Console.WriteLine("2.feladat");
			Console.WriteLine($"Az első tanuló {belepesek[0].idopont}-kor lépett be a főkapun.");
			Console.WriteLine($"Az utolsó tanuló {belepesek[belepesek.Count-1].idopont}-kor lépett ki a főkapun.");

			Console.WriteLine("4.feladat");
			int ebed = 0;
			for (int i = 0; i < belepesek.Count; i++)
			{
				if (belepesek[i].mitCsinalt == 3)
				{
					ebed++;
				}
			}

			
			Console.WriteLine($"A menzán aznap {ebed} tanuló ebédelt.");

			Console.WriteLine("5.feladat");
			int konyvtar = 0;
			string aktualis = "";
			for (int i = 0; i < belepesek.Count; i++)
			{
				if (belepesek[i].tanuloKod != aktualis && belepesek[i].mitCsinalt==4)
				{
					konyvtar++;
				}

			}

			Console.WriteLine($"Aznap {konyvtar} tanuló kölcsönzött a könyvtárban.");
			if (konyvtar > ebed)
			{
				Console.WriteLine("Többen voltak, mint a menzán.");
			}
			else
			{
				Console.WriteLine("Nem voltak többen, mint a menzán.");
			}

		}
	}
}
