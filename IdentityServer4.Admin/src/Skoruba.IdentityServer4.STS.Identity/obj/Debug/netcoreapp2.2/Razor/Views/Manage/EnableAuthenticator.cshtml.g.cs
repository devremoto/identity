#pragma checksum "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f5f045f40ee144f5c4b42e956ac4f8d44fcaaef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_EnableAuthenticator), @"mvc.1.0.view", @"/Views/Manage/EnableAuthenticator.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/EnableAuthenticator.cshtml", typeof(AspNetCore.Views_Manage_EnableAuthenticator))]
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
#line 2 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f5f045f40ee144f5c4b42e956ac4f8d44fcaaef", @"/Views/Manage/EnableAuthenticator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28e5beff1cf1bbea99515e61bb4d8266ea1e24ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_EnableAuthenticator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Skoruba.IdentityServer4.STS.Identity.ViewModels.Manage.EnableAuthenticatorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/qrcode.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
  
    ViewData["Title"] = Localizer["Title"];

#line default
#line hidden
            BeginContext(218, 5, true);
            WriteLiteral("\n<h4>");
            EndContext();
            BeginContext(224, 17, false);
#line 8 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(241, 19, true);
            WriteLiteral("</h4>\n<div>\n    <p>");
            EndContext();
            BeginContext(261, 21, false);
#line 10 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
  Write(Localizer["SubTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(282, 72, true);
            WriteLiteral("</p>\n    <ol class=\"list\">\n        <li>\n            <p>\n                ");
            EndContext();
            BeginContext(355, 26, false);
#line 14 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
           Write(Localizer["DownloadTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(381, 277, true);
            WriteLiteral(@"
                <a href=""https://go.microsoft.com/fwlink/?Linkid=825071"">Windows Phone</a>,
                <a href=""https://go.microsoft.com/fwlink/?Linkid=825072"">Android</a>,
                <a href=""https://go.microsoft.com/fwlink/?Linkid=825073"">iOS</a>.
                ");
            EndContext();
            BeginContext(659, 37, false);
#line 18 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
           Write(Localizer["GoogleAuthenticatorTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(696, 299, true);
            WriteLiteral(@"
                <a href=""https://play.google.com/store/apps/details?id=com.google.android.apps.authenticator2&amp;hl=en"">Android</a>,
                <a href=""https://itunes.apple.com/us/app/google-authenticator/id388497605?mt=8"">iOS</a>.
            </p>
        </li>
        <li>
            <p>");
            EndContext();
            BeginContext(996, 19, false);
#line 24 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
          Write(Localizer["ScanQR"]);

#line default
#line hidden
            EndContext();
            BeginContext(1015, 6, true);
            WriteLiteral(" <kbd>");
            EndContext();
            BeginContext(1022, 15, false);
#line 24 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
                                    Write(Model.SharedKey);

#line default
#line hidden
            EndContext();
            BeginContext(1037, 7, true);
            WriteLiteral("</kbd> ");
            EndContext();
            BeginContext(1045, 27, false);
#line 24 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
                                                           Write(Localizer["ScanQRSubTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(1072, 84, true);
            WriteLiteral("</p>\n            <div id=\"qrCode\"></div>\n            <div id=\"qrCodeData\" data-url=\"");
            EndContext();
            BeginContext(1157, 32, false);
#line 26 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
                                      Write(Html.Raw(Model.AuthenticatorUri));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 68, true);
            WriteLiteral("\"></div>\n        </li>\n        <li>\n            <p>\n                ");
            EndContext();
            BeginContext(1258, 17, false);
#line 30 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
           Write(Localizer["Info"]);

#line default
#line hidden
            EndContext();
            BeginContext(1275, 107, true);
            WriteLiteral("\n            </p>\n            <div class=\"row\">\n                <div class=\"col-md-6\">\n                    ");
            EndContext();
            BeginContext(1382, 599, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f5f045f40ee144f5c4b42e956ac4f8d44fcaaef11043", async() => {
                BeginContext(1402, 78, true);
                WriteLiteral("\n                        <div class=\"form-group\">\n                            ");
                EndContext();
                BeginContext(1480, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f5f045f40ee144f5c4b42e956ac4f8d44fcaaef11506", async() => {
                    BeginContext(1525, 17, false);
#line 36 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
                                                                   Write(Localizer["Code"]);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 36 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Code);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1550, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(1579, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f5f045f40ee144f5c4b42e956ac4f8d44fcaaef13634", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 37 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Code);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1643, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(1672, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f5f045f40ee144f5c4b42e956ac4f8d44fcaaef15488", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 38 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Code);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1731, 102, true);
                WriteLiteral("\n                        </div>\n                        <button type=\"submit\" class=\"btn btn-primary\">");
                EndContext();
                BeginContext(1834, 19, false);
#line 40 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
                                                                 Write(Localizer["Verify"]);

#line default
#line hidden
                EndContext();
                BeginContext(1853, 34, true);
                WriteLiteral("</button>\n                        ");
                EndContext();
                BeginContext(1887, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f5f045f40ee144f5c4b42e956ac4f8d44fcaaef17905", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 41 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

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
                BeginContext(1953, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1981, 75, true);
            WriteLiteral("\n                </div>\n            </div>\n        </li>\n    </ol>\n</div>\n\n");
            EndContext();
            BeginContext(2056, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f5f045f40ee144f5c4b42e956ac4f8d44fcaaef21105", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2098, 112, true);
            WriteLiteral("\n<script type=\"text/javascript\">\n    new QRCode(document.getElementById(\"qrCode\"),\n        {\n            text: \"");
            EndContext();
            BeginContext(2211, 32, false);
#line 53 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Manage\EnableAuthenticator.cshtml"
              Write(Html.Raw(Model.AuthenticatorUri));

#line default
#line hidden
            EndContext();
            BeginContext(2243, 72, true);
            WriteLiteral("\",\n            width: 300,\n            height: 300\n        });\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Skoruba.IdentityServer4.STS.Identity.ViewModels.Manage.EnableAuthenticatorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
