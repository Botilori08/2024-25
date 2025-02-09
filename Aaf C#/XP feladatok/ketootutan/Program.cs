namespace ketootutan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("dolgozok.txt");

            List <Dolgozo> dolgozok = new List <Dolgozo>();

            for (int i = 1; i <= sorok.Length; i++)
            {
                dolgozok.Add(new Dolgozo(sorok[i]));
            }


        }
    }
}
