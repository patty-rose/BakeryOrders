#pragma checksum "/Users/pattyrose/Desktop/c0ding/BakeryOrders.Solution/BakeryOrders/Views/Orders/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4724dda069520da3f5fdf86acce56dd1a22b2c2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_New), @"mvc.1.0.view", @"/Views/Orders/New.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4724dda069520da3f5fdf86acce56dd1a22b2c2d", @"/Views/Orders/New.cshtml")]
    public class Views_Orders_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/pattyrose/Desktop/c0ding/BakeryOrders.Solution/BakeryOrders/Views/Orders/New.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Add a new item to ");
#nullable restore
#line 4 "/Users/pattyrose/Desktop/c0ding/BakeryOrders.Solution/BakeryOrders/Views/Orders/New.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<form");
            BeginWriteAttribute("action", " action=\"", 72, "\"", 106, 3);
            WriteAttributeValue("", 81, "/vendors/", 81, 9, true);
#nullable restore
#line 5 "/Users/pattyrose/Desktop/c0ding/BakeryOrders.Solution/BakeryOrders/Views/Orders/New.cshtml"
WriteAttributeValue("", 90, Model.Id, 90, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 99, "/orders", 99, 7, true);
            EndWriteAttribute();
            WriteLiteral(" method=\"post\">\n  <input id=\"vendorId\" name=\"vendorId\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 175, "\"", 192, 1);
#nullable restore
#line 6 "/Users/pattyrose/Desktop/c0ding/BakeryOrders.Solution/BakeryOrders/Views/Orders/New.cshtml"
WriteAttributeValue("", 183, Model.Id, 183, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
            WriteLiteral(@"  <label for=""orderDescription"">Ordered items:</label><br>
  <input id=""orderDescription"" name=""orderDescription"" type=""text""><br>
  <label for=""orderDate"">Delivery date:</label> 
  <input type=""date"" id=""orderDate"" name=""orderDate""  max=""2022-12-31"">
  
  <button type=""submit"">Add order</button>
</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591