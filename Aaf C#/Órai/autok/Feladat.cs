using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace autok_01._07
{
	internal class Feladat
	{
		List<Adatok> autok = new List<Adatok>();
		
		public Feladat() {
			feladat1();
			feladat2();
			feladat3();
			feladat4();
			feladat5();
		}
		void feladat1()
		{
			string[] sorok = File.ReadAllLines("jeladas.txt");

			for (int i = 0; i < sorok.Length; i++)
			{
				autok.Add(new Adatok(sorok[i]));
			}
        }
		void feladat2()
		{
			Console.WriteLine("2.feladat");
			Console.WriteLine($"Az utolsó jeladás időpontja {autok[autok.Count-1].ora}-{autok[autok.Count - 1].perc}, a jármű rendszáma {autok[autok.Count - 1].rendszam}");
		}

		void feladat3()
		{
			Console.WriteLine("3.feladat:");
			Console.WriteLine($"Az első jármű: {autok[0].rendszam}");
			Console.Write("Jeladásainak időpontja: ");
			for (int i = 0; i < autok.Count; i++)
			{
				if(autok[i].rendszam == autok[0].rendszam)
				{
					Console.Write(autok[i].ido()+" ");
				}
			}
			Console.WriteLine();
		}

		void feladat4()
		{
            Console.WriteLine("4.feladat");
            Console.Write("Kérem adja meg az órát: ");
			int ora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a percet: ");
            int perc = Convert.ToInt32(Console.ReadLine());

			int darabszam = 0;
			for (int i = 0;i < autok.Count;i++)
			{
				if (autok[i].check(ora, perc))
				{
					darabszam++;
				}
			}
            Console.WriteLine($"A jeladások száma: {darabszam}");
        }

		void feladat5()
		{
            /*5.feladat: 
			A legnagyobb sebesség km/ h: 154
			A járművek: XQE - 678 PAL - 958*/

            Console.WriteLine("5.feladat");

			int legnagyobb = 0;

			for (int i = 0; i < autok.Count; i++)
			{
				if (autok[i].sebesseg > legnagyobb)
				{
                    legnagyobb = autok[i].sebesseg ;
				}
			}

            Console.WriteLine($"A legnagyobb sebesség km/ h: {legnagyobb}");
			Console.Write("A járművek: "); 


            for (int i = 0; i < autok.Count; i++)
			{
				if (legnagyobb == autok[i].sebesseg)
				{
					Console.Write(autok[i].rendszam+" ");
				}
			}
        }

		void feladat6()
		{
            Console.WriteLine("6.feladat");
            Console.Write("Kérem a rendszámot: ");
            string rendszam = Console.ReadLine();

			for (int i = 0; i < autok.Count; i++)
			{

			}

        }

	}
}
