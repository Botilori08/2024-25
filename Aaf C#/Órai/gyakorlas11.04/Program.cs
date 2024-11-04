namespace gyakorlas11._04
{
	internal class Program
	{
		static Random rand = new Random();

		static int veletlenSzam()
		{
			return rand.Next(50,500) * 2;
			// 2-vel való szorzás -> mindenképpen osztható lesz kettővel
		}


		static int[] veletlenSzamok(int darab)
		{
			int[] visszaadott = new int[darab];
			for (int i = 0; i < visszaadott.Length;i++)
			{
				visszaadott[i] = veletlenSzam();
			}

				return visszaadott;
		}

		static void tombkiiro(int[] tomb)
		{
			for (int i = 0; i< tomb.Length;i++)
			{
				Console.WriteLine(tomb[i]);
			}
		}

		static int randomSzam(int szamjegySzama, int oszto)
		{
			
            return rand.Next(50, 500) * 2;
        }


		static void Main(string[] args)
		{
			//1. Készítsünk egy programot ami véletlen számokat generál egy tömbbe ezt visszaadja. 3 jegyű páros számokat
			//2. adott számjegyű számot, adott számmal oszthatót


			tombkiiro(veletlenSzamok(8));



		}
	}
}
