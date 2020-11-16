#pragma checksum "C:\Users\thela\source\repos\BasicCRM\BasicCRM.WebUI\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85927782f1187595cb0f4d0abc61be4fcbdaad7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
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
#line 1 "C:\Users\thela\source\repos\BasicCRM\BasicCRM.WebUI\Views\_ViewImports.cshtml"
using BasicCRM.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thela\source\repos\BasicCRM\BasicCRM.WebUI\Views\_ViewImports.cshtml"
using BasicCRM.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85927782f1187595cb0f4d0abc61be4fcbdaad7f", @"/Views/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e0612a71d613091ec0ff0c2579a14a7820012f", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div class=""btn"">
    <button onclick=""window.location.href='/Customers/Add'"" type=""button"" class=""btn btn-success btn-xl dt-edit"" style=""margin-right:16px;"">
        <span class=""fa fa-plus-circle"" aria-hidden=""true""></span>Müşteri Ekle
    </button>
</div>
<div class=""alert alert-info"" role=""alert""><strong>Bilgi!</strong> Tüm müşteriler tabloda görünmektedir. Yeni müşteri eklemek için yukarıdaki ""Müşteri Ekle"" butonunu kullanın.</div>
<table id=""example"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Ad Soyad</th>
            <th>Telefon</th>
            <th>Adres</th>
            <th>Kayıt Tarihi</th>
            <th>Butonlar</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\thela\source\repos\BasicCRM\BasicCRM.WebUI\Views\Customers\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\thela\source\repos\BasicCRM\BasicCRM.WebUI\Views\Customers\Index.cshtml"
               Write(item.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\thela\source\repos\BasicCRM\BasicCRM.WebUI\Views\Customers\Index.cshtml"
               Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; ");
#nullable restore
#line 27 "C:\Users\thela\source\repos\BasicCRM\BasicCRM.WebUI\Views\Customers\Index.cshtml"
                                         Write(item.CustomerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\thela\source\repos\BasicCRM\BasicCRM.WebUI\Views\Customers\Index.cshtml"
               Write(item.CustomerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\thela\source\repos\BasicCRM\BasicCRM.WebUI\Views\Customers\Index.cshtml"
               Write(item.CustomerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\thela\source\repos\BasicCRM\BasicCRM.WebUI\Views\Customers\Index.cshtml"
               Write(item.RegistrationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1195, "\"", 1260, 3);
            WriteAttributeValue("", 1205, "window.location.href=\'/Customers/Edit/", 1205, 38, true);
#nullable restore
#line 32 "C:\Users\thela\source\repos\BasicCRM\BasicCRM.WebUI\Views\Customers\Index.cshtml"
WriteAttributeValue("", 1243, item.CustomerId, 1243, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1259, "\'", 1259, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-primary btn-xs dt-edit\" style=\"margin-right:16px;\">\r\n                        <span class=\"glyphicon glyphicon-pencil\" aria-hidden=\"true\">Güncelle</span>\r\n                    </button>\r\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1503, "\"", 1571, 3);
            WriteAttributeValue("", 1513, "window.location.href=\'/Customers/Details/", 1513, 41, true);
#nullable restore
#line 35 "C:\Users\thela\source\repos\BasicCRM\BasicCRM.WebUI\Views\Customers\Index.cshtml"
WriteAttributeValue("", 1554, item.CustomerId, 1554, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1570, "\'", 1570, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-info btn-xs dt-edit\" style=\"margin-right:16px;\">\r\n                        <span class=\"glyphicon-glyphicon-zoom-in\" aria-hidden=\"true\">Detay</span>\r\n                    </button>\r\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1809, "\"", 1881, 3);
            WriteAttributeValue("", 1819, "window.location.href=\'/Customers/Delete/", 1819, 40, true);
#nullable restore
#line 38 "C:\Users\thela\source\repos\BasicCRM\BasicCRM.WebUI\Views\Customers\Index.cshtml"
WriteAttributeValue("", 1859, item.CustomerId, 1859, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1875, "\'type=", 1875, 6, true);
            EndWriteAttribute();
            WriteLiteral(" button\" class=\"btn btn-danger btn-xs dt-delete\">\r\n                        <span class=\"glyphicon glyphicon-remove\" aria-hidden=\"true\">Sil</span>\r\n                    </button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\thela\source\repos\BasicCRM\BasicCRM.WebUI\Views\Customers\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591