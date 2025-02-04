namespace Ultrabalaton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("ub2017egyeni.txt");

            List <Adatok> adatok = new List <Adatok>();

            for (int i = 1; i < sorok.Length; i++)
            {
                adatok.Add(new Adatok(sorok[i]));
            }

            Console.WriteLine($"3.feladat: Egyéni indulók: {adatok.Count} fő");

            int nokSzama = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].kategoria == "Noi" && adatok[i].befSzazalek == 100)
                {
                    nokSzama++;
                }
            }
            Console.WriteLine($"4.feladat: Célba érkező női sportolók: {nokSzama} fő");

            Console.Write("5.feladat: Kérem a sportoló nevét: ");
            string bekertNev = Console.ReadLine();

            string uzenetIndulte = "Nem";
            string uzenetTeljesites = "Nem";

            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].nev == bekertNev)
                {
                    uzenetIndulte = "Igen";
                }

                if (adatok[i].befSzazalek == 100)
                {
                    uzenetTeljesites = "Igen";
                }

            }
            Console.WriteLine($"Indult-e egyéniben a sportoló? {uzenetIndulte}");
            Console.WriteLine($"Teljesítette a teljes távot? {uzenetTeljesites}");
        }
    }
}
