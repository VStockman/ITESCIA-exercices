using System;
namespace ITESCIA_projects.Exo6
{
    public class Employe : Personne2
    {
        public double Salaire;

        public Employe(string Nom, string Prenom, int Age, double Salaire) : base(Nom,Prenom, Age) { this.Salaire = Salaire; }


        public override string ToString()
        {
            return $"Nom de l'employe : {Nom}, prénom de l'employe : {Prenom}, age de l'employe : {Age}, salaire de l'employe : {Salaire}";
        }

        public override void Afficher()
        {
             Console.WriteLine(this.ToString());
        }

    }
}
