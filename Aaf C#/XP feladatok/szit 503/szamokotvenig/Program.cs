using System.ComponentModel;

namespace szamokotvenig
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Első módszer:");

            for (int i = 0; i < 51; i++)
            {
                Console.Write(i+";");
                if (i == 50)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Második módszer:");
            int szam = 0;
            while (szam < 50)
            {
                szam++;
                Console.Write(szam+";");

                if(szam == 50)
                { 
                    Console.Write(szam);
                }
            }

        }
    }
}
