#pragma checksum "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1c275cf89590d9b62671d7149a14c2616c08b38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grant_PersistedGrant), @"mvc.1.0.view", @"/Views/Grant/PersistedGrant.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grant/PersistedGrant.cshtml", typeof(AspNetCore.Views_Grant_PersistedGrant))]
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
#line 1 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 2 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
using Skoruba.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Grant;

#line default
#line hidden
#line 3 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
using Skoruba.IdentityServer4.Admin.Helpers;

#line default
#line hidden
#line 4 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
using Skoruba.IdentityServer4.Admin.BusinessLogic.Shared.Dtos.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1c275cf89590d9b62671d7149a14c2616c08b38", @"/Views/Grant/PersistedGrant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef0c9e2904c50fcb45af80d4002c5716cb46aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Grant_PersistedGrant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersistedGrantsDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Grant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PersistedGrants", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PersistedGrantDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("client-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PersistedGrantsDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(290, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 8 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
  
	ViewBag.Title = Localizer["PageTitle"];
	Layout = "_Layout";

#line default
#line hidden
            BeginContext(358, 132, true);
            WriteLiteral("\n<div class=\"row\">\n\t<div class=\"col-12\">\n\t\t<nav aria-label=\"breadcrumb\">\n\t\t\t<ol class=\"breadcrumb\">\n\t\t\t\t<li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(490, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1c275cf89590d9b62671d7149a14c2616c08b387326", async() => {
                BeginContext(546, 38, false);
#line 17 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                                                                                              Write(Localizer["NavigationPersistedGrants"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(588, 65, true);
            WriteLiteral("</li>\n\t\t\t\t<li class=\"breadcrumb-item active\" aria-current=\"page\">");
            EndContext();
            BeginContext(654, 15, false);
#line 18 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                                                                  Write(Model.SubjectId);

#line default
#line hidden
            EndContext();
            BeginContext(669, 61, true);
            WriteLiteral("</li>\n\t\t\t</ol>\n\t\t</nav>\n\t</div>\n\n\t<div class=\"col-12\">\n\t\t<h2>");
            EndContext();
            BeginContext(731, 22, false);
#line 24 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
       Write(Localizer["PageTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(753, 22, true);
            WriteLiteral("</h2>\n\t</div>\n</div>\n\n");
            EndContext();
            BeginContext(775, 2263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1c275cf89590d9b62671d7149a14c2616c08b3810144", async() => {
                BeginContext(870, 105, true);
                WriteLiteral("\n\n\t<a href=\"#\" class=\"btn btn-danger mb-3\" data-toggle=\"modal\" data-target=\"#deletePersistedGrantsModal\">");
                EndContext();
                BeginContext(976, 28, false);
#line 30 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                                                                                                     Write(Localizer["ButtonDeleteAll"]);

#line default
#line hidden
                EndContext();
                BeginContext(1004, 23, true);
                WriteLiteral("</a>\n\n\t<!--Hidden -->\n\t");
                EndContext();
                BeginContext(1027, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c1c275cf89590d9b62671d7149a14c2616c08b3811164", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 33 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubjectId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1070, 132, true);
                WriteLiteral("\n\n\t<div class=\"row table-responsive\">\n\t\t<div class=\"col-12\">\n\t\t\t<table class=\"table table-striped\">\n\t\t\t\t<thead>\n\t\t\t\t\t<tr>\n\t\t\t\t\t\t<th>");
                EndContext();
                BeginContext(1203, 27, false);
#line 40 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                       Write(Localizer["TableSubjectId"]);

#line default
#line hidden
                EndContext();
                BeginContext(1230, 16, true);
                WriteLiteral("</th>\n\t\t\t\t\t\t<th>");
                EndContext();
                BeginContext(1247, 22, false);
#line 41 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                       Write(Localizer["TableType"]);

#line default
#line hidden
                EndContext();
                BeginContext(1269, 16, true);
                WriteLiteral("</th>\n\t\t\t\t\t\t<th>");
                EndContext();
                BeginContext(1286, 28, false);
#line 42 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                       Write(Localizer["TableExpiration"]);

#line default
#line hidden
                EndContext();
                BeginContext(1314, 16, true);
                WriteLiteral("</th>\n\t\t\t\t\t\t<th>");
                EndContext();
                BeginContext(1331, 22, false);
#line 43 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                       Write(Localizer["TableData"]);

#line default
#line hidden
                EndContext();
                BeginContext(1353, 16, true);
                WriteLiteral("</th>\n\t\t\t\t\t\t<th>");
                EndContext();
                BeginContext(1370, 24, false);
#line 44 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                       Write(Localizer["TableClient"]);

#line default
#line hidden
                EndContext();
                BeginContext(1394, 59, true);
                WriteLiteral("</th>\n\t\t\t\t\t\t<th></th>\n\t\t\t\t\t</tr>\n\t\t\t\t</thead>\n\n\t\t\t\t<tbody>\n");
                EndContext();
#line 50 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                     foreach (var persistedGrant in Model.PersistedGrants)
					{

#line default
#line hidden
                BeginContext(1520, 22, true);
                WriteLiteral("\t\t\t\t\t\t<tr>\n\t\t\t\t\t\t\t<td>");
                EndContext();
                BeginContext(1543, 24, false);
#line 53 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                           Write(persistedGrant.SubjectId);

#line default
#line hidden
                EndContext();
                BeginContext(1567, 17, true);
                WriteLiteral("</td>\n\t\t\t\t\t\t\t<td>");
                EndContext();
                BeginContext(1585, 19, false);
#line 54 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                           Write(persistedGrant.Type);

#line default
#line hidden
                EndContext();
                BeginContext(1604, 17, true);
                WriteLiteral("</td>\n\t\t\t\t\t\t\t<td>");
                EndContext();
                BeginContext(1622, 25, false);
#line 55 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                           Write(persistedGrant.Expiration);

#line default
#line hidden
                EndContext();
                BeginContext(1647, 17, true);
                WriteLiteral("</td>\n\t\t\t\t\t\t\t<td>");
                EndContext();
                BeginContext(1665, 19, false);
#line 56 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                           Write(persistedGrant.Data);

#line default
#line hidden
                EndContext();
                BeginContext(1684, 17, true);
                WriteLiteral("</td>\n\t\t\t\t\t\t\t<td>");
                EndContext();
                BeginContext(1702, 23, false);
#line 57 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                           Write(persistedGrant.ClientId);

#line default
#line hidden
                EndContext();
                BeginContext(1725, 17, true);
                WriteLiteral("</td>\n\t\t\t\t\t\t\t<td>");
                EndContext();
                BeginContext(1742, 160, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1c275cf89590d9b62671d7149a14c2616c08b3818092", async() => {
                    BeginContext(1869, 29, true);
                    WriteLiteral("<span class=\"oi oi-x\"></span>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 58 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                                                                                              WriteLiteral(UrlHelpers.QueryStringSafeHash(persistedGrant.Key));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1902, 18, true);
                WriteLiteral("</td>\n\t\t\t\t\t\t</tr>\n");
                EndContext();
#line 60 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
					}

#line default
#line hidden
                BeginContext(1927, 88, true);
                WriteLiteral("\t\t\t\t</tbody>\n\t\t\t</table>\n\t\t</div>\n\t</div>\n\n\t<div class=\"row\">\n\t\t<div class=\"col-12\">\n\t\t\t");
                EndContext();
                BeginContext(2016, 138, false);
#line 68 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
       Write(await Html.PartialAsync("Common/Pager", new Pager { Action = "PersistedGrant", PageSize = Model.PageSize, TotalCount = Model.TotalCount }));

#line default
#line hidden
                EndContext();
                BeginContext(2154, 344, true);
                WriteLiteral(@"
		</div>
	</div>

	<!-- Modal -->
	<div class=""modal fade"" id=""deletePersistedGrantsModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""deletePersistedGrantsModalLabel"">
		<div class=""modal-dialog"" role=""document"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<h4 class=""modal-title"" id=""deletePersistedGrantsModalLabel"">");
                EndContext();
                BeginContext(2499, 30, false);
#line 77 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                                                                            Write(Localizer["DeleteDialogTitle"]);

#line default
#line hidden
                EndContext();
                BeginContext(2529, 181, true);
                WriteLiteral("</h4>\n\t\t\t\t\t<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n\t\t\t\t</div>\n\t\t\t\t<div class=\"modal-body\">\n\t\t\t\t\t");
                EndContext();
                BeginContext(2711, 32, false);
#line 81 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
               Write(Localizer["DeleteDialogMessage"]);

#line default
#line hidden
                EndContext();
                BeginContext(2743, 93, true);
                WriteLiteral("\n\t\t\t\t</div>\n\t\t\t\t<div class=\"modal-footer\">\n\t\t\t\t\t<button type=\"submit\" class=\"btn btn-danger\">");
                EndContext();
                BeginContext(2837, 28, false);
#line 84 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                                                            Write(Localizer["DeleteDialogYes"]);

#line default
#line hidden
                EndContext();
                BeginContext(2865, 90, true);
                WriteLiteral("</button>\n\t\t\t\t\t<button type=\"button\" class=\"btn btn-outline-primary\" data-dismiss=\"modal\">");
                EndContext();
                BeginContext(2956, 27, false);
#line 85 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Grant/PersistedGrant.cshtml"
                                                                                          Write(Localizer["DeleteDialogNo"]);

#line default
#line hidden
                EndContext();
                BeginContext(2983, 48, true);
                WriteLiteral("</button>\n\t\t\t\t</div>\n\t\t\t</div>\n\t\t</div>\n\t</div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersistedGrantsDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
