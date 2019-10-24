#pragma checksum "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "750409eae9c4192e14348376d8075d32016b5bc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Log_ErrorsLog), @"mvc.1.0.view", @"/Views/Log/ErrorsLog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Log/ErrorsLog.cshtml", typeof(AspNetCore.Views_Log_ErrorsLog))]
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
#line 1 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 2 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
using Skoruba.IdentityServer4.Admin.BusinessLogic.Shared.Dtos.Common;

#line default
#line hidden
#line 3 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
using Skoruba.IdentityServer4.Admin.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"750409eae9c4192e14348376d8075d32016b5bc4", @"/Views/Log/ErrorsLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef0c9e2904c50fcb45af80d4002c5716cb46aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Log_ErrorsLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Log.LogsDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(261, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 7 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
  
	ViewBag.Title = Localizer["PageTitle"];
	Layout = "_Layout";

#line default
#line hidden
            BeginContext(329, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(335, 22, false);
#line 12 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
Write(Localizer["PageTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(357, 49, true);
            WriteLiteral("</h2>\n\n<div class=\"row\">\n\t<div class=\"col-12\">\n\t\t");
            EndContext();
            BeginContext(407, 97, false);
#line 16 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
   Write(await Html.PartialAsync("Common/Search", new Search { Action = "ErrorsLog", Controller = "Log" }));

#line default
#line hidden
            EndContext();
            BeginContext(504, 177, true);
            WriteLiteral("\n\t</div>\n</div>\n\n<div class=\"row\">\n\t<div class=\"col-12\">\n\t\t<div class=\"table-responsive\">\n\t\t\t<table class=\"table table-striped\">\n\t\t\t\t<thead>\n\t\t\t\t\t<tr>\n\t\t\t\t\t\t<th></th>\n\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(682, 23, false);
#line 27 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
                       Write(Localizer["TableLevel"]);

#line default
#line hidden
            EndContext();
            BeginContext(705, 16, true);
            WriteLiteral("</th>\n\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(722, 24, false);
#line 28 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
                       Write(Localizer["TableLogged"]);

#line default
#line hidden
            EndContext();
            BeginContext(746, 16, true);
            WriteLiteral("</th>\n\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(763, 25, false);
#line 29 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
                       Write(Localizer["TableMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(788, 42, true);
            WriteLiteral("</th>\n\t\t\t\t\t</tr>\n\t\t\t\t</thead>\n\t\t\t\t<tbody>\n");
            EndContext();
#line 33 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
                     foreach (var client in Model.Logs)
					{

#line default
#line hidden
            BeginContext(878, 49, true);
            WriteLiteral("\t\t\t\t\t\t<tr>\n\t\t\t\t\t\t\t<td><a href=\"#\" data-error-id=\"");
            EndContext();
            BeginContext(928, 9, false);
#line 36 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
                                                      Write(client.Id);

#line default
#line hidden
            EndContext();
            BeginContext(937, 43, true);
            WriteLiteral("\" class=\"btn btn-primary btn-error-detail\">");
            EndContext();
            BeginContext(981, 28, false);
#line 36 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
                                                                                                           Write(Localizer["TableShowDetail"]);

#line default
#line hidden
            EndContext();
            BeginContext(1009, 21, true);
            WriteLiteral("</a></td>\n\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1031, 12, false);
#line 37 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
                           Write(client.Level);

#line default
#line hidden
            EndContext();
            BeginContext(1043, 54, true);
            WriteLiteral("</td>\n\t\t\t\t\t\t\t<td>\n\t\t\t\t\t\t\t\t<span class=\"local-datetime\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1097, "\"", 1122, 1);
#line 39 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
WriteAttributeValue("", 1105, client.TimeStamp, 1105, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1123, 11, true);
            WriteLiteral(" data-utc=\"");
            EndContext();
            BeginContext(1135, 32, false);
#line 39 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
                                                                                            Write(client.TimeStamp.GetEpochTicks());

#line default
#line hidden
            EndContext();
            BeginContext(1167, 55, true);
            WriteLiteral("\" data-toggle=\"tooltip\" data-placement=\"top\">\n\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1223, 16, false);
#line 40 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
                               Write(client.TimeStamp);

#line default
#line hidden
            EndContext();
            BeginContext(1239, 58, true);
            WriteLiteral("\n\t\t\t\t\t\t\t\t</span>\t\t\t\t\t\t\t\t\n\t\t\t\t\t\t\t\t<span class=\"oi oi-clock\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1297, "\"", 1322, 1);
#line 42 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
WriteAttributeValue("", 1305, client.TimeStamp, 1305, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1323, 76, true);
            WriteLiteral(" data-toggle=\"tooltip\" data-placement=\"top\"></span>\n\t\t\t\t\t\t\t</td>\n\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1400, 14, false);
#line 44 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
                           Write(client.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1414, 75, true);
            WriteLiteral("</td>\n\t\t\t\t\t\t</tr>\n\t\t\t\t\t\t<tr class=\"row-error-detail d-none\" data-error-id=\"");
            EndContext();
            BeginContext(1490, 9, false);
#line 46 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
                                                                      Write(client.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1499, 43, true);
            WriteLiteral("\">\n\t\t\t\t\t\t\t<td colspan=\"4\" data-error-json=\"");
            EndContext();
            BeginContext(1543, 15, false);
#line 47 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
                                                        Write(client.LogEvent);

#line default
#line hidden
            EndContext();
            BeginContext(1558, 20, true);
            WriteLiteral("\"></td>\n\t\t\t\t\t\t</tr>\n");
            EndContext();
#line 49 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
					}

#line default
#line hidden
            BeginContext(1585, 92, true);
            WriteLiteral("\t\t\t\t</tbody>\n\t\t\t</table>\n\t\t</div>\n\t</div>\n</div>\n\n<div class=\"row\">\n\t<div class=\"col-12\">\n\t\t");
            EndContext();
            BeginContext(1678, 179, false);
#line 58 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Log\ErrorsLog.cshtml"
   Write(await Html.PartialAsync("Common/Pager", new Pager { Action = "ErrorsLog", PageSize = Model.PageSize, TotalCount = Model.TotalCount, EnableSearch = true, Search = ViewBag.Search }));

#line default
#line hidden
            EndContext();
            BeginContext(1857, 15, true);
            WriteLiteral("\n\t</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Log.LogsDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
