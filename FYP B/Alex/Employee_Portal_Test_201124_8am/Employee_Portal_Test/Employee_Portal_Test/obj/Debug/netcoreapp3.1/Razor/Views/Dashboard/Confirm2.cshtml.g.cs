#pragma checksum "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5d4a5dd7d9222ae6558335155f7273a15669845"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Confirm2), @"mvc.1.0.view", @"/Views/Dashboard/Confirm2.cshtml")]
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
#line 1 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\_ViewImports.cshtml"
using Employee_Portal_Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\_ViewImports.cshtml"
using Employee_Portal_Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5d4a5dd7d9222ae6558335155f7273a15669845", @"/Views/Dashboard/Confirm2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f68b380503fd393e0bf7ca984e6cfbeb8f88a1a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Confirm2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/scripts/confirm.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
  
    ViewBag.Title = "Confirm";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<br />
<div class=""alert alert-warning"" id=""previous"">
    <strong>Approve the edit</strong>
    <input type=""submit"" class=""btn btn-warning"" value=""Approve"" onclick=""Verified()"" />
</div>
<div class=""alert alert-success"" id=""after"" style=""display:none"">
    <strong><span class=""glyphicon glyphicon-ok""></span> HOD APPROVED</strong>
</div>
<div class=""alert alert-warning"" id=""previous1"">
    <strong>Reject the edit</strong>
    <input type=""submit"" class=""btn btn-warning"" value=""Reject"" onclick=""Verified1()"" />
</div>
<div class=""alert alert-success"" id=""after1"" style=""display:none"">
    <strong><span class=""glyphicon glyphicon-ok""></span> The Request is rejected </strong>
</div>

<div class=""card-body"">
    Emp No : ");
#nullable restore
#line 24 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
              foreach (var a in Model.Pmast)
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
Write(a.Empno);

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
             ;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    Name : ");
#nullable restore
#line 28 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
            foreach (var a in Model.Pmast)
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
Write(a.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
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
#line 46 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                     foreach (var a in Model.Pmast)
                    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                Write(a.Econtact);

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                                ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 51 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                     foreach (var b in Model.PmastTemp)
                    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                Write(b.Econtact);

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                                ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Emergency Contact - Relationship</th>\r\n                <td>\r\n");
#nullable restore
#line 59 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                     foreach (var a in Model.Pmast)
                    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                Write(a.Emerrship);

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                                 ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 64 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                     foreach (var b in Model.PmastTemp)
                    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                Write(b.Emerrship);

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                                 ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Emergency Contact - Number</th>\r\n                <td>\r\n");
#nullable restore
#line 72 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                     foreach (var a in Model.Pmast)
                    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                Write(a.Emerphone);

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                                 ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 77 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                     foreach (var b in Model.PmastTemp)
                    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                Write(b.Emerphone);

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                                 ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Spouse - Name</th>\r\n                <td>\r\n");
#nullable restore
#line 85 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                     foreach (var a in Model.Pmast)
                    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                Write(a.Sname);

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                             ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 90 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                     foreach (var b in Model.PmastTemp)
                    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                Write(b.Sname);

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                             ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n            <tr>\r\n                <th scope=\"row\">Spouse - Nric No</th>\r\n                <td>\r\n");
#nullable restore
#line 98 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                     foreach (var a in Model.Pmast)
                    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                Write(a.Snric);

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                             ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 103 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                     foreach (var b in Model.PmastTemp)
                    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                Write(b.Snric);

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\alexh\Downloads\Employee_Portal_Test_201121\Employee_Portal_Test\Employee_Portal_Test\Views\Dashboard\Confirm2.cshtml"
                             ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5d4a5dd7d9222ae6558335155f7273a1566984515760", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"    <script>
        function Verified() {
            $.ajax({
                type: ""post"",
                url: ""/Dashboard/RegisterConfirm2"",
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
                url: ""/Dashboard/RegisterConfirm2_1"",
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
