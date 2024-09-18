namespace hazi09._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.feladat Egytől százig minden egész számot kiírni
            int szam = 0;

            Console.WriteLine("1.feladat");
            while (szam != 100)
            {
                szam++;
                Console.Write(szam.ToString() + ";");
            }
            Console.WriteLine("");


            //2. feladat egytől százig minden kétjegyű szám visszafelé
            Console.WriteLine("2.feladat");

            for (int i = 99; i > 10; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            //3.feladat kiírni egytől százig minden második számot
            Console.WriteLine("3.feladat");
            for (int i = 1; i < 100; i += 2)
            {
                Console.Write(i.ToString() + ";");
            }

            Console.WriteLine("");
            //4. feladat kérjen be egy számot addig amíg nem tizet írunk 
            Console.WriteLine("4.feladat");
            int bekertszam = 0;
            while (bekertszam != 10)
            {
                Console.Write("Kérek egy egész számot!: ");
                bekertszam = Convert.ToInt32(Console.ReadLine());
                if (bekertszam == 10)
                {
                    break;
                }
            }



        }
    }
}