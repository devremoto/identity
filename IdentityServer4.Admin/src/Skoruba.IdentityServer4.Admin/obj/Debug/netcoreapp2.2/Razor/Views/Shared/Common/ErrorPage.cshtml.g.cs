#pragma checksum "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Shared\Common\ErrorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fcb58a3120cb631d1954f5081247e678a57de5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Common_ErrorPage), @"mvc.1.0.view", @"/Views/Shared/Common/ErrorPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Common/ErrorPage.cshtml", typeof(AspNetCore.Views_Shared_Common_ErrorPage))]
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
#line 1 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Shared\Common\ErrorPage.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 2 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Shared\Common\ErrorPage.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 3 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Shared\Common\ErrorPage.cshtml"
using Skoruba.IdentityServer4.Admin.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fcb58a3120cb631d1954f5081247e678a57de5e", @"/Views/Shared/Common/ErrorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef0c9e2904c50fcb45af80d4002c5716cb46aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Common_ErrorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Shared\Common\ErrorPage.cshtml"
  
	ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(181, 25, true);
            WriteLiteral("\n<h1 class=\"text-danger\">");
            EndContext();
            BeginContext(207, 22, false);
#line 9 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Shared\Common\ErrorPage.cshtml"
                   Write(Localizer["PageTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(229, 7, true);
            WriteLiteral("</h1>\n\n");
            EndContext();
#line 11 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Shared\Common\ErrorPage.cshtml"
 if (ViewBag.Notifications != null)
{
	var settings = new JsonSerializerSettings
	{
		TypeNameHandling = TypeNameHandling.All
	};

	var obj = JsonConvert.DeserializeObject<List<NotificationHelpers.Alert>>(ViewBag.Notifications, settings);

	foreach (NotificationHelpers.Alert notification in obj)
	{

#line default
#line hidden
            BeginContext(536, 26, true);
            WriteLiteral("\t\t<h2 class=\"text-danger\">");
            EndContext();
            BeginContext(563, 20, false);
#line 22 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Shared\Common\ErrorPage.cshtml"
                           Write(notification.Message);

#line default
#line hidden
            EndContext();
            BeginContext(583, 6, true);
            WriteLiteral("</h2>\n");
            EndContext();
#line 23 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Shared\Common\ErrorPage.cshtml"
	}
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
