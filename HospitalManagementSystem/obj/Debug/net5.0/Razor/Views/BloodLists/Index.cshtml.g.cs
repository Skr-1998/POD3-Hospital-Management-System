#pragma checksum "C:\Users\2101601\source\repos\HospitalManagementSystem\HospitalManagementSystem\Views\BloodLists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6b28d3ed9751b7971beddc91d5f57d7b311042c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BloodLists_Index), @"mvc.1.0.view", @"/Views/BloodLists/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6b28d3ed9751b7971beddc91d5f57d7b311042c", @"/Views/BloodLists/Index.cshtml")]
    public class Views_BloodLists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HospitalManagementSystem.Models.BloodList>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\2101601\source\repos\HospitalManagementSystem\HospitalManagementSystem\Views\BloodLists\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\2101601\source\repos\HospitalManagementSystem\HospitalManagementSystem\Views\BloodLists\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BloodGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\2101601\source\repos\HospitalManagementSystem\HospitalManagementSystem\Views\BloodLists\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BloodAvilability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\2101601\source\repos\HospitalManagementSystem\HospitalManagementSystem\Views\BloodLists\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\2101601\source\repos\HospitalManagementSystem\HospitalManagementSystem\Views\BloodLists\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BloodGroup));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\2101601\source\repos\HospitalManagementSystem\HospitalManagementSystem\Views\BloodLists\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BloodAvilability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 813, "\"", 836, 1);
#nullable restore
#line 34 "C:\Users\2101601\source\repos\HospitalManagementSystem\HospitalManagementSystem\Views\BloodLists\Index.cshtml"
WriteAttributeValue("", 828, item.Id, 828, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 889, "\"", 912, 1);
#nullable restore
#line 35 "C:\Users\2101601\source\repos\HospitalManagementSystem\HospitalManagementSystem\Views\BloodLists\Index.cshtml"
WriteAttributeValue("", 904, item.Id, 904, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 967, "\"", 990, 1);
#nullable restore
#line 36 "C:\Users\2101601\source\repos\HospitalManagementSystem\HospitalManagementSystem\Views\BloodLists\Index.cshtml"
WriteAttributeValue("", 982, item.Id, 982, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\2101601\source\repos\HospitalManagementSystem\HospitalManagementSystem\Views\BloodLists\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HospitalManagementSystem.Models.BloodList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
