﻿namespace robot
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
        }
	}
}
