namespace bes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy karakersorozatot: ");

            string karakterS = Console.ReadLine();

            int Bszam = 0;

            for (int i = 0; i < karakterS.Length; i++)
            {
                if (karakterS[i] == 'b' || karakterS[i] == 'B')
                {
                    Bszam++;
                }
            }

            if (Bszam > 0)
            {
                Console.WriteLine($"A karaktersorozatban {Bszam} db 'b' betű van.");
            }
            else
            {
                Console.WriteLine("Nincs 'b' betű a karaktersorozatban");
            }
        }
    }
}
