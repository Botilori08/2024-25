namespace Hf_09._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat");
            Console.WriteLine("Hárommal osztható háromjegyű számok:");

            Console.WriteLine("1. megoldás:");
            for (int i = 99; i <=999;i++)
            {
                if (i %3 ==0)
                {
                    Console.Write(i+";");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("2. megoldás:");
            for (int i = 99;i<1000;i+=3)
            {
                Console.Write(i+";");
            }

            Console.WriteLine("");
            Console.WriteLine("2. feladat");
            for (char betu = 'A';betu <= 'Z';betu++)
            {
                Console.Write(betu + ";");
            }

        }
    }
}
