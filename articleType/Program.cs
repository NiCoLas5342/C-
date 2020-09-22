using System;
using System.Runtime.Intrinsics.X86;

namespace artycleType

{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciation
            Article produit1 = new Article("pull", 20, 40, ArticleType.habillement);
            Article produit2 = new Article("football", 90, 120, ArticleType.loisir);

            Article[] articles = new Article[]
            {
                produit1,
                produit2,
            };

            //Affichage
            Console.WriteLine("Affichage de tous les produits créés s");
            produit1.afficher();
            produit2.afficher();

            //Affichage du tableau
            Console.WriteLine("Affichage de tous les produits ");
            foreach (Article art in articles)
            {
                art.afficher();
                art.ajouter(40);
                art.afficher();
            }




        }
    }
}