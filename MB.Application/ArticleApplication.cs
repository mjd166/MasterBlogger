using _01_Framework.Infrastructure;
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
        private readonly IUnitOfWork unitOfWork;
        public ArticleApplication(IArticleRepository articleRepository, IUnitOfWork unitOfWork)
        {
            _articleRepository = articleRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Create(CreateArticle command)
        {
            unitOfWork.BeginTran();
            var article = new Article(command.Title, command.ShortDescription, command.Image, command.Content, command.ArticleCategoryId);
            _articleRepository.Create(article);
            unitOfWork.CommitTran();
        }

        public void Edit(EditArticle command)
        {
            unitOfWork.BeginTran();
            var article = _articleRepository.Get(command.Id);
            article.Edit(command.Title, command.ShortDescription, command.Image, command.Content, command.ArticleCategoryId);
            unitOfWork.CommitTran();
         
        }

        public EditArticle Get(long id)
        {
            var article = _articleRepository.Get(id);

            return new EditArticle
            {
                Id = article.Id,
                ArticleCategoryId = article.ArticleCategoryId,
                Content = article.Content,
                Image = article.Image,
                ShortDescription = article.ShortDescription,
                Title = article.Title
            };
        }

        public List<ArticleViewModel> GetList()
        {
            return _articleRepository.GetList();

        }

        public void Remove(long id)
        {
            unitOfWork.BeginTran();
            var article = _articleRepository.Get(id);
            article.Remove();
            unitOfWork.CommitTran();
        }

        public void Restore(long id)
        {
            unitOfWork.BeginTran();
            var article = _articleRepository.Get(id);
            article.Restore();
            unitOfWork.CommitTran();
        }
    }
}
