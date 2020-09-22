using System;
using ITESCIA_projects.Exo1;

namespace ITESCIA_projects
{
    class Program
    {
        static void Main(string[] args)
        {
             var article = new Article("video", 29.00);
             var disque = new Disque("Les Enfoirés", "Disque", 19.99);
            var  video = new Video(23.54, "Video", 39.99);
            article.Acheter();
            disque.Ecouter();
            video.Afficher();
        }
    }
}
