using System;
using System.Collections.Generic;
using ITESCIA_projects.Exo2;
namespace ITESCIA_projects.Exo3
{
    interface IArticleDAO
    {
        public Article2 GetArticleByName(string name);
        public List<Article2> GetArticlesByPrice(int price);
        public List<Article2> GetArticles();

        public Tuple<int, double> GetArticleQuantityPriceByName(string name);
    }
}
