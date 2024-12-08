namespace Hf12._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ikarus ikarus260 = new Ikarus("260", "1971-2002", 72547);

            Ikarus ikarus256 = new Ikarus("256", "1974-2002", 23290);

            Ikarus ikarusC56 = new Ikarus("C56", "1998-2002", 399);

            Ikarus ikarus280 = new Ikarus("280", "1973-2003", 60993);

            Ikarus ikarus415 = new Ikarus("415", "1987-2002", 1042);

            Console.WriteLine($"-----------Ikarus {ikarus260.tipus}----------");
            Console.WriteLine($"Gyártották: {ikarus260.gyartasIdo}");
            Console.WriteLine($"Darabszám: {ikarus260.darabszam} db");

            Console.WriteLine();

            Console.WriteLine($"-----------Ikarus {ikarus256.tipus}----------");
            Console.WriteLine($"Gyártották: {ikarus256.gyartasIdo}");
            Console.WriteLine($"Darabszám: {ikarus256.darabszam} db");

            Console.WriteLine();

            Console.WriteLine($"-----------Ikarus {ikarusC56.tipus}----------");
            Console.WriteLine($"Gyártották: {ikarusC56.gyartasIdo}");
            Console.WriteLine($"Darabszám: {ikarusC56.darabszam} db");


            Console.WriteLine();
            Console.WriteLine($"-----------Ikarus {ikarus280.tipus}----------");
            Console.WriteLine($"Gyártották: {ikarus280.gyartasIdo}");
            Console.WriteLine($"Darabszám: {ikarus280.darabszam} db");

            Console.WriteLine();
            Console.WriteLine($"-----------Ikarus {ikarus415.tipus}----------");
            Console.WriteLine($"Gyártották: {ikarus415.gyartasIdo}");
            Console.WriteLine($"Darabszám: {ikarus415.darabszam} db");






        }
    }
}
