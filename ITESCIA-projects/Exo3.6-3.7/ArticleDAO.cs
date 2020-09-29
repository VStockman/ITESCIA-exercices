using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITESCIA_projects.Exo2;

namespace ITESCIA_projects.Exo3
{
    public class ArticleDAO : IArticleDAO
    {
        public List<Article2> Articles { get; }

        public ArticleDAO()
        {
            Articles = GetArticles();
        }

        public ArticleDAO(List<Article2> articles)
        {
            Articles = articles;
        }

        public List<Article2> GetArticlesByPrice(int price)
        {
            return Articles.Where(art => art.Prix == price).ToList();
        }

        public Article2 GetArticleByName(string name)
        {
            return Articles.Where(art => art.Nom == name).FirstOrDefault();
        }

        public Tuple<int, double> GetArticleQuantityPriceByName(string name)
        {
            Article2 myarticle = Articles.Where(art => art.Nom == name).FirstOrDefault();
            int price = myarticle.Quantite;
            double quantity = myarticle.Prix;
            return new Tuple<int, double>(price, quantity);
        }

        public string GetArticlesMinMaxAndAverage()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Nombre d'articles: {Articles.Count}");
            result.AppendLine($"Article qui a la plus petite quantité : {Articles.Min(art => art.Quantite)}");
            result.AppendLine($"Article qui a la plus grosse quantité : {Articles.Max(art => art.Quantite)}");
            result.AppendLine($"Prix moyen d'un article : {Articles.Average(art => art.Prix)}");
            return result.ToString();
        }

        public List<Article2> GetArticles()
        {
            return new List<Article2>()
            {
                new Article2("Livre",19.99, 2),
                new Article2("Video",9.99, 3),
                new Article2("Photo",1.99, 12),
                new Article2("Manga",5.99, 5),
                new Article2("Jeu de société",4.99, 8),
                new Article2("BD",10.00, 9),
            };
        }

        List<Article2> IArticleDAO.GetArticlesByPrice(int price)
        {
            return Articles.Where(art => art.Prix == price).ToList();
        }
    }
}
