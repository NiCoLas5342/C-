using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Personnes
{
    class personne
    {
        private string nom;
        private string prenom;
        private int age;

        public personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            count ++;
        }
        private static int count
        {
            get;
            set;
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
        public void afficheUnePersonne()
        {
            Console.WriteLine("Nom : " + GetNom() +", Prenom : " + GetPrenom() + ", Age : " + GetAge());
        }

        public static int Combien()
        {
            return count;
        }
    }

}
