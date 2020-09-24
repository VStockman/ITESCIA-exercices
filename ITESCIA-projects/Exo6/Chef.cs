using System;
namespace ITESCIA_projects.Exo6
{
    public class Chef : Employe
    {
        public string Service;

        public Chef( string Nom, string Prenom, int Age, double Salaire, string Service) : base(Nom, Prenom, Age, Salaire) { this.Service = Service; }

        public override string ToString()
        {
            return $"Nom du chef : {Nom}, prénom du chef : {Prenom}, age du chef : {Age}, salaire du chef : {Salaire}, service du chef : {Service}";
        }

        public override void Afficher()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
