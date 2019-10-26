#pragma checksum "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9af17ae533a1d7a9a2de7375d9b84fdc1697956f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Common_Notification), @"mvc.1.0.view", @"/Views/Shared/Common/Notification.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Common/Notification.cshtml", typeof(AspNetCore.Views_Shared_Common_Notification))]
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
#line 1 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 2 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
using Skoruba.IdentityServer4.Admin.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9af17ae533a1d7a9a2de7375d9b84fdc1697956f", @"/Views/Shared/Common/Notification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef0c9e2904c50fcb45af80d4002c5716cb46aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Common_Notification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
 if (ViewBag.Notifications != null)
{
	var settings = new JsonSerializerSettings
	{
		TypeNameHandling = TypeNameHandling.All
	};

	var obj = JsonConvert.DeserializeObject<List<NotificationHelpers.Alert>>(ViewBag.Notifications, settings);

	foreach (NotificationHelpers.Alert notification in obj)
	{
		switch (notification.Type)
		{
			case NotificationHelpers.AlertType.Success:

#line default
#line hidden
            BeginContext(448, 86, true);
            WriteLiteral("\t\t\t\t<script type=\"text/javascript\">toastr.options.closeButton = true; toastr.success(\'");
            EndContext();
            BeginContext(535, 20, false);
#line 17 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
                                                                                             Write(notification.Message);

#line default
#line hidden
            EndContext();
            BeginContext(555, 4, true);
            WriteLiteral("\', \'");
            EndContext();
            BeginContext(560, 18, false);
#line 17 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
                                                                                                                      Write(notification.Title);

#line default
#line hidden
            EndContext();
            BeginContext(578, 13, true);
            WriteLiteral("\');</script>\n");
            EndContext();
#line 18 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
				break;
			case NotificationHelpers.AlertType.Error:

#line default
#line hidden
            BeginContext(647, 49, true);
            WriteLiteral("\t\t\t\t<script type=\"text/javascript\">toastr.error(\'");
            EndContext();
            BeginContext(697, 20, false);
#line 20 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
                                                        Write(notification.Message);

#line default
#line hidden
            EndContext();
            BeginContext(717, 4, true);
            WriteLiteral("\', \'");
            EndContext();
            BeginContext(722, 18, false);
#line 20 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
                                                                                 Write(notification.Title);

#line default
#line hidden
            EndContext();
            BeginContext(740, 13, true);
            WriteLiteral("\');</script>\n");
            EndContext();
#line 21 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
				break;
			case NotificationHelpers.AlertType.Info:

#line default
#line hidden
            BeginContext(808, 83, true);
            WriteLiteral("\t\t\t\t<script type=\"text/javascript\">toastr.options.closeButton = true; toastr.info(\'");
            EndContext();
            BeginContext(892, 20, false);
#line 23 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
                                                                                          Write(notification.Message);

#line default
#line hidden
            EndContext();
            BeginContext(912, 4, true);
            WriteLiteral("\', \'");
            EndContext();
            BeginContext(917, 18, false);
#line 23 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
                                                                                                                   Write(notification.Title);

#line default
#line hidden
            EndContext();
            BeginContext(935, 13, true);
            WriteLiteral("\');</script>\n");
            EndContext();
#line 24 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
				break;
			case NotificationHelpers.AlertType.Warning:

#line default
#line hidden
            BeginContext(1006, 86, true);
            WriteLiteral("\t\t\t\t<script type=\"text/javascript\">toastr.options.closeButton = true; toastr.warning(\'");
            EndContext();
            BeginContext(1093, 20, false);
#line 26 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
                                                                                             Write(notification.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1113, 4, true);
            WriteLiteral("\', \'");
            EndContext();
            BeginContext(1118, 18, false);
#line 26 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
                                                                                                                      Write(notification.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1136, 13, true);
            WriteLiteral("\');</script>\n");
            EndContext();
#line 27 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Shared/Common/Notification.cshtml"
				break;
		}
	}
}

#line default
#line hidden
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
