namespace gyakorlas10._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int kitalalt = rand.Next(0, 10);
            Console.WriteLine("Gondoltam egy számra. Melyik lehet az?");



            int tipp = 0;

            while (tipp != kitalalt)
            {
                Console.Write("Tippelj: ");
                tipp = Convert.ToInt32(Console.ReadLine());

                if (tipp < kitalalt)
                {
                    Console.WriteLine("Túl kicsi. A számom nagyobb");
                }
                else if (tipp > kitalalt)
                {
                    Console.WriteLine("Túl nagy! A gondolt szám kisebb");
                }
                else
                {
                    Console.WriteLine("Eltaláltad!");
                    break;
                }
            }





            //Számkitalálós játék
            // 1. Változat: Gép gondol egy számra, találgatunk
            // Gép ad tippet 
            // 2.: felhasználó gondol egy számra és a gép találgat


        }
    }
}
