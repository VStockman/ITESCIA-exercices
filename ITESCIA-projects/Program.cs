using System;
using ITESCIA_projects.Exo1;
using ITESCIA_projects.Exo2;

namespace ITESCIA_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exo 1 :");
             var article = new Article("video", 29.00);
             var disque = new Disque("Les Enfoirés", "Disque", 19.99);
            var  video = new Video(23.54, "Video", 39.99);
            article.Acheter();
            disque.Ecouter();
            video.Afficher();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exo 2 :");
            var article2 = new Article2("Manga", 19.99, 2);
            var article3 = new Article2("La reine des neiges", 29.99, 1);
            article2.Afficher();
            article3.Afficher();
            article2.Retirer(1);
            article3.Ajouter(2);
            Console.WriteLine("Tapez le nom de l'article :");
            string title = Console.ReadLine().ToString();
            Console.WriteLine("Tapez le prix de l'article :");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tapez la quantité de l'article :");
            int quantity = Convert.ToInt16(Console.ReadLine());
            var articleUser = new Article2(title, price, quantity);
            articleUser.Afficher();
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
