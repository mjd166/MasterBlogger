using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace MB.Presentation.MVCCore.Areas.Administrator.Pages.ArticleCategoryManagement
{
    public class ListModel : PageModel
    {
        public List<ArticleCategoryViewModel> articleCategories;

        private readonly IArticleCategoryApplication articleCategoryApplication;

        public ListModel(IArticleCategoryApplication articleCategoryApplication)
        {
            this.articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
            articleCategories = articleCategoryApplication.List();
        }


        public Microsoft.AspNetCore.Mvc.RedirectToPageResult OnPostRemove(long id)
        {
            articleCategoryApplication.Remove(id);
            return RedirectToPage("./List");
        }

        public Microsoft.AspNetCore.Mvc.RedirectToPageResult OnPostActive(long id)
        {
            articleCategoryApplication.Activate(id);
            return RedirectToPage("./List");
        }
    }
}
