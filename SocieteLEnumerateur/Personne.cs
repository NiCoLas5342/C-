using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteListe
{
    class Personne
    {
        private string nom;
        private string prenom;
        private int age;

        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public string GetNom()
        {
            return nom;
        }

        public string GetPrenom()
        {
            return prenom;
        }

        public int GetAge()
        {
            return age;
        }
        public Personne()
        {

        }
        public override String ToString()
        {
            return ("Nom :" + this.GetNom());
        }

        public virtual void afficher()
        {
            Console.WriteLine(this.ToString());
        }

        public static Personne operator ++(Personne pers)
        {
            pers.age++;
        }
    }
}
