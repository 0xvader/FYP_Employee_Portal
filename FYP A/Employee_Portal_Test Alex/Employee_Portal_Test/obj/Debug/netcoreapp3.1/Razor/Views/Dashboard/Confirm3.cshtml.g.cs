#pragma checksum "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82fb8a059ff2293822888ef73361dcb4dab20ee0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Confirm3), @"mvc.1.0.view", @"/Views/Dashboard/Confirm3.cshtml")]
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
#line 1 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\_ViewImports.cshtml"
using Employee_Portal_Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\_ViewImports.cshtml"
using Employee_Portal_Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82fb8a059ff2293822888ef73361dcb4dab20ee0", @"/Views/Dashboard/Confirm3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f68b380503fd393e0bf7ca984e6cfbeb8f88a1a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Confirm3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
  
    ViewBag.Title = "Confirm";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<br />
<div class=""alert alert-warning"" id=""previous"">
    <strong>Accept the reqeust</strong>
    <input type=""submit"" class=""btn btn-warning"" value=""Confirm"" onclick=""Verified()"" />
</div>

<div class=""alert alert-success"" id=""after"" style=""display:none"">
    <strong><span class=""glyphicon glyphicon-ok""></span> Information is sucessfully Edited</strong>
</div>

<div class=""alert alert-warning"" id=""previous1"">
    <strong>Reject the request</strong>
    <input type=""submit"" class=""btn btn-warning"" value=""Reject"" onclick=""Verified1()"" />
</div>
<div class=""alert alert-success"" id=""after1"" style=""display:none"">
    <strong><span class=""glyphicon glyphicon-ok""></span> The Request is rejected </strong>
</div>
<div class=""card-body"">
    Emp No : ");
#nullable restore
#line 25 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
              foreach (var a in Model.Pmast)
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
Write(a.Empno);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
             ;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    Name : ");
#nullable restore
#line 29 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
            foreach (var a in Model.Pmast)
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
Write(a.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
            ;
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
    <div class=""card-body"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col""> </th>
                    <th scope=""col"">Previous</th>
                    <th scope=""col"">After</th>

                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope=""row"">Emergency Contact - Name</th>
                    <td>
");
#nullable restore
#line 47 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                         foreach (var a in Model.Pmast)
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                    Write(a.Econtact);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                                    ;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 52 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                         foreach (var b in Model.PmastTemp)
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                    Write(b.Econtact);

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                                    ;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">Emergency Contact - Relationship</th>\r\n                    <td>\r\n");
#nullable restore
#line 60 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                         foreach (var a in Model.Pmast)
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                    Write(a.Category);

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                                    ;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 65 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                         foreach (var b in Model.PmastTemp)
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                    Write(b.Category);

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                                    ;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">Emergency Contact - Number</th>\r\n                    <td>\r\n");
#nullable restore
#line 73 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                         foreach (var a in Model.Pmast)
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                    Write(a.Etelno);

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                                  ;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 78 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                         foreach (var b in Model.PmastTemp)
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                    Write(b.Etelno);

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                                  ;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">Spouse - Name</th>\r\n                    <td>\r\n");
#nullable restore
#line 86 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                         foreach (var a in Model.Pmast)
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                    Write(a.Sname);

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                                 ;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 91 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                         foreach (var b in Model.PmastTemp)
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                    Write(b.Sname);

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                                 ;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">Spouse - Nric No</th>\r\n                    <td>\r\n");
#nullable restore
#line 99 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                         foreach (var a in Model.Pmast)
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                    Write(a.Snric);

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                                 ;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 104 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                         foreach (var b in Model.PmastTemp)
                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                    Write(b.Snric);

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\sevqu\Desktop\중요2\발구지\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm3.cshtml"
                                 ;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n\r\n\r\n");
            WriteLiteral(@"        <script>
            function Verified() {
                $.ajax({
                    type: ""post"",
                    url: ""/Dashboard/RegisterConfirm3"",
                    data: { 'empno': '123456' },
                    success: function (msg) {
                        $(""#previous"").hide();
                        $(""#after"").show();
                        alert(msg);
                    }
                })
            }
        </script>
        <script>
            function Verified1() {
                $.ajax({
                    type: ""post"",
                    url: ""/Dashboard/RegisterConfirm3_1"",
                    data: { 'empno': '123456' },
                    success: function (msg) {
                        $(""#previous1"").hide();
                        $(""#after1"").show();
                        alert(msg);
                    }
                })
            }
        </script>
");
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
