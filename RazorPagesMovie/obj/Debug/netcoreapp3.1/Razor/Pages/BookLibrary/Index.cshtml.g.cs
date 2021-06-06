#pragma checksum "E:\ASP_DOT_NET_RAZOR_PAGES\aspdotnet_core\RazorPagesMovie\Pages\BookLibrary\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e81423df3e14f649290adf75e0ef8e22469082c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesMovie.Pages.BookLibrary.Pages_BookLibrary_Index), @"mvc.1.0.razor-page", @"/Pages/BookLibrary/Index.cshtml")]
namespace RazorPagesMovie.Pages.BookLibrary
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
#line 1 "E:\ASP_DOT_NET_RAZOR_PAGES\aspdotnet_core\RazorPagesMovie\Pages\_ViewImports.cshtml"
using RazorPagesMovie;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e81423df3e14f649290adf75e0ef8e22469082c1", @"/Pages/BookLibrary/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bffd98f02597e6a09295a2131188dc64093be78", @"/Pages/_ViewImports.cshtml")]
    public class Pages_BookLibrary_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\ASP_DOT_NET_RAZOR_PAGES\aspdotnet_core\RazorPagesMovie\Pages\BookLibrary\Index.cshtml"
  
    var noOfBooksInStore = Model.lstBooks.Count();


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>No Of Books In the store:");
#nullable restore
#line 8 "E:\ASP_DOT_NET_RAZOR_PAGES\aspdotnet_core\RazorPagesMovie\Pages\BookLibrary\Index.cshtml"
                        Write(noOfBooksInStore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<div class=\"card-deck\">\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 13 "E:\ASP_DOT_NET_RAZOR_PAGES\aspdotnet_core\RazorPagesMovie\Pages\BookLibrary\Index.cshtml"
         foreach (var book in Model.lstBooks)
        {
            var photoPath = "/images/bookcoverpages/" + (book.CoverPage ?? "travel.jpg");

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3\" style=\"padding-top:10px\">\r\n            <div class=\"card\">\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 507, "\"", 523, 1);
#nullable restore
#line 18 "E:\ASP_DOT_NET_RAZOR_PAGES\aspdotnet_core\RazorPagesMovie\Pages\BookLibrary\Index.cshtml"
WriteAttributeValue("", 513, photoPath, 513, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                <div class=\"card-body\">\r\n\r\n                    <h5 class=\"card-title\">Name:");
#nullable restore
#line 21 "E:\ASP_DOT_NET_RAZOR_PAGES\aspdotnet_core\RazorPagesMovie\Pages\BookLibrary\Index.cshtml"
                                           Write(book.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5 class=\"card-title\">Author:");
#nullable restore
#line 22 "E:\ASP_DOT_NET_RAZOR_PAGES\aspdotnet_core\RazorPagesMovie\Pages\BookLibrary\Index.cshtml"
                                             Write(book.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">Description:");
#nullable restore
#line 23 "E:\ASP_DOT_NET_RAZOR_PAGES\aspdotnet_core\RazorPagesMovie\Pages\BookLibrary\Index.cshtml"
                                                Write(book.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\"><small class=\"text-muted\">Price:");
#nullable restore
#line 24 "E:\ASP_DOT_NET_RAZOR_PAGES\aspdotnet_core\RazorPagesMovie\Pages\BookLibrary\Index.cshtml"
                                                                    Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                    <p class=\"card-text\">Category:");
#nullable restore
#line 25 "E:\ASP_DOT_NET_RAZOR_PAGES\aspdotnet_core\RazorPagesMovie\Pages\BookLibrary\Index.cshtml"
                                             Write(book.BookCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">Pages:");
#nullable restore
#line 26 "E:\ASP_DOT_NET_RAZOR_PAGES\aspdotnet_core\RazorPagesMovie\Pages\BookLibrary\Index.cshtml"
                                          Write(book.NoOfPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"card-footer\">\r\n");
            WriteLiteral("                    <a href=\"#\" class=\"btn btn-sm btn-primary\">View Details</a>\r\n                    <a href=\"#\" class=\"btn btn-sm btn-primary\">Add to cart</a>\r\n                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 36 "E:\ASP_DOT_NET_RAZOR_PAGES\aspdotnet_core\RazorPagesMovie\Pages\BookLibrary\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.Pages.BookLibrary.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.BookLibrary.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.BookLibrary.IndexModel>)PageContext?.ViewData;
        public RazorPagesMovie.Pages.BookLibrary.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591