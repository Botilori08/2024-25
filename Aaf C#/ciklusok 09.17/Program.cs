namespace ciklusok_09._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            int szam = 1;
            while (szam <= 10)
            {
                Console.WriteLine(szam);
                szam++;
            }


            Console.WriteLine();

            for (int k = 1; k < 10; k++)
            {
                Console.WriteLine(k+1);
            }

            Console.WriteLine();

            for (int k = 10; k > 0;k--)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine();

            for (int k = 10; k > 0; k--)
            {
                Console.WriteLine(11-k);
            }

            Console.WriteLine();

            for (int k = 1; k <= 10; k++)
            {
                Console.WriteLine(11-k);
            }

            Console.WriteLine();
            //prímtényezők
            Console.Write("Kérek egy egész számot!:");
            int egyszam = 0;
            egyszam = Convert.ToInt32(Console.ReadLine());

            int oszto = 2;

            while (egyszam > 1)
            {
                if (egyszam % oszto == 0)
                {
                    Console.WriteLine(oszto);
                    egyszam /= oszto;
                }
                else
                {
                    oszto++;
                }
            }
            
        }
    }
}
