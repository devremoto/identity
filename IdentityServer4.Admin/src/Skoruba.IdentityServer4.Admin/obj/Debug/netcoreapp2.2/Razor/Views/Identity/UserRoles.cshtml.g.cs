#pragma checksum "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8be224d9f20aa23c1a1c384966344e1b433222f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Identity_UserRoles), @"mvc.1.0.view", @"/Views/Identity/UserRoles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Identity/UserRoles.cshtml", typeof(AspNetCore.Views_Identity_UserRoles))]
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
#line 1 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 2 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
using Skoruba.IdentityServer4.Admin.BusinessLogic.Shared.Dtos.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8be224d9f20aa23c1a1c384966344e1b433222f6", @"/Views/Identity/UserRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef0c9e2904c50fcb45af80d4002c5716cb46aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Identity_UserRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Skoruba.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Interfaces.IUserRolesDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-3 col-form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control single-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserRoles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserRolesDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(247, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
  
	ViewBag.Title = Localizer["Title"];
	Layout = "_Layout";

#line default
#line hidden
            BeginContext(311, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(312, 1545, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8be224d9f20aa23c1a1c384966344e1b433222f68182", async() => {
                BeginContext(381, 140, true);
                WriteLiteral("\n\t<div class=\"row\">\n\t\t\n\t\t<div class=\"col-12\">\n\t\t\t<nav aria-label=\"breadcrumb\">\n\t\t\t\t<ol class=\"breadcrumb\">\n\t\t\t\t\t<li class=\"breadcrumb-item\">");
                EndContext();
                BeginContext(521, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8be224d9f20aa23c1a1c384966344e1b433222f68734", async() => {
                    BeginContext(570, 28, false);
#line 17 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                                                                                           Write(Localizer["NavigationUsers"]);

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
                BeginContext(602, 39, true);
                WriteLiteral("</li>\n\t\t\t\t\t<li class=\"breadcrumb-item\">");
                EndContext();
                BeginContext(641, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8be224d9f20aa23c1a1c384966344e1b433222f610695", async() => {
                    BeginContext(725, 14, false);
#line 18 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                                                                                                                              Write(Model.UserName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 18 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                                                                                                        WriteLiteral(Model.UserId);

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
                BeginContext(743, 66, true);
                WriteLiteral("</li>\n\t\t\t\t\t<li class=\"breadcrumb-item active\" aria-current=\"page\">");
                EndContext();
                BeginContext(810, 18, false);
#line 19 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                                                                      Write(Localizer["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(828, 69, true);
                WriteLiteral("</li>\n\t\t\t\t</ol>\n\t\t\t</nav>\n\t\t</div>\n\n\t\t<div class=\"col-md-12\">\n\t\t\t<h3>");
                EndContext();
                BeginContext(898, 18, false);
#line 25 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
           Write(Localizer["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(916, 10, true);
                WriteLiteral("</h3>\n\n\t\t\t");
                EndContext();
                BeginContext(926, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8be224d9f20aa23c1a1c384966344e1b433222f614741", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 27 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(986, 23, true);
                WriteLiteral("\n\n\t\t\t<!--Hidden -->\n\t\t\t");
                EndContext();
                BeginContext(1009, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8be224d9f20aa23c1a1c384966344e1b433222f616585", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 30 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

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
                BeginContext(1048, 57, true);
                WriteLiteral("\n\n\t\t\t<div class=\"card mt-3\">\n\t\t\t\t<h5 class=\"card-header\">");
                EndContext();
                BeginContext(1106, 21, false);
#line 33 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                                   Write(Localizer["SubTitle"]);

#line default
#line hidden
                EndContext();
                BeginContext(1127, 94, true);
                WriteLiteral("</h5>\n\t\t\t\t<div class=\"card-body\">\n\n\t\t\t\t\t<!--Select-->\n\t\t\t\t\t<div class=\"form-group row\">\n\t\t\t\t\t\t");
                EndContext();
                BeginContext(1221, 138, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8be224d9f20aa23c1a1c384966344e1b433222f619050", async() => {
                    BeginContext(1277, 8, true);
                    WriteLiteral("\n\t\t\t\t\t\t\t");
                    EndContext();
                    BeginContext(1286, 58, false);
#line 39 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                       Write(await Html.PartialAsync("User/Section/Label", "RolesList"));

#line default
#line hidden
                    EndContext();
                    BeginContext(1344, 7, true);
                    WriteLiteral("\n\t\t\t\t\t\t");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 38 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoleId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1359, 37, true);
                WriteLiteral("\n\t\t\t\t\t\t<div class=\"col-sm-9\">\n\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(1396, 130, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8be224d9f20aa23c1a1c384966344e1b433222f621450", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 42 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoleId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 42 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(Model.RolesList, "Id", "Text"));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1526, 223, true);
                WriteLiteral("\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>\n\n\t\t\t\t\t<!--Button-->\n\t\t\t\t\t<div class=\"form-group row\">\n\t\t\t\t\t\t<label class=\"col-sm-3 col-form-label\">\n\t\t\t\t\t\t</label>\n\t\t\t\t\t\t<div class=\"col-sm-9\">\n\t\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-primary\">");
                EndContext();
                BeginContext(1750, 26, false);
#line 51 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                                                                     Write(Localizer["ActionAddRole"]);

#line default
#line hidden
                EndContext();
                BeginContext(1776, 74, true);
                WriteLiteral("</button>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n\t\t\t</div>\n\n\t\t</div>\n\t</div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1857, 98, true);
            WriteLiteral("\n\n<div class=\"row\">\n\t<div class=\"col-md-12\">\n\t\t<div class=\"card mt-3\">\n\t\t\t<h5 class=\"card-header\">");
            EndContext();
            BeginContext(1956, 23, false);
#line 64 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                               Write(Localizer["TitleRoles"]);

#line default
#line hidden
            EndContext();
            BeginContext(1979, 152, true);
            WriteLiteral("</h5>\n\t\t\t<div class=\"card-body\">\n\n\t\t\t\t<div class=\"row table-responsive\">\n\t\t\t\t\t<table class=\"table table-striped\">\n\t\t\t\t\t\t<thead>\n\t\t\t\t\t\t\t<tr>\n\t\t\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(2132, 21, false);
#line 71 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                               Write(Localizer["RoleName"]);

#line default
#line hidden
            EndContext();
            BeginContext(2153, 66, true);
            WriteLiteral("</th>\n\t\t\t\t\t\t\t\t<th></th>\n\t\t\t\t\t\t\t</tr>\n\t\t\t\t\t\t</thead>\n\t\t\t\t\t\t<tbody>\n");
            EndContext();
#line 76 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                             foreach (var role in Model.Roles)
							{

#line default
#line hidden
            BeginContext(2270, 26, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<tr>\n\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(2297, 9, false);
#line 79 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                                   Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2306, 19, true);
            WriteLiteral("</td>\n\t\t\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(2325, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8be224d9f20aa23c1a1c384966344e1b433222f628189", async() => {
                BeginContext(2438, 29, false);
#line 80 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                                                                                                                                                   Write(Localizer["ActionRemoveRole"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-roleId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                                                                              WriteLiteral(role.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roleId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-roleId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roleId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 80 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                                                                                                      WriteLiteral(Model.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2471, 20, true);
            WriteLiteral("</td>\n\t\t\t\t\t\t\t\t</tr>\n");
            EndContext();
#line 82 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
							}

#line default
#line hidden
            BeginContext(2500, 95, true);
            WriteLiteral("\t\t\t\t\t\t</tbody>\n\t\t\t\t\t</table>\n\t\t\t\t</div>\n\n\t\t\t\t<div class=\"row\">\n\t\t\t\t\t<div class=\"col-12\">\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(2596, 133, false);
#line 89 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.Admin\Views\Identity\UserRoles.cshtml"
                   Write(await Html.PartialAsync("Common/Pager", new Pager { Action = "UserRoles", PageSize = Model.PageSize, TotalCount = Model.TotalCount }));

#line default
#line hidden
            EndContext();
            BeginContext(2729, 57, true);
            WriteLiteral("\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n\t\t\t</div>\n\t\t</div>\n\t</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Skoruba.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Interfaces.IUserRolesDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
