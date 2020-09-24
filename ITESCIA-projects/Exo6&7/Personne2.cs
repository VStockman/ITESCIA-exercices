using System;
namespace ITESCIA_projects.Exo6
{
    public class Personne2
    {
        protected string Nom;
        protected string Prenom;
        protected int Age;

        public Personne2(string Nom, string Prenom, int Age) { this.Nom = Nom; this.Prenom = Prenom; this.Age = Age; }
        public Personne2() { }

        public override string ToString()
        {
            return $"Nom de la personne : {Nom}, prénom de la personne : {Prenom}, age de la personne : {Age}";
        }

        public virtual void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

        public static Personne2 operator ++(Personne2 personne)
        {
            personne.Age ++;
            return personne;
        }
    }
}
