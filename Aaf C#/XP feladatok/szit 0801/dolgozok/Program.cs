namespace dolgozok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("dolgozok.txt");

            int[] penzek = new int[adatok.Length];


            for (int i = 0; i < adatok.Length; i++)
            {
                string[] vago = adatok[i].Split(":");
                penzek[i] = Convert.ToInt32(vago[4]);                
            }

            int osszeg = 0;

            for (int i = 0;i < penzek.Length;i++)
            {
                osszeg += penzek[i];
            }

            Console.WriteLine($"A dolgozók fizetéseinek összege: {osszeg} Ft");


        }
    }
}
