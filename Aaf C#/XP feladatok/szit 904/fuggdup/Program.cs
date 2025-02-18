namespace ConsoleApp1
{
    internal class Program
    {

        static int dupla(int szam)
        {
            return szam * 2;
        }
        static void Main(string[] args)
        {

            Console.Write("Kérek egy számot: ");
            int bekertSzam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A megadott szám duplája: {dupla(bekertSzam)}");

        }
    }
}
