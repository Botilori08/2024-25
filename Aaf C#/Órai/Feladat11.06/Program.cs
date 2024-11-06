using System.ComponentModel;

namespace Feladat11._06
{
    internal class Program
    {
        static Random rand = new Random();
        static int[] Randomszam()
        {
            Console.Write("Mettől sorsoljak számokat? ");
            int alsoH = Convert.ToInt32(Console.ReadLine());
            Console.Write("Meddig sorsoljak számokat? ");
            int felsoH = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány számot sorsoljak? ");
            int darab = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            int[] szamok = new int[darab];


            for (int i = 0; i < szamok.Length; i++)
            {
                int szam = rand.Next(alsoH, felsoH);
                szamok[i] = szam;
            }
            return szamok;
        }
        static void Main(string[] args)
        {

            int[] Alista = Randomszam();
            for (int i = 0;i < Alista.Length; i++)
            {
                Console.Write(Alista[i]+" ");
            }
        
        }

    }
}
