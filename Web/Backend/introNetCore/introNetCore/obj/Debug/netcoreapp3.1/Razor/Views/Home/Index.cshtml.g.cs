#pragma checksum "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\introNetCore\introNetCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0c88220dc4eeb9ff92121e4a50bebe0aa1815ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\introNetCore\introNetCore\Views\_ViewImports.cshtml"
using introNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c88220dc4eeb9ff92121e4a50bebe0aa1815ef", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9de352534da8efb73c7d789730c4f4e456ac9c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Davet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-succes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\introNetCore\introNetCore\Views\Home\Index.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n    <h1>Ana sayfa</h1>\r\n    <p>Sayfamıza hoş geldin!</p>\r\n    <p>\r\n        Merhaba ");
#nullable restore
#line 13 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\introNetCore\introNetCore\Views\Home\Index.cshtml"
           Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", şu an saat ");
#nullable restore
#line 13 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\introNetCore\introNetCore\Views\Home\Index.cshtml"
                                     Write(ViewBag.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 15 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\introNetCore\introNetCore\Views\Home\Index.cshtml"
     if (ViewBag.Hour < 12)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Günaydın</p>\r\n");
#nullable restore
#line 18 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\introNetCore\introNetCore\Views\Home\Index.cshtml"
    }
    else if (ViewBag.Hour < 18)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>İyi günler</p>\r\n");
#nullable restore
#line 22 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\introNetCore\introNetCore\Views\Home\Index.cshtml"
    }
    else if (ViewBag.Hour < 20)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>İyi akşamlar</p>\r\n");
#nullable restore
#line 26 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\introNetCore\introNetCore\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>İyi geceler</p>\r\n");
#nullable restore
#line 30 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\introNetCore\introNetCore\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 32 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\introNetCore\introNetCore\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 34 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\introNetCore\introNetCore\Views\Home\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" isimli ürünün fiyatı, ");
#nullable restore
#line 34 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\introNetCore\introNetCore\Views\Home\Index.cshtml"
                                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</li>\r\n");
#nullable restore
#line 35 "C:\Users\turka\source\repos\Turkcell - Geleceği Yazanlar\Web\Backend\introNetCore\introNetCore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    Koronaya veda partisi düzenliyoruz. Katılmak için  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0c88220dc4eeb9ff92121e4a50bebe0aa1815ef7515", async() => {
                WriteLiteral("Tıkla");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
