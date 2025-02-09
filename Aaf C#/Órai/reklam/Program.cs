using System;
using System.Collections.Generic;
using System.IO;

namespace reklam;

internal class Program
{
    static List<Rendeles> rendelesek = new List<Rendeles>();


    static void Main(string[] args)
    {
        string[] sorok = File.ReadAllLines("rendel.txt");

        for (int i = 0; i < sorok.Length; i++)
        {
            rendelesek.Add(new Rendeles(sorok[i]));
        }

        Console.WriteLine("2.feladat:");
        Console.WriteLine($"A rendelések száma: {rendelesek.Count}");


        Console.WriteLine("3.feladat:");
        Console.Write("Kérem, adjon meg egy napot: ");

        int bekertSzam = Convert.ToInt32(Console.ReadLine());

        int darab = 0;

        for (int i = 0; i < rendelesek.Count; i++)
        {
            if (bekertSzam == rendelesek[i].nap)
            {
                darab++;
            }
        }

        Console.WriteLine($"A rendelések száma az adott napon: {darab}");

        int darab2 = 0;
        for (int i = 1; i < 31; i++)
        {
            darab = 0;
            for (int j = 0; j < rendelesek.Count; j++)
            {
                if (i == rendelesek[j].nap && rendelesek[j].varos == "NR")
                {
                    darab++;
                }
            }

            if (darab == 0)
            {
                darab2++;
            }
        }

        int[] szamolo = new int[31];
        for (int i = 0; i < rendelesek.Count; i++)
        {
            if (rendelesek[i].varos == "NR")
            {

                szamolo[rendelesek[i]]++;
            }
        }
        darab2 = 0;
        for (int i = 1; i < szamolo.Length; i++)
        {
            if (szamolo[i] == 0)
            {
                darab2++;
            }
        }
        Console.WriteLine($"4. feladat:\r\n{darab2} nap nem volt a reklámban nem érintett városból rendelés");


        int MaxIndex = 0;
        for (int i = 0; i < rendelesek.Count; i++)
        {
            if (rendelesek[i].darab > rendelesek[MaxIndex].darab)
            {
                MaxIndex = i;
            }
        }
        Console.WriteLine("5. feladat:\r\nA legnagyobb darabszám: {rendelesek[MaxIndex]}, a rendelés napja: {}");



    }
    static int osszes(string varos, int nap)
    {
        int darab = 0;
        for (int i = 0; i < rendelesek.Count; i++)
        {
            if (rendelesek[i].varos == varos && rendelesek[i].nap == nap)
            {
                darab++;
            }
        }
        return darab;
    }
}
