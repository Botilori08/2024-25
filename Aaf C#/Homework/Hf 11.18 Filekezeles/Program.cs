namespace Hf_11._18_Filekezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter iro = new StreamWriter("tablazat.csv");

            
            Random rand = new Random();
            Console.Write("Hány oszlopból álljon a táblázat? ");
            int oszlopok = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány sorból álljon a táblázat? ");
            int sorok = Convert.ToInt32(Console.ReadLine());

            for (int k = 0; k < sorok; k++)
            {
                for (int i = 0; i < oszlopok; i++)
                {
                    iro.Write(rand.Next(0, 500));
                    iro.Write(";");
                }
            }
 

            iro.Close();

        }
    }
}
