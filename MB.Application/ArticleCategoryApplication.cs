using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.Services;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IArticleCategoryValidatorService validatorService;
        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository, IArticleCategoryValidatorService validatorService)
        {
            this._articleCategoryRepository = articleCategoryRepository;
            this.validatorService = validatorService;
        }

        public void Activate(long id)
        {
            var articlecategory = _articleCategoryRepository.Get(id);
            articlecategory.Activate();
            //_articleCategoryRepository.Save();
        }

        public void Add(CreateArticleCategory command)
        {
            ArticleCategory _category = new ArticleCategory(command.Title,validatorService);
            _articleCategoryRepository.Create(_category);
        }

        public RenameArticleCategory Get(long id)
        {
            var articlecategory = _articleCategoryRepository.Get(id);
            return new RenameArticleCategory
            {
                Id = articlecategory.Id,
                Title = articlecategory.Title
            };       
        }

        public List<ArticleCategoryViewModel> List()
        {
            var articlecategories = _articleCategoryRepository.GetAll();
            return (articlecategories.Select(article => new ArticleCategoryViewModel
            {
                Id = article.Id,
                IsDeleted = article.IsDeleted,
                Name = article.Title,
                CreationDate = article.CreationDate.ToString(CultureInfo.InvariantCulture)
            })).OrderBy(x => x.Id).ToList();
        }

        public void Remove(long id)
        {
            var articlecategory = _articleCategoryRepository.Get(id);
            articlecategory.Remove();
            //_articleCategoryRepository.Save();
        }

        public void Rename(RenameArticleCategory command)
        {
            var articlecategory = _articleCategoryRepository.Get(command.Id);
            articlecategory.Rename(command.Title);
           // _articleCategoryRepository.Save();
        }

      
    }
}
