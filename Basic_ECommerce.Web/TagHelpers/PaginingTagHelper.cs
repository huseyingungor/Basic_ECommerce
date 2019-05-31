using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_ECommerce.Web.TagHelpers
{
    [HtmlTargetElement("product-list-pager")]
    public class PaginingTagHelper : TagHelper
    {
        [HtmlAttributeName("page-size")]
        public int PageSize { get; set; }
        [HtmlAttributeName("page-count")]
        public int PageCount { get; set; }
        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }
        [HtmlAttributeName("current-category")]
        public int CurrentCategory { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<ul class='pagination'>");

            for (int i = 1; i <= PageCount; i++)
            {
                sb.AppendLine($"<li class='page-item {(CurrentPage == i ? "active" : "")}'>");
                sb.AppendLine($"<a class='page-link' href='/Product/Index?page={i}&category={CurrentCategory}'>{i}</a>");
                sb.AppendLine("</li>");
            }

            sb.AppendLine("</ul>");

            output.Content.SetHtmlContent(Convert.ToString(sb));
            base.Process(context, output);
        }
    }
}
