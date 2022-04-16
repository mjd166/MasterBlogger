using System;
using System.Collections.Generic;

namespace MB.Application.Contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {

        List<ArticleCategoryViewModel> List();

        void Add(CreateArticleCategory command);
        void Rename(RenameArticleCategory command);
        void Remove(long id);
        void Activate(long id);

        RenameArticleCategory Get(long id);
    }
}
