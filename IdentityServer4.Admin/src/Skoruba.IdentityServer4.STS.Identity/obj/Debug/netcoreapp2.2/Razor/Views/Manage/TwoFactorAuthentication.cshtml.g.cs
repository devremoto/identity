#pragma checksum "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a68ac7f8b115a1957449c6b887c5bd7f9b4690b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_TwoFactorAuthentication), @"mvc.1.0.view", @"/Views/Manage/TwoFactorAuthentication.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/TwoFactorAuthentication.cshtml", typeof(AspNetCore.Views_Manage_TwoFactorAuthentication))]
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
#line 2 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a68ac7f8b115a1957449c6b887c5bd7f9b4690b4", @"/Views/Manage/TwoFactorAuthentication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28e5beff1cf1bbea99515e61bb4d8266ea1e24ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_TwoFactorAuthentication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Skoruba.IdentityServer4.STS.Identity.ViewModels.Manage.TwoFactorAuthenticationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenerateRecoveryCodes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ForgetTwoFactorClient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Disable2faWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenerateRecoveryCodesWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("enable-authenticator"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnableAuthenticator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("reset-authenticator"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResetAuthenticatorWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
  
    ViewData["Title"] = Localizer["Title"];

#line default
#line hidden
            BeginContext(222, 57, true);
            WriteLiteral("\n<div class=\"row\">\n\n    <div class=\"col-12\">\n        <h3>");
            EndContext();
            BeginContext(280, 17, false);
#line 11 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(297, 18, true);
            WriteLiteral("</h3>\n    </div>\n\n");
            EndContext();
#line 14 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
     if (Model.Is2faEnabled)
    {
        if (Model.RecoveryCodesLeft == 0)
        {

#line default
#line hidden
            BeginContext(402, 110, true);
            WriteLiteral("            <div class=\"col-12\">\n                <div class=\"alert alert-danger\">\n                    <strong>");
            EndContext();
            BeginContext(513, 20, false);
#line 20 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                       Write(Localizer["NoCodes"]);

#line default
#line hidden
            EndContext();
            BeginContext(533, 33, true);
            WriteLiteral("</strong>\n                    <p>");
            EndContext();
            BeginContext(567, 20, false);
#line 21 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                  Write(Localizer["YouMust"]);

#line default
#line hidden
            EndContext();
            BeginContext(587, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(588, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a68ac7f8b115a1957449c6b887c5bd7f9b4690b49921", async() => {
                BeginContext(627, 29, false);
#line 21 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                              Write(Localizer["GenerateNewCodes"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(660, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(662, 24, false);
#line 21 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                                                 Write(Localizer["BeforeLogin"]);

#line default
#line hidden
            EndContext();
            BeginContext(686, 47, true);
            WriteLiteral("</p>\n                </div>\n            </div>\n");
            EndContext();
#line 24 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
        }
        else if (Model.RecoveryCodesLeft == 1)
        {

#line default
#line hidden
            BeginContext(800, 110, true);
            WriteLiteral("            <div class=\"col-12\">\n                <div class=\"alert alert-danger\">\n                    <strong>");
            EndContext();
            BeginContext(911, 20, false);
#line 29 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                       Write(Localizer["OneCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(931, 33, true);
            WriteLiteral("</strong>\n                    <p>");
            EndContext();
            BeginContext(965, 32, false);
#line 30 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                  Write(Localizer["YouCanGenerateCodes"]);

#line default
#line hidden
            EndContext();
            BeginContext(997, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(998, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a68ac7f8b115a1957449c6b887c5bd7f9b4690b413393", async() => {
                BeginContext(1037, 29, false);
#line 30 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                          Write(Localizer["GenerateNewCodes"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1070, 47, true);
            WriteLiteral("</p>\n                </div>\n            </div>\n");
            EndContext();
#line 33 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
        }
        else if (Model.RecoveryCodesLeft <= 3)
        {

#line default
#line hidden
            BeginContext(1184, 111, true);
            WriteLiteral("            <div class=\"col-12\">\n                <div class=\"alert alert-warning\">\n                    <strong>");
            EndContext();
            BeginContext(1296, 20, false);
#line 38 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                       Write(Localizer["YouHave"]);

#line default
#line hidden
            EndContext();
            BeginContext(1316, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1318, 34, false);
#line 38 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                                             Write(Model.RecoveryCodesLeft.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1352, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1354, 29, false);
#line 38 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                 Write(Localizer["RecoveryCodeLeft"]);

#line default
#line hidden
            EndContext();
            BeginContext(1383, 33, true);
            WriteLiteral("</strong>\n                    <p>");
            EndContext();
            BeginContext(1417, 22, false);
#line 39 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                  Write(Localizer["YouShould"]);

#line default
#line hidden
            EndContext();
            BeginContext(1439, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1440, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a68ac7f8b115a1957449c6b887c5bd7f9b4690b417291", async() => {
                BeginContext(1479, 29, false);
#line 39 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                Write(Localizer["GenerateNewCodes"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1512, 47, true);
            WriteLiteral("</p>\n                </div>\n            </div>\n");
            EndContext();
#line 42 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
        }

        if (Model.IsMachineRemembered)
        {

#line default
#line hidden
            BeginContext(1619, 54, true);
            WriteLiteral("            <div class=\"col-12 mb-3\">\n                ");
            EndContext();
            BeginContext(1673, 203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a68ac7f8b115a1957449c6b887c5bd7f9b4690b419366", async() => {
                BeginContext(1752, 64, true);
                WriteLiteral("\n                    <button type=\"submit\" class=\"btn btn-info\">");
                EndContext();
                BeginContext(1817, 26, false);
#line 48 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                                                          Write(Localizer["ForgetBrowser"]);

#line default
#line hidden
                EndContext();
                BeginContext(1843, 26, true);
                WriteLiteral("</button>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1876, 20, true);
            WriteLiteral("\n            </div>\n");
            EndContext();
#line 51 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
        }


#line default
#line hidden
            BeginContext(1907, 41, true);
            WriteLiteral("        <div class=\"col-12\">\n            ");
            EndContext();
            BeginContext(1948, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a68ac7f8b115a1957449c6b887c5bd7f9b4690b422329", async() => {
                BeginContext(2004, 23, false);
#line 54 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                                                              Write(Localizer["Disable2FA"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2031, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(2044, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a68ac7f8b115a1957449c6b887c5bd7f9b4690b424030", async() => {
                BeginContext(2113, 23, false);
#line 55 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                           Write(Localizer["ResetCodes"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2140, 16, true);
            WriteLiteral("\n        </div>\n");
            EndContext();
#line 57 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
    }

#line default
#line hidden
            BeginContext(2162, 70, true);
            WriteLiteral("\n</div>\n\n<div class=\"row\">\n\n    <div class=\"col-12 mt-3\">\n        <h4>");
            EndContext();
            BeginContext(2233, 29, false);
#line 64 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
       Write(Localizer["AuthenticatorApp"]);

#line default
#line hidden
            EndContext();
            BeginContext(2262, 43, true);
            WriteLiteral("</h4>\n    </div>\n\n    <div class=\"col-12\">\n");
            EndContext();
#line 68 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
         if (!Model.HasAuthenticator)
        {

#line default
#line hidden
            BeginContext(2353, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2365, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a68ac7f8b115a1957449c6b887c5bd7f9b4690b426898", async() => {
                BeginContext(2452, 29, false);
#line 70 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                             Write(Localizer["AddAuthenticator"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2485, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 71 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2519, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2531, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a68ac7f8b115a1957449c6b887c5bd7f9b4690b429032", async() => {
                BeginContext(2618, 31, false);
#line 74 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                             Write(Localizer["SetupAuthenticator"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2653, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(2666, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a68ac7f8b115a1957449c6b887c5bd7f9b4690b430857", async() => {
                BeginContext(2757, 31, false);
#line 75 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                                 Write(Localizer["ResetAuthenticator"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2792, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 76 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\TwoFactorAuthentication.cshtml"
        }

#line default
#line hidden
            BeginContext(2803, 18, true);
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Skoruba.IdentityServer4.STS.Identity.ViewModels.Manage.TwoFactorAuthenticationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
