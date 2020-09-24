using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteTableau
{
    class Chef : Employe
    {
        private string service;
        public Chef (string nom, string prenom, int age, decimal salaire, string service) : base(nom, prenom, age, salaire)
        {
            this.service = service;
        }

        public int GetService()
        {
            return service;
        }

        public override String ToString()
        {
            return ("Service :" + this.GetService());
        }

        public virtual void afficher()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
