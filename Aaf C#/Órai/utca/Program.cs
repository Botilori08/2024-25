// See https://aka.ms/new-console-template for more information

using utca;

string[] sorok = File.ReadAllLines("kerites.txt");

List <Telek> telkek = new List<Telek>();

int parosDb = 0;



for (int i = 0; i < sorok.Length; i++)
{
    telkek.Add(new Telek(sorok[i]));

    if (telkek[telkek.Count - 1].paros )
    {
        parosDb++; 
        telkek[telkek.Count - 1].hazszam = parosDb * 2;
    }
    else
    {
        telkek[telkek.Count - 1].hazszam = (telkek.Count - parosDb)-1;
    }


}

Console.WriteLine($"2. feladat \nAz eladott telkek száma: {telkek.Count}");
Console.WriteLine();
Console.WriteLine($"3. feladat");
Console.WriteLine(telkek[telkek.Count-1 ]);


