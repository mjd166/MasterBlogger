using System;

namespace MB.Domain.ArticleAgg.Services
{
    public interface IArticleValidatorService 
    {
        void CheckThatThisRecordAlreadyExist(string title);
    }
}
