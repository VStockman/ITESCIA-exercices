using System;
using System.Collections.Generic;
using System.Text;

namespace ITESCIA_projects.Exo6
{
    class Liste
    {
        private Element _Debut;
        private readonly Element[] arr = new Element[100];

        public void RemplirTableau()
        {
            Element debut = _Debut;
            if (debut != null)
            {
                int i = 0;
                arr[i] = debut;
                while (debut.Suivant != null)
                {
                    debut = debut.Suivant;
                    i++;
                    arr[i] = debut;
                }
            }
        }

        public Element this[int i]
        {
            get => arr[i];
            set => arr[i] = value;
        }

        public int NbElements { get; private set; }

        public Liste()
        {
            _Debut = null;
            NbElements = 0;
        }
        public void InsererDebut(object premier_objet)
        {
            Element newDebut = new Element(premier_objet)
            {
                Suivant = _Debut
            };
            _Debut = newDebut;
            NbElements++;
            RemplirTableau();
        }

        public void InsererFin(object dernier_objet)
        {
            Element newFin = new Element(dernier_objet);
            if (_Debut == null)
            {
                _Debut = newFin;
                NbElements++;
                return;
            }
            Element dernierElement = RecupereDernierElement();
            dernierElement.Suivant = newFin;
            NbElements++;
            RemplirTableau();
        }

        public Element RecupereDernierElement()
        {
            Element surf = _Debut;
            while (surf.Suivant != null)
            {
                surf = surf.Suivant;
            }
            return surf;
        }

        public void Lister()
        {
            Element debut = _Debut;
            if (debut != null)
            {
                string cumul = debut.Objet.ToString();
                while (debut.Suivant != null)
                {
                    debut = debut.Suivant;
                    cumul += "," + debut.Objet.ToString();
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
            _Debut = null;
            NbElements = 0;
            RemplirTableau();
        }

    }

    class Element
    {
        public object Objet { get; set; }
        public Element Suivant { get; set; }

        public Element(object objet)
        {
            Objet = objet;
            Suivant = null;
        }
    }
}