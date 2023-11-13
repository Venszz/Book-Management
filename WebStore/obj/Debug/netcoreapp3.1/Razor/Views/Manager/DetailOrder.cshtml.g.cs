#pragma checksum "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "100c0d320bf170bcd57f6dcc9bef61e11ea6c72891d6616d71c2e6debaad4d78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_DetailOrder), @"mvc.1.0.view", @"/Views/Manager/DetailOrder.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\asp.net\WebStore\WebStore\Views\_ViewImports.cshtml"
using WebStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
using WebStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"100c0d320bf170bcd57f6dcc9bef61e11ea6c72891d6616d71c2e6debaad4d78", @"/Views/Manager/DetailOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0ca74d9d3d8f0fda11e57151523a5ee9557a88a1c5aba4211246523de85a92d1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Manager_DetailOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManagerOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
  
    ViewData["Title"] = "DeleteOrder";
    Layout = "~/Views/Shared/_ManagerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Detail</h1>

<div>
    <h4>InfoOrder</h4>
    <hr />
    <div class=""row"">
        <div class=""col-sm-8"">
            <div class=""row"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th class=""col-md-2""></th>
                            <th class=""col-md-6"">
                                Tên sách
                            </th>
                            <th class=""col-md-4"">
                                Số lượng
                            </th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 32 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
                         foreach (var item in @Model.orderItem)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n");
#nullable restore
#line 35 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
                                 foreach (var book in Model.lstBook)
                                {
                                    if (item.BookID == book.BookID)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            <span class=\"image\">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 1337, "\"", 1362, 2);
            WriteAttributeValue("", 1343, "/images/", 1343, 8, true);
#nullable restore
#line 41 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
WriteAttributeValue("", 1351, book.Image, 1351, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"120\" width=\"110\"");
            BeginWriteAttribute("alt", " alt=\"", 1388, "\"", 1394, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            </span>\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 45 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
                                       Write(book.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 47 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    ");
#nullable restore
#line 50 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 53 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
        <div class=""col-sm-4"">
            <div class=""row"">
                <label class=""col-sm-3"">
                    InfoOrderID
                </label>
                <div class=""col-sm-9"">
                    ");
#nullable restore
#line 64 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
               Write(Model.infoOrder.InfoOrderID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <label class=\"col-sm-3\">\r\n                    Name\r\n                </label>\r\n                <div class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 70 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
               Write(Model.infoOrder.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <label class=\"col-sm-3\">\r\n                    Email\r\n                </label>\r\n                <div class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 76 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
               Write(Model.infoOrder.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <label class=\"col-sm-3\">\r\n                    Phone\r\n                </label>\r\n                <div class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 82 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
               Write(Model.infoOrder.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <label class=\"col-sm-3\">\r\n                    Address\r\n                </label>\r\n                <div class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 88 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
               Write(Model.infoOrder.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <label class=\"col-sm-3\">\r\n                    TotalPrice\r\n                </label>\r\n                <div class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 94 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
               Write(Model.infoOrder.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <label class=\"col-sm-3\">\r\n                    Status\r\n                </label>\r\n                <div class=\"col-sm-9\">\r\n                    ");
#nullable restore
#line 100 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
               Write(Model.infoOrder.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <a class=\"button\"");
            BeginWriteAttribute("href", " href=\"", 3591, "\"", 3664, 1);
#nullable restore
#line 106 "E:\asp.net\WebStore\WebStore\Views\Manager\DetailOrder.cshtml"
WriteAttributeValue("", 3598, Url.Action("EditOrder",new { id = @Model.infoOrder.InfoOrderID }), 3598, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "100c0d320bf170bcd57f6dcc9bef61e11ea6c72891d6616d71c2e6debaad4d7811204", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
