using MB.Domain.CommentAgg;
using MB.Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;
using System;
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
            return _Context.Articles.Include(x=>x.ArticleCategory)
                .Include(x=>x.Comments)
                .Select(x => new ArticleQueryView
            {
                Id = x.Id,
                Title = x.Title,
                Image = x.Image,
                ShortDescription = x.ShortDescription,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                ArticleCategory = x.ArticleCategory.Title,
                Content=x.Content,
                CommentCount=x.Comments.Count(x=>x.Status ==Statuses.Confirm),
                Comments = MapComments(x.Comments.Where(x=>x.Status ==Statuses.Confirm))
                
            }).FirstOrDefault(x => x.Id == id);
        }

        private static List<CommentQueryView> MapComments(IEnumerable<Comment> enumerable)
        {
            return (enumerable.Select(item => new CommentQueryView
            {
                CreationDate = item.CreationDate.ToString(CultureInfo.InvariantCulture),
                Message = item.Message,
                Name = item.Name
            })).ToList();
        }

        public List<ArticleQueryView> GetArticles()
        {
            return _Context.Articles
                .Include(x => x.ArticleCategory)
                .Include(x => x.Comments)
                .Select(x => new ArticleQueryView
                {
                    ArticleCategory = x.ArticleCategory.Title,
                    CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                    Title = x.Title,
                    Id = x.Id,
                    ShortDescription = x.ShortDescription,
                    Image = x.Image,
                    CommentCount = x.Comments.Count(x=>x.Status==Statuses.Confirm)


                }).ToList() ;
        }
    }
}
