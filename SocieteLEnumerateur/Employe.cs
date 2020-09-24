using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteListe
{
    class Employe : Personne
    {
        private decimal salaire;
        public Employe(string nom, string prenom, int age, decimal salaire) : base(nom, prenom, age)
        {
            this.salaire = salaire;
        }

        public int GetSalaire()
        {
            return salaire;
        }

        public override String ToString()
        {
            return ("Salaire :" + this.GetSalaire());
        }

        public virtual void afficher()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
