#pragma checksum "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f20fda77e02d12ab4a7abd63a8fa150a616169b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20fda77e02d12ab4a7abd63a8fa150a616169b3", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-gray-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f20fda77e02d12ab4a7abd63a8fa150a616169b35179", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
#nullable restore
#line 7 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - WebApplication1</title>\r\n\r\n    \r\n    <link href=\"https://cdn.jsdelivr.net/npm/tailwindcss@2.2.19/dist/tailwind.min.css\" rel=\"stylesheet\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f20fda77e02d12ab4a7abd63a8fa150a616169b36664", async() => {
                WriteLiteral("\r\n    <!-- Header -->\r\n    <header class=\"bg-gradient-to-r from-blue-500 to-purple-500 shadow-lg text-white\">\r\n        <div class=\"max-w-7xl mx-auto py-6 px-4 sm:px-6 lg:px-8\">\r\n            <h1 class=\"text-5xl font-extrabold\">");
#nullable restore
#line 17 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml"
                                           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
        </div>

        <!-- Navigation -->
        <nav class=""bg-blue-600 p-4 shadow-md"">
            <div class=""max-w-7xl mx-auto"">
                <ul class=""flex space-x-8 text-lg"">
                    <li>
                        <a href=""/"" class=""text-white hover:text-gray-300 flex items-center space-x-2 transition duration-300 ease-in-out"">
                            <!-- Home Icon -->
                            <svg xmlns=""http://www.w3.org/2000/svg"" class=""w-6 h-6"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"">
                                <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M3 12l9-9 9 9M9 21V9h6v12"" />
                            </svg>
                            <span>Home</span>
                        </a>
                    </li>
                    <li>
                        <a href=""/Books"" class=""text-white hover:text-gray-300 flex items-center space-x-2 transition duration-300 ease-in-out"">
                    ");
                WriteLiteral(@"        <!-- Book Icon -->
                            <svg xmlns=""http://www.w3.org/2000/svg"" class=""w-6 h-6"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"">
                                <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M12 19V5m0 0H5a2 2 0 00-2 2v12a2 2 0 002 2h7m0 0v-2m7 2h-7m7-2V5a2 2 0 00-2-2h-7"" />
                            </svg>
                            <span>Books</span>
                        </a>
                    </li>

");
#nullable restore
#line 43 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml"
                         if (User.IsInRole("Admin"))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <li>
                                <a href=""/Home/AdminDashboard"" class=""text-white hover:text-gray-300 flex items-center space-x-2 transition duration-300 ease-in-out"">
                                    <!-- Admin Icon -->
                                    <svg xmlns=""http://www.w3.org/2000/svg"" class=""w-6 h-6"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"">
                                        <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M3 4v16h18V4M3 8h18M3 12h18M3 16h18"" />
                                    </svg>
                                    <span>Admin Dashboard</span>
                                </a>
                            </li>
");
#nullable restore
#line 56 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f20fda77e02d12ab4a7abd63a8fa150a616169b310663", async() => {
                    WriteLiteral(@"
                                <button type=""submit"" class=""text-white hover:text-gray-300 flex items-center space-x-2 transition duration-300 ease-in-out"">
                                    <!-- Logout Icon -->
                                    <svg xmlns=""http://www.w3.org/2000/svg"" class=""w-6 h-6"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"">
                                        <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M17 16l4-4m0 0l-4-4m4 4H7m6-4v8"" />
                                    </svg>
                                    <span>Logout</span>
                                </button>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 69 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <li>
                            <a href=""/Account/Login"" class=""text-white hover:text-gray-300 flex items-center space-x-2 transition duration-300 ease-in-out"">
                                <!-- Login Icon -->
                                <svg xmlns=""http://www.w3.org/2000/svg"" class=""w-6 h-6"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"">
                                    <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M15 12H3m12 0l-4 4m4-4l-4-4"" />
                                </svg>
                                <span>Login</span>
                            </a>
                        </li>
                        <li>
                            <a href=""/Account/Register"" class=""text-white hover:text-gray-300 flex items-center space-x-2 transition duration-300 ease-in-out"">
                                <!-- Register Icon -->
                                <svg xmlns=""http://www.w3.org/2000/svg"" class=""w-6 h-6"" viewB");
                WriteLiteral(@"ox=""0 0 24 24"" fill=""none"" stroke=""currentColor"">
                                    <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M16 7h1a2 2 0 012 2v8a2 2 0 01-2 2h-1m-4-4v-6a2 2 0 00-2-2H8a2 2 0 00-2 2v6m4-4h.01M16 21v-2a4 4 0 00-8 0v2"" />
                                </svg>
                                <span>Register</span>
                            </a>
                        </li>
");
#nullable restore
#line 90 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ul>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n\r\n    <!-- Main Content -->\r\n    <main class=\"max-w-7xl mx-auto p-8 bg-white shadow-lg rounded-lg mt-6\">\r\n        ");
#nullable restore
#line 98 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </main>

    <!-- Footer -->
    <footer class=""bg-gradient-to-r from-blue-500 to-purple-500 text-white text-center p-8 mt-10"">
        <p>&copy; 2024 - Library Management System. All Rights Reserved.</p>
        <div class=""flex justify-center space-x-6 mt-4"">
            <a href=""#"" class=""hover:text-gray-300 transition duration-300 ease-in-out"">
                <!-- Facebook Icon -->
                <svg xmlns=""http://www.w3.org/2000/svg"" class=""w-6 h-6"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"">
                    <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M18 9v6a9 9 0 11-6-8.71V9"" />
                </svg>
            </a>
            <a href=""#"" class=""hover:text-gray-300 transition duration-300 ease-in-out"">
                <!-- Twitter Icon -->
                <svg xmlns=""http://www.w3.org/2000/svg"" class=""w-6 h-6"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"">
                    <path stroke-linecap=""round"" stroke-linejoin=""rou");
                WriteLiteral(@"nd"" stroke-width=""2"" d=""M22 4.92c-.74.33-1.53.54-2.36.64a4.12 4.12 0 001.81-2.27 7.87 7.87 0 01-2.59 1A4.08 4.08 0 0015 3a4.09 4.09 0 00-4.05 4.04c0 .32.04.64.12.94a11.66 11.66 0 01-8.47-4.3 4.1 4.1 0 00-.55 2.04c0 1.4.72 2.64 1.83 3.37A4.06 4.06 0 013 9.2v.05a4.09 4.09 0 003.28 4 4.11 4.11 0 01-1.85.07 4.09 4.09 0 003.81 2.83A8.23 8.23 0 013 19.8a11.63 11.63 0 006.29 1.84c7.55 0 11.68-6.26 11.68-11.68 0-.18 0-.36-.01-.53A8.35 8.35 0 0022 4.92z"" />
                </svg>
            </a>
        </div>
    </footer>

    ");
#nullable restore
#line 120 "C:\Users\IRFAN\source\repos\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
