using System;
namespace ITESCIA_projects.Exo3
{
    public enum ArticleType { Alimentaire, Droguerie, Habillement, Loisir }

    public class Article3
    {
        

        protected string Nom;
        protected double Prix;
        protected int Quantite;
        protected ArticleType type;

        public Article3(string Nom, double Prix, int Quantite, ArticleType type) { this.Nom = Nom; this.Prix = Prix; this.Quantite = Quantite; this.type = type; }
        public void Afficher()
        {
            Console.WriteLine("Nom de l'article : " + Nom + ", prix de l'article : " + Prix + " , quantité : " + Quantite + ", type : " + type);
        }

        public void Ajouter(int nombre)
        {
            Quantite += nombre;
            Console.WriteLine("Nouvelle quantité de " + Nom + " : " + Quantite);
        }

        public void Retirer(int nombre)
        {
            Quantite -= nombre;
            Console.WriteLine("Nouvelle quantité de " + Nom + " : " + Quantite);
        }

    }
}
