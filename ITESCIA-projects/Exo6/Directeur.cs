using System;
namespace ITESCIA_projects.Exo6
{
    public class Directeur : Chef
    {
        protected string Societe;

        public Directeur(string Nom, string Prenom, int Age, double Salaire, string Service, string Societe) : base(Nom, Prenom, Age, Salaire, Service) { this.Societe = Societe; }

        public override string ToString()
        {
            return $"Nom du directeur : {Nom}, prénom du directeur : {Prenom}, age du directeur : {Age}, salaire du directeur : {Salaire}, service du directeur : {Service}, societe du directeur : {Societe}";
        }

        public override void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
