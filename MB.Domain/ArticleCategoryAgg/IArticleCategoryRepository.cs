using System.Collections.Generic;

namespace MB.Domain.ArticleCategoryAgg
{
    public  interface IArticleCategoryRepository
    {
        List<ArticleCategory> GetAll();
        void Create(ArticleCategory entity);

        ArticleCategory Get(long id);


        void Save();

        bool Exists(string title);

    }
}
