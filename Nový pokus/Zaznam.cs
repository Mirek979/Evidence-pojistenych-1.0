using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nový_pokus
{
     class Zaznam
    {
        public string Jmeno { get; set; }
        public string Prijemi { get; set; }
        public int Vek { get; set; }
        public int Cislo { get; set; }

        public Zaznam(string jmeno, string prijemi, int vek, int cislo)
        {
            Jmeno = jmeno;
            Prijemi = prijemi;
            Vek = vek;
            Cislo = cislo;
        }
        public override string ToString()
        {
            return Jmeno + " " + Prijemi + " " + Vek + " " + Cislo;
        }


    }
}
