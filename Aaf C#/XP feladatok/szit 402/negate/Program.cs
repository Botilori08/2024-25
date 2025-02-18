namespace negate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot: ");

            int szam = Convert.ToInt32(Console.ReadLine());

            if(szam < 0)
            {
                Console.WriteLine("A megadott szám negatív");
            }
            else if(szam == 0)
            {
                Console.WriteLine("A szám nulla");
            }
            else
            {
                Console.WriteLine("A szám pozitív");
            }
        }
    }
}
