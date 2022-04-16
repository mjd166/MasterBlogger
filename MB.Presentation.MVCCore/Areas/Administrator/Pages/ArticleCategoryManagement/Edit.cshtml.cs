using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Administrator.Pages.ArticleCategoryManagement
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public RenameArticleCategory articleCategory { get; set; }



        private readonly IArticleCategoryApplication categoryApplication;

        public EditModel(IArticleCategoryApplication categoryApplication)
        {
            this.categoryApplication = categoryApplication;
        }

        public void OnGet(long id)
        {
            articleCategory = categoryApplication.Get(id);
        }


        public RedirectToPageResult OnPost()
        {
            categoryApplication.Rename(articleCategory);
            return RedirectToPage("./List");
        }
    }
}
