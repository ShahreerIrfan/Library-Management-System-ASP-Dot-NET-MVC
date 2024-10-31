#pragma checksum "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "547bee57aa5a54e162f508bb1a46245aa95de827"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BorrowingList), @"mvc.1.0.view", @"/Views/Home/BorrowingList.cshtml")]
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
#nullable restore
#line 1 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"547bee57aa5a54e162f508bb1a46245aa95de827", @"/Views/Home/BorrowingList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BorrowingList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.Borrowing>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
  
    ViewData["Title"] = "Borrowing List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<link href=""https://cdn.jsdelivr.net/npm/tailwindcss@2.2.19/dist/tailwind.min.css"" rel=""stylesheet"">

<div class=""container mx-auto"">
    <h2 class=""text-3xl font-bold mb-6"">Borrowing List (updated)</h2>

    <table class=""min-w-full bg-white border"">
        <thead>
            <tr>
                <th class=""py-2 px-4 border"">Book Title</th>
                <th class=""py-2 px-4 border"">User</th>
                <th class=""py-2 px-4 border"">Borrowed At</th>
                <th class=""py-2 px-4 border"">Return Date</th>
                <th class=""py-2 px-4 border"">Remaining Days</th>
                <th class=""py-2 px-4 border"">Returned At</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
             foreach (var borrowing in Model)
            {
                // Calculate return date (10 days after BorrowedAt)
                var returnDate = borrowing.BorrowedAt.AddDays(10);

                // Calculate remaining days
                var remainingDays = (returnDate - DateTime.Now).Days;


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"py-2 px-4 border\">");
#nullable restore
#line 34 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
                                            Write(borrowing.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"py-2 px-4 border\">");
#nullable restore
#line 35 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
                                            Write(borrowing.User.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"py-2 px-4 border\">");
#nullable restore
#line 36 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
                                            Write(borrowing.BorrowedAt.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"py-2 px-4 border\">");
#nullable restore
#line 37 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
                                            Write(returnDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"py-2 px-4 border\">\r\n");
#nullable restore
#line 39 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
                         if (remainingDays > 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
                        Write($"{remainingDays} days");

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
                                                      
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"text-red-500\">Overdue</span>\r\n");
#nullable restore
#line 46 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td class=\"py-2 px-4 border\">\r\n");
#nullable restore
#line 49 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
                         if (borrowing.ReturnedAt.HasValue)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
                       Write(borrowing.ReturnedAt?.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
                                                                         
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"text-red-500\">Not returned yet</span>\r\n");
#nullable restore
#line 56 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 59 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\BorrowingList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.Borrowing>> Html { get; private set; }
    }
}
#pragma warning restore 1591
