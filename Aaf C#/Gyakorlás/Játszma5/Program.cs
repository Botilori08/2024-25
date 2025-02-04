namespace Játszma5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("labdamenetek5.txt");

            List <Adatok> lista = new List<Adatok>();

            for (int i = 0; i < adatok.Length; i++)
            {
                lista.Add(new Adatok(adatok[i]));
            }

            Console.WriteLine($"3.feladat: Labdamenetek száma: {lista.Count}");
        }
    }
}
