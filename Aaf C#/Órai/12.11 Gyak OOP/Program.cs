﻿using _12._11_Gyak_OOP;

internal class Program
{
	private static void Main(string[] args)
	{
		Buksza b = new Buksza(2000);

		Console.WriteLine(b.Penz);
		
		Console.WriteLine(b.szin);

		Buksza b2 = new Buksza(20000, "barna");

		Console.WriteLine(b2.szin);
		Console.WriteLine();
		Console.WriteLine(b2);

	}
}