using System;
// REMPLACE LA CLASSE TESTPERSONNE
namespace Personnes
{
    class Program
    {
        static void Main(string[] args)
        {
            personne nicolas = new personne("Chanourdie", "Nicolas", 22);
            personne hugo = new personne("Test", "hugo", 19);
            Console.WriteLine("Personnes : "+personne.Combien());
        }
    }
}
