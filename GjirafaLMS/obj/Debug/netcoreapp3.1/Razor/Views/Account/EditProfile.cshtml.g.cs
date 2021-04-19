#pragma checksum "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Account\EditProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f81252bf51dc9e4287be0cc8d8916735f6d4dc8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_EditProfile), @"mvc.1.0.view", @"/Views/Account/EditProfile.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\_ViewImports.cshtml"
using GjirafaLMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\_ViewImports.cshtml"
using GjirafaLMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f81252bf51dc9e4287be0cc8d8916735f6d4dc8b", @"/Views/Account/EditProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb12fb4cd1ed9456a3bd2c3c529c5bdd2c7bce51", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_EditProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ChangePasswordPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "EditInfoPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "EditLocationPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Account\EditProfile.cshtml"
  
    Layout = "~/Views/Shared/_DashboardLayout.cshtml";
    var user = @userManager.GetUserAsync(User).Result;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""d-sm-flex justify-content-between align-items-center p-3 gradient-primary"">
        <h3>Profile</h3>
        <div>
            <a href=""/dashboard""><button class=""btn btn-light shadow mr-2"">Dashboard</button></a>
            <a");
            BeginWriteAttribute("href", " href=\"", 463, "\"", 487, 2);
            WriteAttributeValue("", 470, "/profile/", 470, 9, true);
#nullable restore
#line 12 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Account\EditProfile.cshtml"
WriteAttributeValue("", 479, user.Id, 479, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><button class=""btn btn-light shadow"">Cancel</button></a>
        </div>
    </div>
    <div class=""row mb-3"">
        <div class=""col-lg-4"">
            <div class=""card mb-3"">
                <div class=""card-body text-center shadow""><img id=""profile-img"" class=""rounded-circle mb-3 mt-4""");
            BeginWriteAttribute("src", "\r\n                        src=\"", 784, "\"", 834, 1);
#nullable restore
#line 19 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Account\EditProfile.cshtml"
WriteAttributeValue("", 815, user.ProfileImgUrl, 815, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                        width=\"160\" height=\"160\">\r\n                    <h3>");
#nullable restore
#line 21 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Account\EditProfile.cshtml"
                   Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Account\EditProfile.cshtml"
                                   Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 22 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Account\EditProfile.cshtml"
                     if (User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <small>Admin User</small>\r\n");
#nullable restore
#line 25 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Account\EditProfile.cshtml"
                    }
                    else if (User.IsInRole("Instructor"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <small>Instructor</small>\r\n");
#nullable restore
#line 29 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Account\EditProfile.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <small>Normal User</small>\r\n");
#nullable restore
#line 33 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Account\EditProfile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f81252bf51dc9e4287be0cc8d8916735f6d4dc8b7905", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""col-lg-8"">
            <div class=""row mb-3 d-none"">
                <div class=""col"">
                    <div class=""card text-white bg-primary shadow"">
                        <div class=""card-body"">
                            <div class=""row mb-2"">
                                <div class=""col"">
                                    <p class=""m-0"">Peformance</p>
                                    <p class=""m-0""><strong>65.2%</strong></p>
                                </div>
                                <div class=""col-auto""><i class=""fas fa-rocket fa-2x""></i></div>
                            </div>
                            <p class=""text-white-50 small m-0""><i class=""fas fa-arrow-up""></i>&nbsp;5% since last month
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""card text-white bg-success shadow"">
             ");
            WriteLiteral(@"           <div class=""card-body"">
                            <div class=""row mb-2"">
                                <div class=""col"">
                                    <p class=""m-0"">Peformance</p>
                                    <p class=""m-0""><strong>65.2%</strong></p>
                                </div>
                                <div class=""col-auto""><i class=""fas fa-rocket fa-2x""></i></div>
                            </div>
                            <p class=""text-white-50 small m-0""><i class=""fas fa-arrow-up""></i>&nbsp;5% since last month
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f81252bf51dc9e4287be0cc8d8916735f6d4dc8b10929", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f81252bf51dc9e4287be0cc8d8916735f6d4dc8b12066", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
