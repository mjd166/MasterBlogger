using MB.Domain.Exceptions;

namespace MB.Domain.ArticleAgg.Services
{
    public class ArticleValidatorService : IArticleValidatorService
    {
        private readonly IArticleRepository articleRepository;

        public ArticleValidatorService(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        public void CheckThatThisRecordAlreadyExist(string title)
        {
            if (articleRepository.Exists(title))
                throw new DoublicatedRecordException();

        }
    }
}
