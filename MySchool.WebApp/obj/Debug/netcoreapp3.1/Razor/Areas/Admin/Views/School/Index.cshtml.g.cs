#pragma checksum "D:\Dummy\MySchool\MySchool.WebApp\Areas\Admin\Views\School\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68b3f3292a169a209cdc0b62a52e4c89beb1676c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_School_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/School/Index.cshtml")]
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
#line 1 "D:\Dummy\MySchool\MySchool.WebApp\Areas\Admin\_ViewImports.cshtml"
using MySchool.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dummy\MySchool\MySchool.WebApp\Areas\Admin\_ViewImports.cshtml"
using MySchool.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Dummy\MySchool\MySchool.WebApp\Areas\Admin\Views\School\Index.cshtml"
using MySchool.Business.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68b3f3292a169a209cdc0b62a52e4c89beb1676c", @"/Areas/Admin/Views/School/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"053eb5bfa0d1f6898b37b8cc951208b7ab1c97e4", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_School_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Dummy\MySchool\MySchool.WebApp\Areas\Admin\Views\School\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";
    ViewData["PageName"] = "Starter Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Card title</h5>

                        <p class=""card-text"">
                            Some quick example text to build on the card title and make up the bulk of the card's
                            content.
                        </p>

                        <a href=""#"" class=""card-link"">Card link</a>
                        <a href=""#"" class=""card-link"">Another link</a>
                    </div>
                </div>

                <div class=""card card-primary card-outline"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Card title</h5>

                        <p class=""card-text"">
                            Some quick example text to build on the card title and make up the bulk of the ");
            WriteLiteral(@"card's
                            content.
                        </p>
                        <a href=""#"" class=""card-link"">Card link</a>
                        <a href=""#"" class=""card-link"">Another link</a>
                    </div>
                </div><!-- /.card -->
            </div>
            <!-- /.col-md-6 -->
            <div class=""col-lg-6"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h5 class=""m-0"">Featured</h5>
                    </div>
                    <div class=""card-body"">
                        <h6 class=""card-title"">Special title treatment</h6>

                        <p class=""card-text"">With supporting text below as a natural lead-in to additional content.</p>
                        <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
                    </div>
                </div>

                <div class=""card card-primary card-outline"">
                    <div class=""card-header"">");
            WriteLiteral(@"
                        <h5 class=""m-0"">Featured</h5>
                    </div>
                    <div class=""card-body"">
                        <h6 class=""card-title"">Special title treatment</h6>

                        <p class=""card-text"">With supporting text below as a natural lead-in to additional content.</p>
                        <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
                    </div>
                </div>
            </div>
            <!-- /.col-md-6 -->
        </div>
        <!-- /.row -->
    </div><!-- /.container-fluid -->
</div>


");
            DefineSection("Breadcrumb", async() => {
                WriteLiteral("\r\n    <li><a href=\"#2\"><i class=\"fa fa-shopping-bag\" aria-hidden=\"true\"></i> Shop</a></li>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(" \r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        alert(\'hi\');\r\n    });\r\n</script>\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
