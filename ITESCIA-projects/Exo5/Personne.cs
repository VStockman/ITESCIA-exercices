using System;
namespace ITESCIA_projects.Exo5
{
    public class Personne : IDisposable
    {
        protected string Nom;
        protected string Prenom;
        protected int Age;
        private static int NbPersonnes = 0;

        public Personne(string Nom, string Prenom, int Age) { this.Nom = Nom; this.Prenom = Prenom; this.Age = Age; NbPersonnes++; }

        public void Afficher()
        {
            Console.WriteLine($"Nom de la personne : {Nom}, prénom de la personne : {Prenom}, age de la personne : {Age}");
        }

        public void Combien()
        {
            Console.WriteLine($"Nombre de personnes créees : {NbPersonnes}");
        }

        public void Dispose()
        {
            NbPersonnes--;
        }
    }
}
