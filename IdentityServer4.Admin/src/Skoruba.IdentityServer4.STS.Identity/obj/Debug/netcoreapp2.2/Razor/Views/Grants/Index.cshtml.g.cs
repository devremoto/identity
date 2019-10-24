#pragma checksum "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ff37ba56c49b2b92450421a6ffef4ee68a64e4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grants_Index), @"mvc.1.0.view", @"/Views/Grants/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grants/Index.cshtml", typeof(AspNetCore.Views_Grants_Index))]
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
#line 1 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ff37ba56c49b2b92450421a6ffef4ee68a64e4b", @"/Views/Grants/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28e5beff1cf1bbea99515e61bb4d8266ea1e24ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Grants_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Skoruba.IdentityServer4.STS.Identity.ViewModels.Grants.GrantsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Revoke", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(156, 101, true);
            WriteLiteral("\n<div class=\"grants-container\">\n\t<div class=\"row page-header\">\n\t\t<div class=\"col-sm-10\">\n\t\t\t<h1>\n\t\t\t\t");
            EndContext();
            BeginContext(258, 18, false);
#line 9 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
           Write(Localizer["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(276, 18, true);
            WriteLiteral("\n\t\t\t</h1>\n\t\t\t<div>");
            EndContext();
            BeginContext(295, 21, false);
#line 11 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
            Write(Localizer["SubTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(316, 25, true);
            WriteLiteral("</div>\n\t\t</div>\n\t</div>\n\n");
            EndContext();
#line 15 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
     if (Model.Grants.Any() == false)
	{

#line default
#line hidden
            BeginContext(379, 86, true);
            WriteLiteral("\t\t<div class=\"row\">\n\t\t\t<div class=\"col-sm-8\">\n\t\t\t\t<div class=\"alert alert-info\">\n\t\t\t\t\t");
            EndContext();
            BeginContext(466, 21, false);
#line 20 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
               Write(Localizer["NoGrants"]);

#line default
#line hidden
            EndContext();
            BeginContext(487, 31, true);
            WriteLiteral("\n\t\t\t\t</div>\n\t\t\t</div>\n\t\t</div>\n");
            EndContext();
#line 24 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
	}
	else
	{
		foreach (var grant in Model.Grants)
		{

#line default
#line hidden
            BeginContext(572, 54, true);
            WriteLiteral("\t\t\t<div class=\"row grant\">\n\t\t\t\t<div class=\"col-sm-2\">\n");
            EndContext();
#line 31 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                     if (grant.ClientLogoUrl != null)
					{

#line default
#line hidden
            BeginContext(672, 10, true);
            WriteLiteral("\t\t\t\t\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 682, "\"", 708, 1);
#line 33 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
WriteAttributeValue("", 688, grant.ClientLogoUrl, 688, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(709, 2, true);
            WriteLiteral(">\n");
            EndContext();
#line 34 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
					}

#line default
#line hidden
            BeginContext(718, 67, true);
            WriteLiteral("\t\t\t\t</div>\n\t\t\t\t<div class=\"col-sm-8\">\n\t\t\t\t\t<div class=\"clientname\">");
            EndContext();
            BeginContext(786, 16, false);
#line 37 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                                       Write(grant.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(802, 46, true);
            WriteLiteral("</div>\n\t\t\t\t\t<div>\n\t\t\t\t\t\t<span class=\"created\">");
            EndContext();
            BeginContext(849, 20, false);
#line 39 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                                         Write(Localizer["Created"]);

#line default
#line hidden
            EndContext();
            BeginContext(869, 8, true);
            WriteLiteral("</span> ");
            EndContext();
            BeginContext(878, 36, false);
#line 39 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                                                                      Write(grant.Created.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(914, 13, true);
            WriteLiteral("\n\t\t\t\t\t</div>\n");
            EndContext();
#line 41 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                     if (grant.Expires.HasValue)
					{

#line default
#line hidden
            BeginContext(968, 41, true);
            WriteLiteral("\t\t\t\t\t\t<div>\n\t\t\t\t\t\t\t<span class=\"expires\">");
            EndContext();
            BeginContext(1010, 20, false);
#line 44 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                                             Write(Localizer["Expires"]);

#line default
#line hidden
            EndContext();
            BeginContext(1030, 8, true);
            WriteLiteral("</span> ");
            EndContext();
            BeginContext(1039, 42, false);
#line 44 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                                                                          Write(grant.Expires.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 14, true);
            WriteLiteral("\n\t\t\t\t\t\t</div>\n");
            EndContext();
#line 46 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
					}

#line default
#line hidden
            BeginContext(1102, 5, true);
            WriteLiteral("\t\t\t\t\t");
            EndContext();
#line 47 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                     if (grant.IdentityGrantNames.Any())
					{

#line default
#line hidden
            BeginContext(1151, 42, true);
            WriteLiteral("\t\t\t\t\t\t<div>\n\t\t\t\t\t\t\t<div class=\"granttype\">");
            EndContext();
            BeginContext(1194, 27, false);
#line 50 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                                              Write(Localizer["IdentityGrants"]);

#line default
#line hidden
            EndContext();
            BeginContext(1221, 19, true);
            WriteLiteral("</div>\n\t\t\t\t\t\t\t<ul>\n");
            EndContext();
#line 52 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                                 foreach (var name in grant.IdentityGrantNames)
								{

#line default
#line hidden
            BeginContext(1306, 13, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<li>");
            EndContext();
            BeginContext(1320, 4, false);
#line 54 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                                   Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(1324, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 55 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
								}

#line default
#line hidden
            BeginContext(1340, 26, true);
            WriteLiteral("\t\t\t\t\t\t\t</ul>\n\t\t\t\t\t\t</div>\n");
            EndContext();
#line 58 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
					}

#line default
#line hidden
            BeginContext(1373, 5, true);
            WriteLiteral("\t\t\t\t\t");
            EndContext();
#line 59 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                     if (grant.ApiGrantNames.Any())
					{

#line default
#line hidden
            BeginContext(1417, 42, true);
            WriteLiteral("\t\t\t\t\t\t<div>\n\t\t\t\t\t\t\t<div class=\"granttype\">");
            EndContext();
            BeginContext(1460, 22, false);
#line 62 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                                              Write(Localizer["ApiGrants"]);

#line default
#line hidden
            EndContext();
            BeginContext(1482, 19, true);
            WriteLiteral("</div>\n\t\t\t\t\t\t\t<ul>\n");
            EndContext();
#line 64 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                                 foreach (var name in grant.ApiGrantNames)
								{

#line default
#line hidden
            BeginContext(1562, 13, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<li>");
            EndContext();
            BeginContext(1576, 4, false);
#line 66 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                                   Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(1580, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 67 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
								}

#line default
#line hidden
            BeginContext(1596, 26, true);
            WriteLiteral("\t\t\t\t\t\t\t</ul>\n\t\t\t\t\t\t</div>\n");
            EndContext();
#line 70 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
					}

#line default
#line hidden
            BeginContext(1629, 43, true);
            WriteLiteral("\t\t\t\t</div>\n\t\t\t\t<div class=\"col-sm-2\">\n\t\t\t\t\t");
            EndContext();
            BeginContext(1672, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ff37ba56c49b2b92450421a6ffef4ee68a64e4b14164", async() => {
                BeginContext(1698, 43, true);
                WriteLiteral("\n\t\t\t\t\t\t<input type=\"hidden\" name=\"clientId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1741, "\"", 1764, 1);
#line 74 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
WriteAttributeValue("", 1749, grant.ClientId, 1749, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1765, 39, true);
                WriteLiteral(">\n\t\t\t\t\t\t<button class=\"btn btn-danger\">");
                EndContext();
                BeginContext(1805, 25, false);
#line 75 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
                                                  Write(Localizer["RevokeAccess"]);

#line default
#line hidden
                EndContext();
                BeginContext(1830, 15, true);
                WriteLiteral("</button>\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1852, 22, true);
            WriteLiteral("\n\t\t\t\t</div>\n\t\t\t</div>\n");
            EndContext();
#line 79 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Grants\Index.cshtml"
		}
	}

#line default
#line hidden
            BeginContext(1881, 6, true);
            WriteLiteral("</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Skoruba.IdentityServer4.STS.Identity.ViewModels.Grants.GrantsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
