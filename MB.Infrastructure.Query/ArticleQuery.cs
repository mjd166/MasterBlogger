using MB.Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MB.Infrastructure.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly MasterBloggerContext _Context;

        public ArticleQuery(MasterBloggerContext context)
        {
            _Context = context;
        }

        public ArticleQueryView GetArticle(long id)
        {
            return _Context.Articles.Include(x=>x.ArticleCategory).Select(x => new ArticleQueryView
            {
                Id = x.Id,
                Title = x.Title,
                Image = x.Image,
                ShortDescription = x.ShortDescription,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                ArticleCategory = x.ArticleCategory.Title,
                Content=x.Content
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ArticleQueryView> GetArticles()
        {
            return _Context.Articles.Include(x => x.ArticleCategory).Select(x => new ArticleQueryView
            {
                ArticleCategory = x.ArticleCategory.Title,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                Title = x.Title,
                Id = x.Id,
                ShortDescription = x.ShortDescription,
                Image = x.Image

            }).ToList() ;
        }
    }
}
