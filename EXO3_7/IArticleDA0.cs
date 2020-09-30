using System;
using System.Collections.Generic;
using System.Text;

namespace EXO3
{
    class IArticleDA0
    {
        interface IArticleDAO
        {
            public Article GetArticleByName(string name);
            public List<Article> GetArticlesByPrice(int price);
            public List<Article> GetArticles();

             public Tuple<int, int> GetArticleQuantityPriceByName(string name);

       }
    }
}
