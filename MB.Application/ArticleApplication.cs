using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;
using MB.Infrastructure.EfCore.Repositories;
using System;
using System.Collections.Generic;

namespace MB.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;
     
        public ArticleApplication(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
            
        }

        public void Create(CreateArticle command)
        {
            var article = new Article(command.Title, command.ShortDescription, command.Image, command.Content, command.ArticleCategoryId);
            _articleRepository.CreateAndSave(article);
        }

        public List<ArticleViewModel> GetList()
        {
            return _articleRepository.GetList();

        }
    }
}
