using System.Collections.Generic;
using MB.Infrastructure.Query;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Pages
{
    public class IndexModel : PageModel
    {
        public List<ArticleQueryView> articles { get; set; }

        private readonly IArticleQuery articleQuery;

        public IndexModel(IArticleQuery articleQuery)
        {
            this.articleQuery = articleQuery;
        }

        

        public void OnGet()
        {
            articles = articleQuery.GetArticles();
        }
    }
}