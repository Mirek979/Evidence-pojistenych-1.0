using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nový_pokus
{
    class Databaze
    {
        private List<Zaznam> zaznamy;

        public Databaze()
        {
            zaznamy = new List<Zaznam>();
        }

        public void PridejZaznam(string jmeno, string prijemeni, int vek, int cislo)
        {
            zaznamy.Add(new Zaznam(jmeno, prijemeni, vek, cislo));
        }

        public List<Zaznam> NajdiZaznamy(string jmeno, string prijmeni)
        {
            List<Zaznam> nalezene = new List<Zaznam>();
            foreach (Zaznam z in zaznamy)
            {
                if ((z.Jmeno == jmeno) && (z.Prijemi == prijmeni))
                    nalezene.Add(z);
            }
            return nalezene;
        }
       public void VymazZaznam(string jmeno, string prijmeni)
        {
            List<Zaznam> nalezeno = NajdiZaznamy(jmeno, prijmeni);
            foreach (Zaznam z in nalezeno)
                zaznamy.Remove(z);
        }
     
            
       
    }
}
