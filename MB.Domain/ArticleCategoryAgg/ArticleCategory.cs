using MB.Domain.Services;
using System;
namespace MB.Domain.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }



        public void GuarAgainstEmptyTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException();
        }
        public ArticleCategory(string title,IArticleCategoryValidatorService validatorService)
        {
            GuarAgainstEmptyTitle(title);
            validatorService.CheckThatThisRecordAlreadyExists(title);
            Title = title;
            IsDeleted = false;
            CreationDate = DateTime.Now;
        }

        public void Rename(string title)
        {
            GuarAgainstEmptyTitle(title);
            Title = title;
        }

        public void Remove()
        {
            IsDeleted = true;
        }

        public void Activate()
        {
            IsDeleted = false;
        }


    }
}
