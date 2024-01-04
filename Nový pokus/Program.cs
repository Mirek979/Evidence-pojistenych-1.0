// See https://aka.ms/new-console-template for more information


using Nový_pokus;

Diar diar = new Diar();
char volba = '0';

while (volba != '4')
{
    Console.Clear();
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Evidence pojištěných");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat záznam");  
    Console.WriteLine("2 - Vyhledej pojištěného");
    Console.WriteLine("3 - Vymazat pojištěného");

    Console.WriteLine("4 - Konec");
    volba = Console.ReadKey().KeyChar;
    Console.WriteLine();
    
    switch (volba)
    {
        case '1':
            diar.PridejZaznam();
            break;      

        case '2':
            diar.VyhledejZaznamy();
               break;
        case '3':
            diar.VymazZaznam();
            break;
      
        case '4':
            Console.WriteLine("Libovolnou klávesou ukončíte program...");
            break;
        default:
            Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
            break;
    }
    Console.ReadKey();
}




