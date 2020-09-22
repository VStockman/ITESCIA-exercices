using System;
namespace ITESCIA_projects.Exo2
{
    public class Article2
    {
        protected string Nom;
        protected double Prix;
        protected int Quantite;

        public Article2(string Nom, double Prix, int Quantite) { this.Nom = Nom; this.Prix = Prix; this.Quantite = Quantite; }
        public void Afficher()
        {
            Console.WriteLine("Nom de l'article : " + Nom + ", prix de l'article : " + Prix + " , quantité : " + Quantite);
        }

        public void Ajouter(int nombre)
        {
            Quantite = Quantite + nombre;
            Console.WriteLine("Nouvelle quantité de " + Nom + " : " + Quantite);
        }

        public void Retirer(int nombre)
        {
            Quantite = Quantite - nombre;
            Console.WriteLine("Nouvelle quantité de " + Nom + " : " + Quantite);
        }

    }
}
