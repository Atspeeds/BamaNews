#pragma checksum "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Pages\Shared\_News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1505dbe3bd980f3588898c94ef86181a08caaac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BamaNews.Presentation.MvcCore.Pages.Shared.Pages_Shared__News), @"mvc.1.0.view", @"/Pages/Shared/_News.cshtml")]
namespace BamaNews.Presentation.MvcCore.Pages.Shared
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
#line 1 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Pages\_ViewImports.cshtml"
using BamaNews.Presentation.MvcCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Pages\Shared\_News.cshtml"
using BN.Infrastrure.Query.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1505dbe3bd980f3588898c94ef86181a08caaac1", @"/Pages/Shared/_News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5512d021c6336c5d6994a623cf6952ca59cf6915", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-lg-4 col-md-6\">\r\n    <div class=\"blog-item style-1\">\r\n        <div class=\"post-wrapper\">\r\n            <div class=\"post-thumbnail\">\r\n                <a href=\"blog-detail.html\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 276, "\"", 309, 2);
            WriteAttributeValue("", 282, "/images/blog/", 282, 13, true);
#nullable restore
#line 9 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Pages\Shared\_News.cshtml"
WriteAttributeValue("", 295, Model.Image, 295, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 310, "\"", 316, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </a>\r\n            </div>\r\n            <div class=\"post-info\">\r\n                <div class=\"post-categories\">\r\n                    <a href=\"#\" class=\"bg-red\">");
#nullable restore
#line 14 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Pages\Shared\_News.cshtml"
                                          Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <a href=\"#\" class=\"bg-emerald\">");
#nullable restore
#line 15 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Pages\Shared\_News.cshtml"
                                              Write(Model.NewsCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n                <h3 class=\"post-title\">\r\n                    <a href=\"blog-detail.html\">");
#nullable restore
#line 18 "C:\Users\AMIRPC\source\repos\BamaNews_APP\BamaNews.Presentation.MvcCore\Pages\Shared\_News.cshtml"
                                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                </h3>
                <div class=""post-meta"">
                    <div class=""post-view meta-item"">
                        <i class=""ion-eye""></i>
                        32 مشاهده
                    </div>
                    <div class=""post-likes meta-item"">
                        <i class=""ion-android-favorite-outline""></i>
                        3 لایک
                    </div>
                    <div class=""post-author-meta meta-item"">
                        <i class=""ion-ios-person""></i>
                        آرش خادملو
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsView> Html { get; private set; }
    }
}
#pragma warning restore 1591