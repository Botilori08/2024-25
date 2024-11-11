namespace gyakorlasaDogara
{
    internal class Program
    {

        static Random rand = new Random();
        static void Main(string[] args)
        {
            //Kérjünk be egy számot, mennyi legyen a lista elemszáma, ami két random szám között generál random számot, ezt függvénnyel.

            int szam = rand.Next(rand.Next(20, 30), rand.Next(700, 1000));

            Console.WriteLine(szam);
        }
    }
}
