#pragma checksum "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Views\Account\SuccessRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5d10110d8325b594fa37c26476427664086ff6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SuccessRegister), @"mvc.1.0.view", @"/Views/Account/SuccessRegister.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/SuccessRegister.cshtml", typeof(AspNetCore.Views_Account_SuccessRegister))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5d10110d8325b594fa37c26476427664086ff6f", @"/Views/Account/SuccessRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SuccessRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TopLearn.DataLayer.Entities.User.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Views\Account\SuccessRegister.cshtml"
  
    ViewData["Title"] = "پایان ثبت نام";

#line default
#line hidden
            BeginContext(95, 275, true);
            WriteLiteral(@"
<nav aria-label=""breadcrumb"">
    <ul class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""/"">تاپ لرن</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">پایان ثبت نام</li>
    </ul>
</nav>

<div class=""alert alert-success"">
    <h2>");
            EndContext();
            BeginContext(371, 14, false);
#line 14 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Views\Account\SuccessRegister.cshtml"
   Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(385, 81, true);
            WriteLiteral(" عزیز !</h2>\r\n    <p>ثبت نام شما انجام شد ، ایمیلی حاوی لینک فعالسازی به ایمیمل \"");
            EndContext();
            BeginContext(467, 11, false);
#line 15 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Views\Account\SuccessRegister.cshtml"
                                                              Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(478, 101, true);
            WriteLiteral("\" ارسال شد .</p>\r\n    <p>جهت ادامه ثبت نام وارد ایمیل خود شوید و روی لینک کلیک کنید .</p>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearn.DataLayer.Entities.User.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
