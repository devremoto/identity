#pragma checksum "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "494d9e8fd28d8d606ac8eae732b8f3cee887e500"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Device_UserCodeConfirmation), @"mvc.1.0.view", @"/Views/Device/UserCodeConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Device/UserCodeConfirmation.cshtml", typeof(AspNetCore.Views_Device_UserCodeConfirmation))]
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
#line 2 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"494d9e8fd28d8d606ac8eae732b8f3cee887e500", @"/Views/Device/UserCodeConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28e5beff1cf1bbea99515e61bb4d8266ea1e24ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Device_UserCodeConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Skoruba.IdentityServer4.STS.Identity.ViewModels.Device.DeviceAuthorizationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Callback", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Skoruba.IdentityServer4.STS.Identity.Helpers.TagHelpers.SwitchTagHelper __Skoruba_IdentityServer4_STS_Identity_Helpers_TagHelpers_SwitchTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(169, 99, true);
            WriteLiteral("\n<div class=\"consent-container\">\n    <div class=\"row page-header\">\n        <div class=\"col-sm-10\">\n");
            EndContext();
#line 8 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
             if (Model.ClientLogoUrl != null)
            {

#line default
#line hidden
            BeginContext(328, 45, true);
            WriteLiteral("                <div class=\"client-logo\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 373, "\"", 399, 1);
#line 10 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
WriteAttributeValue("", 379, Model.ClientLogoUrl, 379, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(400, 8, true);
            WriteLiteral("></div>\n");
            EndContext();
#line 11 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
            }

#line default
#line hidden
            BeginContext(422, 33, true);
            WriteLiteral("            <h1>\n                ");
            EndContext();
            BeginContext(456, 16, false);
#line 13 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
           Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(472, 24, true);
            WriteLiteral("\n                <small>");
            EndContext();
            BeginContext(497, 21, false);
#line 14 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                  Write(Localizer["SubTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(518, 53, true);
            WriteLiteral("</small>\n            </h1>\n        </div>\n    </div>\n");
            EndContext();
#line 18 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
     if (Model.ConfirmUserCode)
    {

#line default
#line hidden
            BeginContext(609, 100, true);
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-sm-8\">\n                <p>\n                   ");
            EndContext();
            BeginContext(710, 24, false);
#line 23 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
              Write(Localizer["ConfirmCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(734, 2, true);
            WriteLiteral(" \"");
            EndContext();
            BeginContext(737, 14, false);
#line 23 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                                         Write(Model.UserCode);

#line default
#line hidden
            EndContext();
            BeginContext(751, 58, true);
            WriteLiteral("\".\n                </p>\n            </div>\n        </div>\n");
            EndContext();
#line 27 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
    }

#line default
#line hidden
            BeginContext(815, 67, true);
            WriteLiteral("\n    <div class=\"row\">\n        <div class=\"col-sm-12\">\n            ");
            EndContext();
            BeginContext(883, 45, false);
#line 31 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
       Write(await Html.PartialAsync("_ValidationSummary"));

#line default
#line hidden
            EndContext();
            BeginContext(928, 14, true);
            WriteLiteral("\n\n            ");
            EndContext();
            BeginContext(942, 3386, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "494d9e8fd28d8d606ac8eae732b8f3cee887e5008926", async() => {
                BeginContext(991, 17, true);
                WriteLiteral("\n                ");
                EndContext();
                BeginContext(1008, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "494d9e8fd28d8d606ac8eae732b8f3cee887e5009323", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 34 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserCode);

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
                BeginContext(1050, 23, true);
                WriteLiteral("\n\n                <div>");
                EndContext();
                BeginContext(1074, 30, false);
#line 36 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                Write(Localizer["UnCheckPermission"]);

#line default
#line hidden
                EndContext();
                BeginContext(1104, 8, true);
                WriteLiteral("</div>\n\n");
                EndContext();
#line 38 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.IdentityScopes.Any())
                {

#line default
#line hidden
                BeginContext(1179, 236, true);
                WriteLiteral("                    <div class=\"col-sm-12\">\n                        <div class=\"card mt-3\">\n                            <h5 class=\"card-header\">\n                                <i class=\"fa fa-user\"></i>\n                                ");
                EndContext();
                BeginContext(1416, 32, false);
#line 44 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                           Write(Localizer["PersonalInformation"]);

#line default
#line hidden
                EndContext();
                BeginContext(1448, 143, true);
                WriteLiteral("\n                            </h5>\n                            <div class=\"card-body\">\n                                <ul class=\"list-group\">\n");
                EndContext();
#line 48 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                                     foreach (var scope in Model.IdentityScopes)
                                    {
                                        

#line default
#line hidden
                BeginContext(1751, 48, false);
#line 50 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                                   Write(await Html.PartialAsync("_ScopeListItem", scope));

#line default
#line hidden
                EndContext();
#line 50 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                                                                                         
                                    }

#line default
#line hidden
                BeginContext(1838, 131, true);
                WriteLiteral("                                </ul>\n                            </div>\n                        </div>\n                    </div>\n");
                EndContext();
#line 56 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
                BeginContext(1987, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 58 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.ResourceScopes.Any())
                {

#line default
#line hidden
                BeginContext(2055, 204, true);
                WriteLiteral("                    <div class=\"col-sm-12\">\n                        <div class=\"card mt-3\">\n                            <h5 class=\"card-header\">\n                                <i class=\"fa fa-lock\"></i> ");
                EndContext();
                BeginContext(2260, 30, false);
#line 63 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                                                      Write(Localizer["ApplicationAccess"]);

#line default
#line hidden
                EndContext();
                BeginContext(2290, 144, true);
                WriteLiteral("\n                            </h5>\n                            <div class=\"card-body\">\n\n                                <ul class=\"list-group\">\n");
                EndContext();
#line 68 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                                     foreach (var scope in Model.ResourceScopes)
                                    {
                                        

#line default
#line hidden
                BeginContext(2594, 48, false);
#line 70 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                                   Write(await Html.PartialAsync("_ScopeListItem", scope));

#line default
#line hidden
                EndContext();
#line 70 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                                                                                         
                                    }

#line default
#line hidden
                BeginContext(2681, 131, true);
                WriteLiteral("                                </ul>\n                            </div>\n                        </div>\n                    </div>\n");
                EndContext();
#line 76 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
                BeginContext(2830, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 78 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.AllowRememberConsent)
                {

#line default
#line hidden
                BeginContext(2898, 185, true);
                WriteLiteral("                    <div class=\"row m-4\">\n                        <div class=\"col-sm-12\">\n                            <div class=\"toggle-button__input\">\n                                ");
                EndContext();
                BeginContext(3083, 136, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("toggle-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "494d9e8fd28d8d606ac8eae732b8f3cee887e50017663", async() => {
                    BeginContext(3098, 37, true);
                    WriteLiteral("\n                                    ");
                    EndContext();
                    BeginContext(3135, 35, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "494d9e8fd28d8d606ac8eae732b8f3cee887e50018111", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 84 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

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
                    BeginContext(3170, 33, true);
                    WriteLiteral("\n                                ");
                    EndContext();
                }
                );
                __Skoruba_IdentityServer4_STS_Identity_Helpers_TagHelpers_SwitchTagHelper = CreateTagHelper<global::Skoruba.IdentityServer4.STS.Identity.Helpers.TagHelpers.SwitchTagHelper>();
                __tagHelperExecutionContext.Add(__Skoruba_IdentityServer4_STS_Identity_Helpers_TagHelpers_SwitchTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3219, 138, true);
                WriteLiteral("\n                            </div>\n                            <div class=\"toggle-button__text\">\n                                <strong>");
                EndContext();
                BeginContext(3358, 21, false);
#line 88 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                                   Write(Localizer["Remember"]);

#line default
#line hidden
                EndContext();
                BeginContext(3379, 103, true);
                WriteLiteral("</strong>\n                            </div>\n                        </div>\n                    </div>\n");
                EndContext();
#line 92 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
                BeginContext(3500, 185, true);
                WriteLiteral("\n                <div class=\"row ml-4 mr-4\">\n                    <div class=\"col-sm-9 mt-3\">\n                        <button name=\"button\" value=\"yes\" class=\"btn btn-primary\" autofocus>");
                EndContext();
                BeginContext(3686, 16, false);
#line 96 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                                                                                       Write(Localizer["Yes"]);

#line default
#line hidden
                EndContext();
                BeginContext(3702, 79, true);
                WriteLiteral("</button>\n                        <button name=\"button\" value=\"no\" class=\"btn\">");
                EndContext();
                BeginContext(3782, 15, false);
#line 97 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                                                                Write(Localizer["No"]);

#line default
#line hidden
                EndContext();
                BeginContext(3797, 86, true);
                WriteLiteral("</button>\n                    </div>\n\n                    <div class=\"col-sm-3 mt-3\">\n");
                EndContext();
#line 101 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                         if (Model.ClientUrl != null)
                        {

#line default
#line hidden
                BeginContext(3963, 78, true);
                WriteLiteral("                            <a class=\"btn btn-outline-primary\" target=\"_blank\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4041, "\"", 4064, 1);
#line 103 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
WriteAttributeValue("", 4048, Model.ClientUrl, 4048, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4065, 108, true);
                WriteLiteral(">\n                                <i class=\"fa fa-info-circle\"></i>\n                                <strong>");
                EndContext();
                BeginContext(4174, 16, false);
#line 105 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                                   Write(Model.ClientName);

#line default
#line hidden
                EndContext();
                BeginContext(4190, 43, true);
                WriteLiteral("</strong>\n                            </a>\n");
                EndContext();
#line 107 "C:\desenvolvimento\identity\IdentityServer4.Admin\src\Skoruba.IdentityServer4.STS.Identity\Views\Device\UserCodeConfirmation.cshtml"
                        }

#line default
#line hidden
                BeginContext(4259, 62, true);
                WriteLiteral("                    </div>\n                </div>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4328, 33, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Skoruba.IdentityServer4.STS.Identity.ViewModels.Device.DeviceAuthorizationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
