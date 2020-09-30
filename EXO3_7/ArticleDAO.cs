﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXO3
{
    class ArticleDAO
    {
        public List<Article> articles { get; }

        public ArticleDAO()
        {
            articles = GetArticles();
        }

        public ArticleDAO(List<Article> articles)
        {
            this.articles = articles;
        }

        public List<Article> GetArticlesByPrice(int price)
        {
            return this.articles.Where(art => art.Price == price).ToList();
        }

        public Article GetArticleByName(string name)
        {
            return this.articles.Where(art => art.Name == name).FirstOrDefault();
        }

        public string GetArticlesInformations()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Number of articles: {this.articles.Count}");
            result.AppendLine($"Article that have the least quantity: {this.articles.Min(art => art.Quantity)}");
            result.AppendLine($"Article that have the most quantity: {this.articles.Max(art => art.Quantity)}");
            result.AppendLine($"The average price of article: {this.articles.Average(art => art.Price)}");
            return result.ToString();
        }

        public List<Article> GetArticles()
        {
            return new List<Article>()
            {
                new Article("Vainqueur F1","C'est hamilton",1),
                new Article("Vainqueur F2","C'est john",4),
                new Article("Vainqueur F3","C'est lucas",5),
                new Article("Vainqueur F4","C'est fred",22),
                new Article("Vainqueur F5","C'est amid",1),
                new Article("Vainqueur F6","C'est giovanni",10),
            };
        }
    }
}
