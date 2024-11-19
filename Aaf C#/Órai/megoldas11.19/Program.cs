using System;

namespace megoldas11._19
{
	internal class Program
	{
        static Random random = new Random();
        static void Main(string[] args)
		{
			
            beiro();
            Console.WriteLine();
            kiir();
            Console.WriteLine();
            kiir2();
            Console.WriteLine();
            kiir3();
            Console.WriteLine();
            kiir4();


            // HF: Még két féle kiírás
		}
		static void beiro()
		{

            Console.WriteLine("Kérek egy számot!");
            Console.Write("Sorok száma: ");
            int sorok = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oszlopok száma: ");
            int oszlopok = Convert.ToInt32(Console.ReadLine());

            StreamWriter ir = new StreamWriter("tablazat.csv");

            //Sorok beírása
            for (int k = 0; k < sorok; k++)
            {
                //Egy sor fájlba írása
                for (int i = 0; i < oszlopok; i++)
                {
                    ir.Write(random.Next(100, 1000));
                    //ir.Write(";");
                    if (i != oszlopok - 1)
                    {
                        ir.Write(';');
                    }
                }

                ir.WriteLine();
            }

            ir.Close();
        }
        static void kiir()
        {

            StreamReader olvas = new StreamReader("tablazat.csv");


            string tartalom = olvas.ReadToEnd();

            Console.WriteLine(tartalom);
            olvas.Close();

        }
        static void kiir2()
        {

            StreamReader olvas = new StreamReader("tablazat.csv");

            string sor = "";
            while (!olvas.EndOfStream)
            {
                sor = olvas.ReadLine();
                Console.WriteLine(sor);

            }


        }
        static void kiir3()
        {
            string[] sorok = File.ReadAllLines("tablazat.csv");

            for (int i = 0; i < sorok.Length;i++)
            {
                Console.WriteLine(sorok[i]);
            }
        }
        static void kiir4()
        {
            string sorok = File.ReadAllText("tablazat.csv");

            Console.WriteLine(sorok);
        }
    }
}
