using System.Collections.Generic;
using MB.Application.Contracts.Article;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Administrator.Pages.ArticleManagement
{
    public class ListModel : PageModel
    {
        public List<ArticleViewModel>  ArticleViewModels { get; set; }

        private readonly IArticleApplication articleApplication;

        public ListModel(IArticleApplication articleApplication)
        {
            this.articleApplication = articleApplication;
        }

        public void OnGet()
        {
            ArticleViewModels = articleApplication.GetList();
        }

        public void OnPostRemove(long id)
        {

        }

        public void OnPostActivate(long id)
        {

        }
    }
}
