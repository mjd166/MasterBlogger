using MB.Application.Contracts.Article;
using System.Collections.Generic;

namespace MB.Domain.ArticleAgg
{
    public interface IArticleRepository
    {
        List<ArticleViewModel> GetList();
        void CreateAndSave(Article entity);

    }
}
