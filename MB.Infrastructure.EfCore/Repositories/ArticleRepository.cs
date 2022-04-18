using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MB.Infrastructure.EfCore.Repositories
{


    public  class ArticleRepository :IArticleRepository
    {

        private readonly MasterBloggerContext _context;

        public ArticleRepository(MasterBloggerContext context)
        {
            _context = context;
        }

        public void CreateAndSave(Article entity)
        {
            _context.Articles.Add(entity);
            Save();
        }

        public Article Get(long id)
        {
            return _context.Articles.FirstOrDefault(x => x.Id == id);
        }

        public List<ArticleViewModel> GetList()
        {
            return _context.Articles.Include(x => x.ArticleCategory).Select(x => new ArticleViewModel
            {
                Id = x.Id,
                Title = x.Title,
                IsDeleted = x.IsDeleted,
                CreationDate = x.CreationDate.ToString(),
                ArticleCategory = x.ArticleCategory.Title

            }).ToList();
        }

        public void Save()
        {
            _context.SaveChanges
                 ();
        }
    }
}
