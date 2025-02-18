namespace ketnagy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az első karaktersorozatot: ");
            string elso = Console.ReadLine();
            Console.Write("Kérem a második karaktersorozatot: ");
            string masodik = Console.ReadLine();


            if (elso.Length > masodik.Length)
            {
                Console.WriteLine("Az első karaktersorozat hosszabb.");
            }
            else if (masodik.Length > elso.Length)
            {
                Console.WriteLine("A második karaktersorozat hosszabb.");
            }
            else { Console.WriteLine("Egyenlő hosszúak."); }
        }
    }
}
