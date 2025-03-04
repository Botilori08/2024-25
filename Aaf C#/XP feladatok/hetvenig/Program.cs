namespace hetvenig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boti Lóránt, 2025");
            for (int i = 20; i < 70; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i+"-");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
