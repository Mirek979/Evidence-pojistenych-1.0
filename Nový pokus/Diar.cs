using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nový_pokus
{
     class Diar
    {
        private Databaze databaze;

        public Diar()
        {
            databaze = new Databaze();
        }   
        public void PridejZaznam()
        {
            Console.WriteLine("Zadejte jméno");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadejte telefonní číslo :");
            int cislo = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte věk :");
            int vek = int.Parse(Console.ReadLine());

            databaze.PridejZaznam(jmeno, prijmeni, cislo, vek);

                }
        /*public void VypisZaznamy(string jmeno, string prijmeni)
        {
            List<Zaznam> zaznamy = databaze.NajdiZaznamy(jmeno,prijmeni);
            foreach (Zaznam zaznam in zaznamy)
                Console.WriteLine(zaznam);
        }*/
        public void VyhledejZaznamy()
        {
            Console.WriteLine("Zadej jméno: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadej příjemní: ");
            string prijmeni = Console.ReadLine();
            List<Zaznam> zaznamy = databaze.NajdiZaznamy(jmeno, prijmeni);
            if (zaznamy.Count()>0)
            {
                Console.WriteLine("Nalezeny tyto osoby: ");
                foreach(Zaznam z in zaznamy)
                    Console.WriteLine(z);
            }
            else Console.WriteLine("Nebylo nic nalezeno!");

        }
        public void VymazZaznam()
        {
            Console.WriteLine("!!Bude  vymazán záznam!!");
            Console.WriteLine("Zadejte jméno: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení: ");
            string prijmeni = Console.ReadLine();

            databaze.VymazZaznam(jmeno, prijmeni);
            Console.WriteLine("Záznam byl úspěšně vymazán!");
        }
    }
}
