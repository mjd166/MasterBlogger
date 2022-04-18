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
    public class CreateModel : PageModel
    {
        
        public List<SelectListItem> ArticleCategories { get; set; }

        private readonly IArticleCategoryApplication articleCategoryApplication;

        private readonly IArticleApplication articleApplication;

        public CreateModel(IArticleApplication articleApplication, IArticleCategoryApplication articleCategoryApplication)
        {
            this.articleApplication = articleApplication;
            this.articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
         ArticleCategories =   articleCategoryApplication.List().Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
        }


        public RedirectToPageResult OnPost(CreateArticle command)
        {
            articleApplication.Create(command);

            return RedirectToPage("./List");
        }
    }
}
