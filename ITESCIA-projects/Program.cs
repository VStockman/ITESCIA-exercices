﻿using System;
using ITESCIA_projects.Exo1;
using ITESCIA_projects.Exo2;
using ITESCIA_projects.Exo3;
using ITESCIA_projects.Exo5;
using ITESCIA_projects.Exo6;

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
            Console.WriteLine("Exo 3 :");
            var article4 = new Article3("Raviolis", 3.99, 1, ArticleType.Alimentaire);
            var article5 = new Article3("PS5", 499.99, 1, ArticleType.Loisir);
            article4.Afficher();
            article5.Afficher();
            Console.WriteLine("Tapez le nom de l'article :");
            string title2 = Console.ReadLine().ToString();
            Console.WriteLine("Tapez le prix de l'article :");
            double price2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tapez la quantité de l'article :");
            int quantity2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Tapez le type de l'article (Alimentaire, Droguerie, Habillement, Loisir) :");
            ArticleType type = (ArticleType)Enum.Parse(typeof(ArticleType), Console.ReadLine().ToString(), true);
            var articleUser2 = new Article3(title2, price2, quantity2, type);
            articleUser2.Afficher();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exo 4 :");
            Article3[] articlesArray = new Article3[3];
            articlesArray[0] = article4;
            articlesArray[1] = article5;
            articlesArray[2] = articleUser2;
            for(int i = 0; i < articlesArray.Length; i++)
            {
                articlesArray[i].Afficher();
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exo 5 :");
            Personne personne = new Personne("Valentin", "Stockman", 25);
            Personne personne1 = new Personne("Mickey", "Mouse", 35);
            personne.Afficher();
            personne1.Afficher();
            personne.Combien();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exo 6 :");
            Employe e1 = new Employe("Valentin", "Stockman", 25, 3000);
            Employe e2 = new Employe("Mickey", "Mouse", 35, 2000);
            Employe e3 = new Employe("Employe", "Employe", 20, 1600);
            Employe e4 = new Employe("Employe2", "Employe2", 30, 2400);

            Chef c1 = new Chef("Chef 1", "nom Chef 1", 33, 3000, "Marketing");
            Chef c2 = new Chef("Chef 2", "nom Chef 2", 30, 3200, "Informatique");
            Directeur d = new Directeur("Jean", "Charles", 38, 4500, "R&D", "ITESCIA");
            e1.Salaire = 5000;
            c1.Service = "Comptabilite";
            Personne2[] personnesArray = new Personne2[7];
            personnesArray[0] = e1;
            personnesArray[1] = e2;
            personnesArray[2] = e3;
            personnesArray[3] = e4;
            personnesArray[4] = c1;
            personnesArray[5] = c2;
            personnesArray[6] = d;

            for (int i = 0; i < personnesArray.Length; i++)
            {
                personnesArray[i].Afficher();
            }
        }
    }
}
