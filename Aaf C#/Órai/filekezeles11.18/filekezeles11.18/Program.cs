namespace filekezeles11._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter ir = new StreamWriter("proba.txt");

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                ir.Write(rand.Next(10,100));
                ir.Write("\t");

                if (i%10 == 9)
                {
                    ir.WriteLine();
                }
            }

            ir.Close();
        }
    }
}
