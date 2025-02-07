using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reklam
{
    internal class Rendeles
    {
        public int nap;
        public string varos;
        public int darab;

        public Rendeles(string sor)
        {
            string[] vag = sor.Split(" ");
            nap = Convert.ToInt32(vag[0]);
            varos = vag[1];
            darab = Convert.ToInt32(vag[2]);
        }
    }
}
