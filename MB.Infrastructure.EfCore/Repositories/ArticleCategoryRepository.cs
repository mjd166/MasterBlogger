using _01_Framework.Infrastructure;
using MB.Domain.ArticleCategoryAgg;
using System.Collections.Generic;
using System.Linq;

namespace MB.Infrastructure.EfCore.Repositories
{
    public class ArticleCategoryRepository : BaseRepository<long,ArticleCategory>, IArticleCategoryRepository
    {

        private readonly MasterBloggerContext _context;

        public ArticleCategoryRepository(MasterBloggerContext context) :base(context)
        {
            _context = context;
        }

      

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
