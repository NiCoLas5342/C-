using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteListe.ListeChainee
{
    class Liste
    {
        private Element _Debut;
        private int _NbElements;

        //CONSTRUCTEUR
        public Liste()
        {
            _Debut = null;
            _NbElements = 0;
        }

        private Element[] arr = new Element[100];
        public void fillArray()
        {
            Element un_element = this._Debut;
            if (un_element != null)
            {
                int i = 0;
                arr[i] = un_element;
                while (un_element.suivant != null)
                {
                    un_element = un_element.suivant;
                    i++;
                    arr[i] = un_element;
                }
            }
        }
        public void InsererDebut(Object premier_objet)
        {
            Element newDebut = new Element(premier_objet);
            newDebut.suivant = this._Debut;
            this._Debut = newDebut;
            this._NbElements++;
            fillArray();
        }

        public Element RecupereDernierElement()
        {
            Element fin = this._Debut;
            while (fin.suivant != null)
            {
                fin = fin.suivant;
            }
            return fin;
        }

        public void InsererFin(Object dernier_objet)
        {
            Element newFin = new Element(dernier_objet);
            if (this._Debut == null)
            {
                this._Debut = newFin;
                this._NbElements++;
                return;
            }
            Element dernierElement = RecupereDernierElement();
            dernierElement.suivant = newFin;
            this._NbElements++;
            fillArray();
        }

        public void Lister()
        {
            Element un_element = this._Debut;
            if (un_element != null)
            {
                string cumul = un_element._objet.ToString();
                while (un_element.suivant != null)
                {
                    un_element = un_element.suivant;
                    cumul += "," + un_element._objet.ToString();
                }
                Console.WriteLine(cumul);
            }
            else
            {
                Console.WriteLine("La liste est vide");
            }
        }

        public void Vider()
        {
            this._Debut = null;
            this._NbElements = 0;
            fillArray();
        }

    }

    class Element
    {
        //CHAMPS
        protected Object _object;
        protected Element suivant;
        // PROPRIETE
        public Object _objet 
        {
            get => _objet; 
            set => _objet = value; 
        }
        public Element suivant 
        {
            get => suivant; 
            set => suivant = value; 
        }
        // CONSTRUCTEUR
        public Element (Object un_object)
        {
            object = un_object;

        }
    }
}
