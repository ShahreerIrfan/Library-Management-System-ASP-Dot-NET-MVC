#pragma checksum "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\AdminDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90ec4b8da5076b7413a4828cbe86d157e75afa61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AdminDashboard), @"mvc.1.0.view", @"/Views/Home/AdminDashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ec4b8da5076b7413a4828cbe86d157e75afa61", @"/Views/Home/AdminDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AdminDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\AdminDashboard.cshtml"
  
    ViewData["Title"] = "Admin Dashboard";
    var totalBooks = Model.Count();  // Calculate the total number of books

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Tailwind CDN -->
<link href=""https://cdn.jsdelivr.net/npm/tailwindcss@2.2.19/dist/tailwind.min.css"" rel=""stylesheet"">

<!-- Modern Google Font for sleek and clean design -->
<link href=""https://fonts.googleapis.com/css2?family=Roboto:wght@400;500;700&display=swap"" rel=""stylesheet"">

<style>
    body {
        font-family: 'Roboto', sans-serif;
    }

    .btn {
        transition: background-color 0.3s ease, transform 0.2s ease;
        box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
    }

        .btn:hover {
            transform: translateY(-3px);
        }

    .card {
        box-shadow: 0 6px 15px rgba(0, 0, 0, 0.1);
        transition: box-shadow 0.3s ease, transform 0.2s ease;
    }

        .card:hover {
            transform: translateY(-5px);
            box-shadow: 0 12px 20px rgba(0, 0, 0, 0.15);
        }

    .action-btn {
        display: flex;
        gap: 10px;
        margin-top: 15px;
    }

    .dashboard-header {
        background: linear-gradient(");
            WriteLiteral(@"90deg, #1D976C, #93F9B9);
        padding: 30px;
        border-radius: 10px;
        color: white;
        text-align: center;
        margin-bottom: 30px;
    }

    .content-section {
        background-color: #f9fafb;
        padding: 20px;
        border-radius: 10px;
        margin-bottom: 30px;
    }

        .content-section h2 {
            font-size: 1.75rem;
            font-weight: 700;
            color: #1F2937;
            margin-bottom: 15px;
        }

        .content-section p {
            font-size: 1.1rem;
            color: #4B5563;
        }

    .total-books {
        background-color: #E5F9E0;
        padding: 20px;
        border-radius: 10px;
        margin-bottom: 20px;
        text-align: center;
    }

        .total-books h2 {
            font-size: 2.5rem;
            color: #38A169;
        }

        .total-books span {
            font-size: 1.2rem;
            color: #4B5563;
        }
</style>

<div class=""container mx-auto py");
            WriteLiteral(@"-10"">
    <!-- Admin Dashboard Header -->
    <div class=""dashboard-header"">
        <h1 class=""text-5xl font-bold"">Admin Dashboard</h1>
        <p class=""mt-3 text-xl"">
            Manage books, monitor borrowing activity, and maintain the Library Management System effortlessly.
        </p>
    </div>

    <!-- Total Books Section -->
    <div class=""total-books"">
        <h2>");
#nullable restore
#line 102 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\AdminDashboard.cshtml"
       Write(totalBooks);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
        <span>Total Books in the Library</span>
    </div>

    <!-- Library Management System Overview -->
    <div class=""content-section"">
        <h2>About the Library Management System</h2>
        <p>
            Our Library Management System is designed to simplify the process of managing a collection of books, allowing administrators
            to track book availability and monitor borrowings. With this system, admins can easily add, update, or remove books from the library's catalog.
            In addition, the borrowing process is streamlined, ensuring that both users and admins can access relevant information efficiently.
        </p>
        <p class=""mt-3"">
            This system offers a user-friendly interface with powerful features that empower administrators to oversee the library seamlessly.
            Keep track of every borrowing transaction, optimize the book catalog, and ensure that users have a smooth experience managing their book requests.
        </p>
    <");
            WriteLiteral(@"/div>

    
    <div class=""mb-8 flex justify-between"">
        <a href=""/Home/AddBook"" class=""btn bg-green-600 hover:bg-green-700 text-white py-3 px-6 rounded-lg text-lg"">
            <i class=""fas fa-plus-circle""></i> Add Book
        </a>
        <a href=""/Home/AdminBorrowList"" class=""bg-blue-600 hover:bg-blue-700 text-white py-2 px-4 rounded"">
            View Borrow List
        </a>
    </div>


    <div class=""grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-8"">
");
#nullable restore
#line 132 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\AdminDashboard.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card bg-white p-6 rounded-lg\">\r\n                <h3 class=\"text-2xl font-bold text-gray-800\">");
#nullable restore
#line 135 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\AdminDashboard.cshtml"
                                                        Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p class=\"text-md text-gray-600\">Author: ");
#nullable restore
#line 136 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\AdminDashboard.cshtml"
                                                    Write(book.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <div class=\"action-btn\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4474, "\"", 4513, 2);
            WriteAttributeValue("", 4481, "/Home/UpdateBook?id=", 4481, 20, true);
#nullable restore
#line 139 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\AdminDashboard.cshtml"
WriteAttributeValue("", 4501, book.BookId, 4501, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-yellow-500 hover:bg-yellow-600 text-white py-2 px-4 rounded-lg\">\r\n                        <i class=\"fas fa-edit\"></i> Update Book\r\n                    </a>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90ec4b8da5076b7413a4828cbe86d157e75afa6110326", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 4808, "\"", 4828, 1);
#nullable restore
#line 144 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\AdminDashboard.cshtml"
WriteAttributeValue("", 4816, book.BookId, 4816, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn bg-red-500 hover:bg-red-600 text-white py-2 px-4 rounded-lg\">\r\n                            <i class=\"fas fa-trash-alt\"></i> Delete Book\r\n                        </button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 151 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Home\AdminDashboard.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<!-- Font Awesome for icons -->\r\n<script src=\"https://kit.fontawesome.com/a076d05399.js\" crossorigin=\"anonymous\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
