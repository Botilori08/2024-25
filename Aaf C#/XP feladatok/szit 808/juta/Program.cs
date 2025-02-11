namespace juta_2nd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1;Gyenge Tamás;Fekete Eszter;Kisvárda;Dugovics Titusz utca u.19;420000;5000;2002-04-15;1958-11-02;Kisvárda

            string[] adatok = File.ReadAllLines("dolgozok.txt");

            List <string> adatL = new List<string>();

            for(int i = 0; i < adatok.Length; i++)
            {
                adatL.Add(adatok[i]);
            }

            int jutalmak = 0;
            for (int i = 0; i < adatL.Count; i++)
            {
                jutalmak += Convert.ToInt32(adatL[i].Split(";")[6]);
            }
            Console.WriteLine("1.feladat");
            Console.WriteLine($"Jutalmak összege: {jutalmak} Ft");

            List <int> fizetesek = new List<int>();

            for(int i = 0;i < adatL.Count;i++)
            {
                fizetesek.Add(Convert.ToInt32(adatL[i].Split(";")[5]));
            }

            int osszFizetes = 0;
            for (int i = 0;i < fizetesek.Count;i++)
            {
                osszFizetes += fizetesek[i];
            }

            Console.WriteLine("2.feladat");
            Console.WriteLine($"A fizetések átlaga: {osszFizetes/fizetesek.Count}");


            bool recskiek = false;
            for (int i = 0; i < adatL.Count; i++)
            {
                if (adatL[i].Split(";")[3] == "Recsk")
                {
                    recskiek = true;
                    break;
                }
                else 
                {
                    recskiek = false;
                }
            }

            Console.WriteLine("3.feladat");
            if (recskiek)
            {
                Console.WriteLine("Van recski dolgozó");
            }
            else
            {
                Console.WriteLine("Nincs recski dolgozó");
            }

            int tataiak = 0;
            Console.WriteLine("4.feladat");

            for(int i = 0;i <adatL.Count;i++)
            {
                if (adatL[i].Split(";")[3] == "Tata")
                {
                    tataiak++;
                }

            }
            Console.WriteLine($"Tatai dolgozók száma: {tataiak}");

        }
    }
}
