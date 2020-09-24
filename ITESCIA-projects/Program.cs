using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("Exo 1.1 :");
            var article = new Article("video", 29.00);
            var disque = new Disque("Les Enfoirés", "Disque", 19.99);
            var video = new Video(23.54, "Video", 39.99);
            article.Acheter();
            disque.Ecouter();
            video.Afficher();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exo 1.2 :");
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
            Console.WriteLine("Exo 1.3 :");
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
            Console.WriteLine("Exo 1.4 :");
            Article3[] articlesArray = new Article3[3];
            articlesArray[0] = article4;
            articlesArray[1] = article5;
            articlesArray[2] = articleUser2;
            for (int i = 0; i < articlesArray.Length; i++)
            {
                articlesArray[i].Afficher();
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exo 2.1 :");
            Personne personne = new Personne("Valentin", "Stockman", 25);
            Personne personne1 = new Personne("Mickey", "Mouse", 35);
            personne.Afficher();
            personne1.Afficher();
            personne.Combien();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exo 2.2 :");
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

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exo 2.3 :");
            Employe employe1 = new Employe("Valentin", "Stockman", 25, 3000);
            Employe employe2 = new Employe("Mickey", "Mouse", 35, 2000);
            Employe employe3 = new Employe("Employe", "Employe", 20, 1600); ;
            Employe employe4 = new Employe("Employe2", "Employe2", 30, 2400);
            Employe employe5 = new Employe("Gogeta", "Super Sayan", 45, 3700);
            Chef chef1 = new Chef("Chef 1", "nom Chef 1", 33, 3000, "Marketing");
            Chef chef2 = new Chef("Chef 2", "nom Chef 2", 30, 3200, "Informatique");
            Directeur directeur = new Directeur("Jean", "Charles", 38, 4500, "R&D", "ITESCIA");

            Console.WriteLine("Insertion des éléments à la liste : ");

            Liste personnes = new Liste();
            personnes.InsererDebut(directeur);
            personnes.InsererDebut(chef2);
            personnes.InsererDebut(chef1);
            personnes.InsererDebut(employe5);
            personnes.InsererDebut(employe4);
            personnes.InsererDebut(employe3);
            personnes.InsererDebut(employe2);
            personnes.InsererDebut(employe1);

            Console.WriteLine("Nombre d'éléments : {0}", personnes.NbElements);
            personnes.Lister();

            Console.WriteLine("Vidage de la liste");
            personnes.Vider();

            Console.WriteLine("Nombre d'éléments : {0}", personnes.NbElements);
            personnes.Lister();

            Console.WriteLine("Avec insertion de fin :");
            personnes.InsererFin(employe1);
            personnes.InsererFin(employe2);
            personnes.InsererFin(employe3);
            personnes.InsererFin(employe4);
            personnes.InsererFin(employe5);
            personnes.InsererFin(chef1);
            personnes.InsererFin(chef2);
            personnes.InsererFin(directeur);

            Console.WriteLine("Nombre d'éléments : {0}", personnes.NbElements);
            Console.WriteLine("Avec indexeur");
            for (int i = 0; i < personnes.NbElements; i++)
            {
                Console.WriteLine(personnes[i].Objet.ToString());
            }

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exo 2.4 :");
            ListeEnumerator personnesEnumerator = new ListeEnumerator(personnes);
            Console.WriteLine("Nombre d'éléments : {0}", personnes.NbElements);
            Console.WriteLine("Avec enumerator :");
            do
            {
                Console.WriteLine(personnesEnumerator.Current().ToString());
            }
            while (personnesEnumerator.MoveNext());
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exo 3.1 :");
            List<int> listeEntiers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> listEntiersPremiers = (from unEntier in listeEntiers
                                             where IsPrime(unEntier)
                                             select unEntier).ToList();

            foreach (int val in listEntiersPremiers)
                Console.WriteLine($"{val} ");


            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exo 3.2 :");
            List<int> listeAnnees = new List<int> { 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008,2009,2010,2011,2012,2013,2014,2015,2016,2017,2018,2019,2020 };
            List<int> listAnneesBissextiles = (from uneAnnee in listeAnnees
                                              where IsLeapYear(uneAnnee)
                                             select uneAnnee).ToList();

            foreach (int val in listAnneesBissextiles)
                Console.WriteLine($"{val} ");

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Exo 3.3 :");
            List<int> listeEntiers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> listEntiersDivisiblesPar5 = listeEntiers2.
                                                Where(valeur => valeur % 5 == 0)
                                                .ToList();

            foreach (int val in listEntiersDivisiblesPar5)
                Console.WriteLine($"{val} ");

        }

        private static bool IsPrime(int unEntier)
        {
            {
                if (unEntier <= 1) return false;
                if (unEntier == 2) return true;
                if (unEntier % 2 == 0) return false;

                var boundary = (int)Math.Floor(Math.Sqrt(unEntier));

                for (int i = 3; i <= boundary; i += 2)
                    if (unEntier % i == 0)
                        return false;

                return true;
            }
        }

        public static bool IsLeapYear(int Year)
        {
            return (((Year & 3) == 0) && ((Year % 100 != 0) || (Year % 400 == 0)));
        }
    }
}
