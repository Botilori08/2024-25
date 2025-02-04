using park;

internal class Program
{
	static void Main(string[] args)
	{
		string[] sorok = File.ReadAllLines("felajanlas.txt");

		List<Adatok> felajanlasok = new List<Adatok>();

		int agyasDb = int.Parse(sorok[0]);

		for (int i = 1; i < sorok.Length; i++)
		{
			felajanlasok.Add(new Adatok(sorok[i],i));
		}

		Console.WriteLine("2. feladat:");

		Console.WriteLine($"A felajánlások száma: {felajanlasok.Count}");

		Console.WriteLine();

		//A bejárat mindkét oldalán ültetők: 10 34 98 107 115 142 156 160 340 360 378
		Console.WriteLine("3. feladat:");
		Console.Write("A bejárat mindkét oldalán ültetők: ");

		for(int i = 0; i < felajanlasok.Count; i++)
		{
			if (felajanlasok[i].kapuKetOldal)
			{
				Console.Write(felajanlasok[i].sorszam + " ");
			}
		}
		Console.WriteLine();
		Console.WriteLine("4. feladat:");

		//4. feladat
		Console.Write("Adja meg az ágyás sorszámát! ");

		int agyas = int.Parse(Console.ReadLine());
		int szamlalo = 0;

		string szin = "#";
		List <string> szinek = new List<string>();

		for (int i = 0; i < felajanlasok.Count; i++)
		{
			if (felajanlasok[i].benneVanEz(agyas))
			{

				szamlalo++;
				if(szamlalo == 1)
				{ 
					szin = felajanlasok[i].szin;
				}

				if(!szinek.Contains(felajanlasok [i].szin))
				{
                    szinek.Add(felajanlasok[i].szin);
                }
				
			}
		}
		Console.WriteLine($"A felajánlások száma: {szamlalo}");
        Console.WriteLine($"A virágágyás színe, ha csak az első ültet: {szin}");

        Console.WriteLine("A virágágyás színei: {0}",String.Join(" ",szinek));



    }
}