using System;
namespace ITESCIA_projects.Exo1
{
    public class Article
    {
        protected string Designation { get; set; }
        protected double Prix { get; set; }

        public Article(string Designation, double Prix) { this.Designation = Designation; this.Prix = Prix; }
        public void Acheter()
        {
            Console.WriteLine("Prix de l'article : " + Prix + ", designation : " + Designation);
        }

    }
}
