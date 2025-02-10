namespace juta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("dolgozok.txt");

            List <Dolgozo> dolgozok = new List <Dolgozo> ();

            for(int i = 0; i < sorok.Length; i++)
            {
                dolgozok.Add(new Dolgozo(sorok[i]));
            }

            Console.WriteLine("1.");
            int osszJutalom = 0;
            for (int i = 0;i < dolgozok.Count;i++)
            {
                osszJutalom += dolgozok[i].jutalom;
            }
            Console.WriteLine($"A jutalmak összege: {osszJutalom}");

            Console.WriteLine("2.");
            List <int> fizetesek = new List <int> ();

            for (int i = 0; i < dolgozok.Count; i++)
            {
                fizetesek.Add(dolgozok[i].fizetes);
            }

            int osszFizetes = 0;
            for(int i = 0;i < fizetesek.Count ; i++)
            {
                osszFizetes += fizetesek[i];
            }
            Console.WriteLine($"A fizetések átlaga: {osszFizetes/fizetesek.Count}");

            Console.WriteLine("3.");
            bool vizsgalat = false;
            for (int i = 0;i < dolgozok.Count ; i++)
            {
                if (dolgozok[i].telepules == "Recsk")
                {
                    vizsgalat = true;
                    break;
                }
                else
                {
                    vizsgalat = false;
                }
            }

            if(vizsgalat)
            {
                Console.WriteLine("Van recski dolgozó.");
            }
            else
            {
                Console.WriteLine("Nincs recski dolgozó.");
            }

            Console.WriteLine("4.");
        }
    }
}
