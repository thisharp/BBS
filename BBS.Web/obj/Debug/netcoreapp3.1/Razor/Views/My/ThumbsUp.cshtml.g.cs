#pragma checksum "E:\DEMO_SPACES\BBS\BBS.Web\Views\My\ThumbsUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07a13287e15fec56c40dead1e121f009a3be0a3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_My_ThumbsUp), @"mvc.1.0.view", @"/Views/My/ThumbsUp.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\DEMO_SPACES\BBS\BBS.Web\Views\_ViewImports.cshtml"
using BBS.Web;

#line default
#line hidden
#line 2 "E:\DEMO_SPACES\BBS\BBS.Web\Views\_ViewImports.cshtml"
using BBS.Models;

#line default
#line hidden
#line 3 "E:\DEMO_SPACES\BBS\BBS.Web\Views\_ViewImports.cshtml"
using BBS.Framework.Configs;

#line default
#line hidden
#line 4 "E:\DEMO_SPACES\BBS\BBS.Web\Views\_ViewImports.cshtml"
using BBS.Framework.Models;

#line default
#line hidden
#line 5 "E:\DEMO_SPACES\BBS\BBS.Web\Views\_ViewImports.cshtml"
using BBS.Framework.Extensions;

#line default
#line hidden
#line 6 "E:\DEMO_SPACES\BBS\BBS.Web\Views\_ViewImports.cshtml"
using StackExchange.Profiling;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07a13287e15fec56c40dead1e121f009a3be0a3f", @"/Views/My/ThumbsUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e4de8eda15c20b299cbcef35d03eb9e2df59b1", @"/Views/_ViewImports.cshtml")]
    public class Views_My_ThumbsUp : BBS.Web.Infrastructure.BBSRazorPage<PagedList<TopicModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\DEMO_SPACES\BBS\BBS.Web\Views\My\ThumbsUp.cshtml"
  
    ViewData["Title"] = "我的点赞";

#line default
#line hidden
            WriteLiteral("\r\n");
#line 6 "E:\DEMO_SPACES\BBS\BBS.Web\Views\My\ThumbsUp.cshtml"
Write(await Component.InvokeAsync("MyInfo"));

#line default
#line hidden
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"tt-tab-wrapper\">\r\n        ");
#line 9 "E:\DEMO_SPACES\BBS\BBS.Web\Views\My\ThumbsUp.cshtml"
   Write(await Component.InvokeAsync("MyInfoTab"));

#line default
#line hidden
            WriteLiteral("\r\n        <div class=\"tab-content alert-white\">\r\n            <div class=\"tab-pane tt-indent-none show active\" role=\"tabpanel\">\r\n                <div class=\"tt-wrapper-inner tt-layout-tab\">\r\n");
#line 13 "E:\DEMO_SPACES\BBS\BBS.Web\Views\My\ThumbsUp.cshtml"
                     if (Model.Count <= 0)
                    {

#line default
#line hidden
            WriteLiteral("                        <img src=\"/images/404.png\">\r\n");
#line 16 "E:\DEMO_SPACES\BBS\BBS.Web\Views\My\ThumbsUp.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#line 19 "E:\DEMO_SPACES\BBS\BBS.Web\Views\My\ThumbsUp.cshtml"
                   Write(await Component.InvokeAsync("TopicList", Model));

#line default
#line hidden
#line 20 "E:\DEMO_SPACES\BBS\BBS.Web\Views\My\ThumbsUp.cshtml"
                   Write(await Component.InvokeAsync("Pagination", Model.ToPagination("ThumbsUp", "My")));

#line default
#line hidden
#line 20 "E:\DEMO_SPACES\BBS\BBS.Web\Views\My\ThumbsUp.cshtml"
                                                                                                        
                    }

#line default
#line hidden
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList<TopicModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591