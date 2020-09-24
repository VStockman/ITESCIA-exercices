using System;
namespace ITESCIA_projects.Exo1
{
    public class Video : Article
    {
        protected double Duree;
        public double MaDuree
        {
            get { return Duree; }
            set { Duree = value; }
        }
        public Video(double Duree, string Designation, double Prix) : base(Designation, Prix) { MaDuree = Duree; }

        public void Afficher()
        {
            Console.WriteLine("Durée de la vidéo : " + Duree);
        }
    }
}
