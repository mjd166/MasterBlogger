using _01_Framework.Domain;
using MB.Domain.ArticleAgg;
using MB.Domain.Services;
using System;
using System.Collections.Generic;

namespace MB.Domain.ArticleCategoryAgg
{
    public class ArticleCategory:DomainBase<long>
    {
        
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
       

        public ICollection<Article> Articles { get;private set; }

        protected ArticleCategory()
        {

        }


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
            Articles = new List<Article>();
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
