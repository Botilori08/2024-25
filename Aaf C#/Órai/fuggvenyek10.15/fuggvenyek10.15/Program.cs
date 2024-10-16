using System.Reflection.Metadata.Ecma335;

namespace fuggvenyek10._15
{
    internal class Program
    {

        static int osszead(int elsoSzam, int masodikSzam)
        {
            return elsoSzam + masodikSzam;
        }

        static double osszead(double elsoSzam, double masodikSzam)
        {
            return elsoSzam + masodikSzam;
        }

        static double oszt(int elsoSzam, int masodikSzam)
        {
            
            return (double)elsoSzam / (double)masodikSzam;
        }
        static double oszt(double elsoSzam, double masodikSzam)
        {

            return elsoSzam / masodikSzam;
        }

        // A paraméterként kapott egész számokat összeadja. Kiírja a végredményt.
        static void szumma(int[] szamok)
        {
            int osszeg = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
            }
            Console.WriteLine(osszeg);
        }


        static string szamkiiras(int szam)
        {
            string[] szamok = { "nulla","egy", "kettő", "három", "négy", "öt", "hat", "hét", "nyolc", "kilenc" };

            
            if (szam > szamok.Length)
            {
                return "Túl nagy!";
            }
            else
            {
                return szamok[szam];
            }
        }




        static void Main(string[] args)
        {
            //Console.Write("Kérem az első számot!: ");
            //int firstSzam = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Kérem a második számot!")

            Console.WriteLine(osszead(4, 4));
            Console.WriteLine(osszead(-1, 7));
            Console.WriteLine(osszead(2,3.5));
            Console.WriteLine();
            Console.WriteLine(oszt(2,1));
            Console.WriteLine(oszt(2, 2));
            Console.WriteLine(oszt(2, 4));
            Console.WriteLine(oszt(2.5, 1.2));

            Console.WriteLine();
            Console.WriteLine(szamkiiras(5));


            // készítsetek egy függyvényt ami kap egy egyjegyű pozitív számot, majd jelenítse meg szöveggel a nevét
            // Ha kilencnél nagyobb "Túl nagy"
            //2. feladat készítsetek egy függvényt ami az egyjegyű pozitív egész számot kap és kiírja szövegesen a nevét
        }
    }
}
