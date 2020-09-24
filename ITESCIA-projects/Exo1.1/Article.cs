using System;
namespace ITESCIA_projects.Exo1
{
    public class Article
    {
        protected string Designation;
        public string MaDesignation
        {
            get { return Designation; }
            set { Designation = value; }
        }
        protected double Prix;
        public double MonPrix
        {
            get { return Prix; }
            set { Prix = value; }
        }

        public Article(string Designation, double Prix) { this.MaDesignation = Designation; this.MonPrix = Prix; }
        public void Acheter()
        {
            Console.WriteLine("Prix de l'article : " + Prix + ", designation : " + Designation);
        }

    }
}
