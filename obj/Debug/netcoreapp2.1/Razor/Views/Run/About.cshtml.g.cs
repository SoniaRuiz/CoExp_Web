#pragma checksum "\\ad.ucl.ac.uk\home0\skgtsg0\Documents\GitHub\CoExp_Web\Views\Run\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37a8d3550191e55633803fb6601861494fab56ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Run_About), @"mvc.1.0.view", @"/Views/Run/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Run/About.cshtml", typeof(AspNetCore.Views_Run_About))]
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
#line 1 "\\ad.ucl.ac.uk\home0\skgtsg0\Documents\GitHub\CoExp_Web\Views\_ViewImports.cshtml"
using CoExp_Web;

#line default
#line hidden
#line 2 "\\ad.ucl.ac.uk\home0\skgtsg0\Documents\GitHub\CoExp_Web\Views\_ViewImports.cshtml"
using CoExp_Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37a8d3550191e55633803fb6601861494fab56ec", @"/Views/Run/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"999153e3f062e8fedf186436238d7f4cf3822629", @"/Views/_ViewImports.cshtml")]
    public class Views_Run_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo-ucl.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("UCL logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo-um.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("UM logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "\\ad.ucl.ac.uk\home0\skgtsg0\Documents\GitHub\CoExp_Web\Views\Run\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(43, 28, true);
            WriteLiteral("\r\n<div class=\"breadcrumb\">\r\n");
            EndContext();
#line 7 "\\ad.ucl.ac.uk\home0\skgtsg0\Documents\GitHub\CoExp_Web\Views\Run\About.cshtml"
     if (ViewContext.RouteData.Values["controller"].ToString() != "Home")
    {

#line default
#line hidden
            BeginContext(153, 124, true);
            WriteLiteral("        <span class=\"main-label-breadcrumbs\">CoExp</span>\r\n        <span class=\"glyphicon glyphicon-chevron-right\"></span>\r\n");
            EndContext();
#line 11 "\\ad.ucl.ac.uk\home0\skgtsg0\Documents\GitHub\CoExp_Web\Views\Run\About.cshtml"
    }

#line default
#line hidden
            BeginContext(284, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 12 "\\ad.ucl.ac.uk\home0\skgtsg0\Documents\GitHub\CoExp_Web\Views\Run\About.cshtml"
     if (ViewContext.RouteData.Values["action"].ToString() != "Index")
    {

#line default
#line hidden
            BeginContext(363, 43, true);
            WriteLiteral("        <span class=\"active\">About</span>\r\n");
            EndContext();
#line 15 "\\ad.ucl.ac.uk\home0\skgtsg0\Documents\GitHub\CoExp_Web\Views\Run\About.cshtml"
                                                                                                                                                     
    }

#line default
#line hidden
            BeginContext(564, 4701, true);
            WriteLiteral(@"</div>
<div class=""row"">
    <div class=""col-sm-11 about"">
        <h2>About</h2>
        <hr class=""menu-hr"" />
        <div>
            <h4>COEXP WEBPAGE</h4><br />
            <p>
                CoExp WebPage is a webpage tool developed in .NET Core Framework, for the easy use of <a href=""https://github.com/juanbot/CoExpNets"" target=""_blank"" title=""CoExp R suite-of-packages available on GitHub"">CoExp R suit-of-packages</a> (author: Juan A. Botía) - a framework for the generation, deployment,
                sharing and exploitation of co-expression networks as annotation models of genes and their role in transcription. <br /> We decided to build a web-based UI for the the easy use of CoExp R suit-of-packages
                because it is undeniable that a web-page format is the most well-known and accepted way of browsing the Internet around the world. In this sense, we believe that a web-page structure will make CoExp's networks
                easily accessible to every potential user around");
            WriteLiteral(@" the world, at any time and from anywhere they decide to do so.
            </p>

            <br /><h4>DEVELOPERS</h4><br />
            <p>
                The User Interface (UI) of CoExp WebPage has been fully developed by <a href=""http://www.rytenlab.com/RytenLab/MemberInfo?Id=LO96_F34158"" target=""_blank"" title=""Link to visit Sonia García-Ruiz profile"">Sonia García-Ruiz</a>.
                She is a PhD student, part of the <a href=""http://www.rytenlab.com/RytenLab/"" target=""_blank"" title=""Link to visit RytenLab group webpage"">RytenLab</a> group, and the WebMaster of CoExp WebPage. For any queries and suggestions related to the CoExp WebPage,
                you can reach Sonia at <a href=""mailto:s.ruiz@ucl.ac.uk"">s.ruiz@ucl.ac.uk</a>.
                <br />
                On the other hand, CoExp R suit-of-packages has been fully developed by <a href=""http://www.rytenlab.com/RytenLab/MemberInfo?Id=BP98-F74160"" target=""_blank"" title=""Link to visit Juan A. Botía profile"">Juan A. Botía</a>.
    ");
            WriteLiteral(@"            He is also a member of the Ryten Lab group, and Professor at University of Murcia. You can reach Prof. Botía at <a href=""mailto:juanbotiablaya@gmail.com"">juanbotiablaya@gmail.com</a>.
                In addition, Juan A. Botía coordinates the hosting of CoExp WebPage, which is fully allocated at <a href=""http://www.um.es"" target=""_blank"">University of Murcia</a>.
                <br />
                Finally, the brain behind this whole idea and the person who made this software possible is <a href=""http://www.rytenlab.com/RytenLab/MemberInfo?Id=8774A_!52101"" target=""_blank"" title=""Link to visit Mina Ryten profile"">Mina Ryten</a>,
                a co-expression networks guru and the head of <a href=""http://www.rytenlab.com/RytenLab/"" target=""_blank"" title=""Link to visit RytenLab group webpage"">RytenLab</a> group.
            </p>

            <br /><h4>COEXP ON GITHUB</h4><br />
            <p>
                CoExp WebPage is available to be downloaded on <a href=""https://github.com/So");
            WriteLiteral(@"niaRuiz/CoExp_Web"" target=""_blank"" title=""CoExp available on GitHub"">GitHub</a>.
                <a href=""https://github.com/SoniaRuiz/CoExp_Web/wiki"" target=""_blank"" title=""Tutorial about how to install CoExp within a Linux environment"">Here</a>, you can also find a tutorial explaining how to download, buid and configure CoExp WebPage within a Linux environment.
                <br />
                CoExp R suite-of-packages (autor: Juan A. Botía) is also available on <a href=""https://github.com/juanbot/CoExpNets"" target=""_blank"" title=""CoExp R suite-of-packages available on GitHub"">GitHub</a>.
            </p>

            <br /><h4>FURTHER DETAILS</h4><br />
            <p>
                <b>Version:</b> CoExp v2.0.1 <br>
                <b>Authors:</b>
                <span class=""author""><a href=""http://www.rytenlab.com/RytenLab/MemberInfo?Id=LO96_F34158"" target=""_blank"" title=""Sonia García-Ruiz"">Sonia García-Ruiz</a></span>,
                <span class=""author""><a href=""http://www.rytenlab.");
            WriteLiteral(@"com/RytenLab/MemberInfo?Id=BP98-F74160"" target=""_blank"" title=""Juan A. Botía"">Juan A. Botía</a></span> and
                <span class=""author""><a href=""http://www.rytenlab.com/RytenLab/MemberInfo?Id=8774A_!52101"" target=""_blank"" title=""Mina Ryten"">Mina Ryten</a></span>
                <br>
                <b>RytenLab HomePage:</b> <a href=""http://www.rytenlab.com/"" target=""_blank"">http://www.rytenlab.com/</a>
            </p>
            <hr />
            <div>
                <a href=""https://www.ucl.ac.uk/"" target=""_blank"" title=""Go to University College of London"">
                    ");
            EndContext();
            BeginContext(5265, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e14190894e3242dba1ddd3f45717c1d1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5315, 118, true);
            WriteLiteral("\r\n                </a>\r\n                <a href=\"http://www.um.es\" target=\"_blank\" title=\"Go to University of Murcia\">");
            EndContext();
            BeginContext(5433, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "157762d2e4214397ad0acc1dd29e2b2d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5481, 28, true);
            WriteLiteral("</a>\r\n            </div>\r\n\r\n");
            EndContext();
            BeginContext(5619, 44, true);
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5680, 250, true);
                WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n    $(document).ready(function () {\r\n        // Turn active current menu\'s option\r\n        $(\".nav-item\").find(\".active\").removeClass(\"active\");\r\n        $(\"#tab_about\").addClass(\"active\");\r\n    });\r\n\r\n</script>\r\n");
                EndContext();
            }
            );
            BeginContext(5933, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
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
