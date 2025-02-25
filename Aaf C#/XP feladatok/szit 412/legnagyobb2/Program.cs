namespace legnagyobb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("Első megoldás:");

            Console.Write("Kérem az első számot!: ");
            int elsoSzam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérem a második számot!: ");
            int masodikSzam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérem az harmadik számot!: ");
            int harmadikSzam = Convert.ToInt32(Console.ReadLine());

            List <int> szamLista = new List <int>();

            szamLista.Add(elsoSzam);
            szamLista.Add(masodikSzam);
            szamLista.Add (harmadikSzam);

            szamLista.Sort();

            Console.WriteLine($"A legnagyobb szám: {szamLista[szamLista.Count-1]}");


            Console.WriteLine("Második megoldás:"); 

            

            Console.Write("Kérem az első számot!: ");
            int Szam1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérem a második számot!: ");
            int Szam2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérem az harmadik számot!: ");
            int Szam3 = Convert.ToInt32(Console.ReadLine());

            int[] szamok = {Szam1,Szam2,Szam3};

            Console.WriteLine(szamok.Max());


        }
    }
}
