#pragma checksum "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "018d85dadb84662da8769623aefba7262898d305"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Configuration_Client_Settings), @"mvc.1.0.view", @"/Views/Configuration/Client/Settings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Configuration/Client/Settings.cshtml", typeof(AspNetCore.Views_Configuration_Client_Settings))]
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
#line 1 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"018d85dadb84662da8769623aefba7262898d305", @"/Views/Configuration/Client/Settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef0c9e2904c50fcb45af80d4002c5716cb46aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Configuration_Client_Settings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration.ClientDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(158, 50, true);
            WriteLiteral("\n<div class=\"row\">\n\t<div class=\"col-md-12\">\n\t\t<h3>");
            EndContext();
            BeginContext(209, 18, false);
#line 7 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
       Write(Localizer["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(227, 227, true);
            WriteLiteral("</h3>\n\t\t<nav>\n\t\t\t<div class=\"nav nav-tabs mt-3\" id=\"nav-tab\" role=\"tablist\">\n\t\t\t\t<a class=\"nav-item nav-link active\" id=\"nav-name-tab\" data-toggle=\"tab\" href=\"#nav-name\" role=\"tab\" aria-controls=\"nav-name\" aria-selected=\"true\">");
            EndContext();
            BeginContext(455, 20, false);
#line 10 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
                                                                                                                                                             Write(Localizer["NavName"]);

#line default
#line hidden
            EndContext();
            BeginContext(475, 5, true);
            WriteLiteral("</a>\n");
            EndContext();
#line 11 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
                 if (Model.Id != 0)
				{

#line default
#line hidden
            BeginContext(510, 151, true);
            WriteLiteral("\t\t\t\t\t<a class=\"nav-item nav-link\" id=\"nav-basics-tab\" data-toggle=\"tab\" href=\"#nav-basics\" role=\"tab\" aria-controls=\"nav-basics\" aria-selected=\"false\">");
            EndContext();
            BeginContext(662, 22, false);
#line 13 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
                                                                                                                                                                 Write(Localizer["NavBasics"]);

#line default
#line hidden
            EndContext();
            BeginContext(684, 180, true);
            WriteLiteral("</a>\n\t\t\t\t\t<a class=\"nav-item nav-link\" id=\"nav-authentication-tab\" data-toggle=\"tab\" href=\"#nav-authentication\" role=\"tab\" aria-controls=\"nav-authentication\" aria-selected=\"false\">");
            EndContext();
            BeginContext(865, 30, false);
#line 14 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
                                                                                                                                                                                         Write(Localizer["NavAuthentication"]);

#line default
#line hidden
            EndContext();
            BeginContext(895, 153, true);
            WriteLiteral("</a>\n\t\t\t\t\t<a class=\"nav-item nav-link\" id=\"nav-token-tab\" data-toggle=\"tab\" href=\"#nav-token\" role=\"tab\" aria-controls=\"nav-token\" aria-selected=\"false\">");
            EndContext();
            BeginContext(1049, 21, false);
#line 15 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
                                                                                                                                                              Write(Localizer["NavToken"]);

#line default
#line hidden
            EndContext();
            BeginContext(1070, 159, true);
            WriteLiteral("</a>\n\t\t\t\t\t<a class=\"nav-item nav-link\" id=\"nav-consent-tab\" data-toggle=\"tab\" href=\"#nav-consent\" role=\"tab\" aria-controls=\"nav-consent\" aria-selected=\"false\">");
            EndContext();
            BeginContext(1230, 23, false);
#line 16 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
                                                                                                                                                                    Write(Localizer["NavConsent"]);

#line default
#line hidden
            EndContext();
            BeginContext(1253, 168, true);
            WriteLiteral("</a>\n\t\t\t\t\t<a class=\"nav-item nav-link\" id=\"nav-deviceflow-tab\" data-toggle=\"tab\" href=\"#nav-deviceflow\" role=\"tab\" aria-controls=\"nav-deviceflow\" aria-selected=\"false\">");
            EndContext();
            BeginContext(1422, 26, false);
#line 17 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
                                                                                                                                                                             Write(Localizer["NavDeviceFlow"]);

#line default
#line hidden
            EndContext();
            BeginContext(1448, 5, true);
            WriteLiteral("</a>\n");
            EndContext();
#line 18 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
				}

#line default
#line hidden
            BeginContext(1459, 170, true);
            WriteLiteral("\t\t\t</div>\n\t\t</nav>\n\t\t<div class=\"tab-content\" id=\"nav-tabContent\">\n\t\t\t<div class=\"tab-pane show active\" id=\"nav-name\" role=\"tabpanel\" aria-labelledby=\"nav-name-tab\">\n\t\t\t\t");
            EndContext();
            BeginContext(1630, 46, false);
#line 23 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
           Write(await Html.PartialAsync("Client/Section/Name"));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 12, true);
            WriteLiteral("\n\t\t\t</div>\n\n");
            EndContext();
#line 26 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
             if (Model.Id != 0)
			{

#line default
#line hidden
            BeginContext(1716, 97, true);
            WriteLiteral("\t\t\t\t<div class=\"tab-pane\" id=\"nav-basics\" role=\"tabpanel\" aria-labelledby=\"nav-basics-tab\">\n\t\t\t\t\t");
            EndContext();
            BeginContext(1814, 48, false);
#line 29 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
               Write(await Html.PartialAsync("Client/Section/Basics"));

#line default
#line hidden
            EndContext();
            BeginContext(1862, 12, true);
            WriteLiteral("\n\t\t\t\t</div>\n");
            EndContext();
            BeginContext(1875, 113, true);
            WriteLiteral("\t\t\t\t<div class=\"tab-pane\" id=\"nav-authentication\" role=\"tabpanel\" aria-labelledby=\"nav-authentication-tab\">\n\t\t\t\t\t");
            EndContext();
            BeginContext(1989, 56, false);
#line 33 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
               Write(await Html.PartialAsync("Client/Section/Authentication"));

#line default
#line hidden
            EndContext();
            BeginContext(2045, 107, true);
            WriteLiteral("\n\t\t\t\t</div>\n\t\t\t\t<div class=\"tab-pane\" id=\"nav-token\" role=\"tabpanel\" aria-labelledby=\"nav-token-tab\">\n\t\t\t\t\t");
            EndContext();
            BeginContext(2153, 47, false);
#line 36 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
               Write(await Html.PartialAsync("Client/Section/Token"));

#line default
#line hidden
            EndContext();
            BeginContext(2200, 111, true);
            WriteLiteral("\n\t\t\t\t</div>\n\t\t\t\t<div class=\"tab-pane\" id=\"nav-consent\" role=\"tabpanel\" aria-labelledby=\"nav-consent-tab\">\n\t\t\t\t\t");
            EndContext();
            BeginContext(2312, 49, false);
#line 39 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
               Write(await Html.PartialAsync("Client/Section/Consent"));

#line default
#line hidden
            EndContext();
            BeginContext(2361, 117, true);
            WriteLiteral("\n\t\t\t\t</div>\n\t\t\t\t<div class=\"tab-pane\" id=\"nav-deviceflow\" role=\"tabpanel\" aria-labelledby=\"nav-deviceflow-tab\">\n\t\t\t\t\t");
            EndContext();
            BeginContext(2479, 52, false);
#line 42 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
               Write(await Html.PartialAsync("Client/Section/DeviceFlow"));

#line default
#line hidden
            EndContext();
            BeginContext(2531, 12, true);
            WriteLiteral("\n\t\t\t\t</div>\n");
            EndContext();
#line 44 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Configuration\Client\Settings.cshtml"
			}

#line default
#line hidden
            BeginContext(2548, 24, true);
            WriteLiteral("\t\t</div>\n\t</div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration.ClientDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
