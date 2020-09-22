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
//EXO 2 
            //Affichage
            Console.WriteLine("Affichage de tous les produits créés");
            produit1.afficher();
            produit2.afficher();


            Console.WriteLine("Entrez un nom de produit :");
            string articleName = Console.ReadLine();

            Console.WriteLine("Entrez le prix du produit :");
            int articlePrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez la quantité de produit :");
            int articleQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le type de produit  : Alimentaire, Droguerie, Habillement, Loisir ;");
            string articleType = Console.ReadLine();
            ArticleType enumArticleType = ArticleType.autre;

            switch (articleType.ToLower())
            {
                case "alimentaire":
                    enumArticleType = ArticleType.alimentaire;
                    break;
                case "droguerie":
                    enumArticleType = ArticleType.droguerie;
                    break;
                case "habillement":
                    enumArticleType = ArticleType.habillement;
                    break;
                case "loisir":
                    enumArticleType = ArticleType.loisir;
                    break;
                default:
                    break;
            }

            Article userArticle = new Article(articleName, articlePrice, articleQuantity, enumArticleType);
            userArticle.afficher();

            Console.WriteLine("Voulez-vous ajouter une quantité ou en retirer? (ADD/DELETE) :");
            string choice = Console.ReadLine();



            if (choice.ToUpper() == "ADD")
            {
                Console.WriteLine("Quantité a ajouter ?");
                int quantityToAdd = int.Parse(Console.ReadLine());
                userArticle.ajouter(quantityToAdd);
                userArticle.afficher();
            }
            else
            {
                Console.WriteLine("Quantité aretirer ?");
                int quantityToRemove = int.Parse(Console.ReadLine());
                userArticle.retirer(quantityToRemove);
                userArticle.afficher();
            } 
//EXO 3 
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
