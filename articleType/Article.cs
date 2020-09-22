using System;
using System.Collections.Generic;
using System.Text;

namespace articleType
{
    class article
    {
        protected string nom;
        protected int prix;
        protected int quantite;
        protected articleType type;

        public article()
        {
            this.nom = nom;
            this.prix = prix;
            this.quantite = quantite;
            this.type = type;
        }

        protected articleType GetArticleType()
        {
            return type;
        }

        protected void SetArticleType(articleType value)
        {
            this.type = value;
        }

        public string GetNom()
        {
            return nom;
        }

        public int GetPrix()
        {
            return prix;
        }

        public int GetQuantite()
        {
            return quantite;
        }

        protected void SetPrix(int value)
        {
            this.prix = value;
        }

        protected void SetQuantite(int value)
        {
            this.quantite = value;
        }

        public void Afficher()
        {
            Console.WriteLine(" Nom :" + this.GetNom() + ", Prix : " + this.GetPrix() + ", Quantite : " + this.GetQuantite() + " Type : "+ this.GetArticleType());
        }
        public void Ajouter(int number)
        {
            this.SetQuantite(this.GetQuantite + number);
        }

        public void Retirer(int number)
        {
            this.SetQuantite(this.GetQuantite - number);
        }
    }
}
