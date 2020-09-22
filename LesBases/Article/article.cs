using System;
using System.Collections.Generic;
using System.Text;

namespace Article
{
    class article
    {
        protected string nom;
        protected int prix;
        protected int quantite;
        
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
            Console.WriteLine(" Nom :"+ this.GetNom() +", Prix : "+ this.GetPrix() +", Quantite : "+ this.GetQuantite());
        }
        public void Ajouter(int number)
        {
            this.SetQuantite(this.GetQuantite + number);
        }

        public void Retirer( int number)
        {
            this.SetQuantite(this.GetQuantite - number);
        }
    }
}
