using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._13_Titanic_OOP
{
    internal class utasok
    {
        public string kategoria;
        public int tulelok;
        public int eltuntek;

        public utasok(string sor)
        {
            string[] vagas = sor.Split(';');
            // minta sor: gyerekek-masodosztaly;24;0
            vagas[0] = kategoria;
            tulelok = Convert.ToInt32(vagas[1]);
            eltuntek = Convert.ToInt32(vagas[2]);

        }

    }
}