namespace robot
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] sorok = File.ReadAllLines("progs.txt");

			List <Adatok> programok = new List <Adatok>();

			for (int i = 0; i < sorok.Length; i++)
			{
				programok.Add(new Adatok(sorok[i]));
			}

            Console.WriteLine($"2. feladat: Tanulók száma: {programok.Count} fő");

            
            int szamlalo = 0;
			for (int i = 0; i < programok.Count; i++)
			{
				if (programok[i].hibas())
				{
					szamlalo++;
				}
			}

            Console.WriteLine($"3. feladat: Helytelen kódsorozatok száma: {szamlalo}");

			StreamWriter ir = new StreamWriter("ivsz.txt");

			for (int i = 0; i < programok.Count; i++)
			{
				if (!programok[i].hibas())
				{
					ir.Write(programok[i].nev);
					ir.WriteLine(programok[i].iranyvaltasok());
				}

			}

			ir.Close();
        }
    }
}
