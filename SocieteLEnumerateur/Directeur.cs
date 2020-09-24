using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteListe
{
    class Directeur
    {
        private string Societe;

        public string Societe
        {
            get => Societe;
            set => Societe = value;
        }

        public Directeur(string nom, string prenom, int age, decimal salaire, string service, string societe) : base(nom, prenom, age, salaire, service)
        {
            Societe = societe;
        }

        override
        public string ToString()
        {
            return ("SOCIETE :" + this.GetSociete());
        }

        override
        public void Afficher()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
