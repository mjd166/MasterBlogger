using _01_Framework.Infrastructure;
using System.Collections.Generic;

namespace MB.Domain.ArticleCategoryAgg
{
    public  interface IArticleCategoryRepository:IRepository<long,ArticleCategory>
    {
    }
}
