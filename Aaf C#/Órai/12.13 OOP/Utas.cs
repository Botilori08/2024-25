using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._13
{
    internal class Utas
    {
        public int sorszam;
        public string felszallas;
        public int kartyaAzon;
        public string tipus;
        public string ervenyes;
        public int jegyDarab;

        public Utas(string sor)
        {
            string[] vag = sor.Split(' ');

            sorszam = Convert.ToInt32(vag[0]);
            felszallas = vag[1];
            kartyaAzon = Convert.ToInt32((vag[2]));
            tipus = vag[3];

            if (vag[4].Length == 8)
            {
                ervenyes = vag[4];
                jegyDarab = -1;
            }
            else
            {
                ervenyes = "";
                jegyDarab = Convert.ToInt32(vag[4]);
            }

        }


    }
}
