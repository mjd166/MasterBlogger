#pragma checksum "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47e90b27c1a1688cb79f599090897df0f345bbc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Onion.Presentation.Areas.Administrator.Pages.CommentManagement.Areas_Administrator_Pages_CommentManagement_List), @"mvc.1.0.razor-page", @"/Areas/Administrator/Pages/CommentManagement/List.cshtml")]
namespace Onion.Presentation.Areas.Administrator.Pages.CommentManagement
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 5 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
using MB.Domain.CommentAgg;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47e90b27c1a1688cb79f599090897df0f345bbc8", @"/Areas/Administrator/Pages/CommentManagement/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"876095a2c6c38372b32de27da760084e90170f72", @"/Areas/Administrator/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administrator_Pages_CommentManagement_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Confirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-left mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card"">
    <div class=""card-header"">
        <h3 class=""float-left"">Comment List</h3>
    </div>
    <div class=""card-body"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Article</th>
                    <th>Message</th>
                    <th>Status</th>
                    <th>CreationDate</th>
                    <th>Operation</th>

                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 27 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                 foreach (var comment in Model.Comments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 30 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Article);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 36 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                             if (comment.Status == Statuses.New)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-2x fa-eye text-info \"></i>\r\n");
#nullable restore
#line 39 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                             if (comment.Status == Statuses.Canceled)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-2x fa-close text-danger \"></i>\r\n");
#nullable restore
#line 43 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                             if (comment.Status == Statuses.Confirm)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-2x fa-check text-success \"></i>\r\n");
#nullable restore
#line 47 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>");
#nullable restore
#line 51 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.CreationDate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n\r\n");
#nullable restore
#line 54 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                             if (comment.Status == Statuses.New)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47e90b27c1a1688cb79f599090897df0f345bbc810245", async() => {
                WriteLiteral("\r\n                                    <button class=\"btn btn-success mr-3\">Confirm</button>\r\n                                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2216, "\"", 2235, 1);
#nullable restore
#line 58 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
WriteAttributeValue("", 2224, comment.Id, 2224, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47e90b27c1a1688cb79f599090897df0f345bbc812666", async() => {
                WriteLiteral("\r\n                                    <button class=\"btn btn-danger mr-3\">Cancel</button>\r\n                                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2544, "\"", 2563, 1);
#nullable restore
#line 63 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
WriteAttributeValue("", 2552, comment.Id, 2552, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 65 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <!--else\r\n                            {-->\r\n");
            WriteLiteral("\r\n                            <!--}-->\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 87 "E:\asp net core atrya\Example\MasterBlogger\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel>)PageContext?.ViewData;
        public MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591