using _01_Framework.Infrastructure;
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
        private readonly IUnitOfWork unitOfWork;
        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository, IArticleCategoryValidatorService validatorService, IUnitOfWork unitOfWork)
        {
            this._articleCategoryRepository = articleCategoryRepository;
            this.validatorService = validatorService;
            this.unitOfWork = unitOfWork;
        }

        public void Activate(long id)
        {
            unitOfWork.BeginTran();
            var articlecategory = _articleCategoryRepository.Get(id);
            articlecategory.Activate();
            unitOfWork.CommitTran();
        }

        public void Add(CreateArticleCategory command)
        {
            unitOfWork.BeginTran();
            ArticleCategory _category = new ArticleCategory(command.Title, validatorService);
            _articleCategoryRepository.Create(_category);
            unitOfWork.CommitTran();
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
            unitOfWork.BeginTran();
            var articlecategory = _articleCategoryRepository.Get(id);
            articlecategory.Remove();
            unitOfWork.CommitTran();

        }

        public void Rename(RenameArticleCategory command)
        {
            unitOfWork.BeginTran();
            var articlecategory = _articleCategoryRepository.Get(command.Id);
            articlecategory.Rename(command.Title);
            unitOfWork.CommitTran();

        }


    }
}
