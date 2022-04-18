using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application.Contracts.Article;
using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MB.Presentation.MVCCore.Areas.Administrator.Pages.ArticleManagement
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public EditArticle EditArticle { get; set; }
        public List<SelectListItem> ArticleCategories { get; set; }

        private readonly IArticleApplication articleApplication;
        private readonly IArticleCategoryApplication articleCategoryApplication;

        public EditModel(IArticleApplication articleApplication, IArticleCategoryApplication articleCategoryApplication)
        {
            this.articleApplication = articleApplication;
            this.articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet(long id)
        {
            EditArticle = articleApplication.Get(id);
            ArticleCategories = articleCategoryApplication.List().Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();

        }


        public RedirectToPageResult OnPost()
        {
            articleApplication.Edit(EditArticle);
            return RedirectToPage("./List");
        }
    }
}
