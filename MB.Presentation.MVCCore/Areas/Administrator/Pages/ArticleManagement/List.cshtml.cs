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

        public Microsoft.AspNetCore.Mvc.RedirectToPageResult OnPostRemove(long id)
        {
            articleApplication.Remove(id);
            return RedirectToPage("./List");
        }

        public Microsoft.AspNetCore.Mvc.RedirectToPageResult OnPostActivate(long id)
        {
            articleApplication.Restore(id);
            return RedirectToPage("./List");
        }
    }
}
