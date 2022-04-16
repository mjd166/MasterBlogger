using MB.Domain.ArticleCategoryAgg;
using MB.Domain.Exceptions;

namespace MB.Domain.Services
{
    public class ArticleCategoryValidatorService : IArticleCategoryValidatorService
    {
        private readonly IArticleCategoryRepository _articlecategoryrepository;

        public ArticleCategoryValidatorService(IArticleCategoryRepository articlecategoryrepository)
        {
            _articlecategoryrepository = articlecategoryrepository;
        }

        public void CheckThatThisRecordAlreadyExists(string title)
        {
            if (_articlecategoryrepository.Exists(title))
                throw new DoublicatedRecordException("This record already exists in database.");
        }
    }
}
