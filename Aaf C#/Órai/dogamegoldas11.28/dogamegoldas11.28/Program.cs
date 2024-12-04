namespace dogamegoldas11._28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] szavak = File.ReadAllLines("kod_B.txt");
            string kulcsSzo = szavak[0]+"\n\r";

            StreamWriter ir = new StreamWriter("megoldasB.txt");
            for (int i = 1; i < szavak.Length; i++)
            {
                ir.Write(kulcsSzo[Convert.ToInt32(szavak[i])]);
            }
            ir.Close();


            string megoldas = "";
            szavak = File.ReadAllLines("kodszavak_A.txt");
            string[] kodok = File.ReadAllLines("kod_A.txt");

            for (int i = 1;i < kodok.Length; i++)
            {
                megoldas+=(szavak[Convert.ToInt32(kodok[i])]+" ");
            }

            megoldas = megoldas.Replace(" 66","!").Replace(" 81 ","\n").Replace(" 42",",");
            File.WriteAllText("megoldasA.txt", megoldas);
        }
    }
}
