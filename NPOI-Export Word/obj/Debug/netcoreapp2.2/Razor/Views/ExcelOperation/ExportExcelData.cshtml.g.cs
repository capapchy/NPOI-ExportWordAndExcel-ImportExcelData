#pragma checksum "E:\A-我的Github开源项目\ASP.NET Core NPOI使用超集\NPOI-ExportWordAndExcel-ImportExcelData\NPOI-Export Word\Views\ExcelOperation\ExportExcelData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2e671f8b2c432c1117eb4482a8981a7de630a9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExcelOperation_ExportExcelData), @"mvc.1.0.view", @"/Views/ExcelOperation/ExportExcelData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ExcelOperation/ExportExcelData.cshtml", typeof(AspNetCore.Views_ExcelOperation_ExportExcelData))]
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
#line 1 "E:\A-我的Github开源项目\ASP.NET Core NPOI使用超集\NPOI-ExportWordAndExcel-ImportExcelData\NPOI-Export Word\Views\_ViewImports.cshtml"
using NPOI_Export_Word;

#line default
#line hidden
#line 2 "E:\A-我的Github开源项目\ASP.NET Core NPOI使用超集\NPOI-ExportWordAndExcel-ImportExcelData\NPOI-Export Word\Views\_ViewImports.cshtml"
using NPOI_Export_Word.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2e671f8b2c432c1117eb4482a8981a7de630a9e", @"/Views/ExcelOperation/ExportExcelData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d333f91582698a1facc623f7db3624c9e6d813de", @"/Views/_ViewImports.cshtml")]
    public class Views_ExcelOperation_ExportExcelData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/excelPicture.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\A-我的Github开源项目\ASP.NET Core NPOI使用超集\NPOI-ExportWordAndExcel-ImportExcelData\NPOI-Export Word\Views\ExcelOperation\ExportExcelData.cshtml"
  
    ViewData["Title"] = "使用NPOI导出Excel文档";

#line default
#line hidden
            BeginContext(53, 178, true);
            WriteLiteral("    <div class=\"text-center\">\r\n        <button type=\"button\" class=\"layui-btn layui-btn-fluid\" onclick=\"excelExport()\" style=\"width: 600px;\">导出并保存如下图所示的Excel文档</button>\r\n        ");
            EndContext();
            BeginContext(231, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a2e671f8b2c432c1117eb4482a8981a7de630a9e4359", async() => {
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
            EndContext();
            BeginContext(270, 287, true);
            WriteLiteral(@"
    </div>
<script type=""text/javascript"">
    function excelExport() {
        var index = layer.msg('Excel文档努力生成中...', { icon: 16, shade: 0.8, time: false });
        $.ajax({
            async: true,
            dataType: ""json"",
            type: ""post"",
            url: """);
            EndContext();
            BeginContext(558, 47, false);
#line 16 "E:\A-我的Github开源项目\ASP.NET Core NPOI使用超集\NPOI-ExportWordAndExcel-ImportExcelData\NPOI-Export Word\Views\ExcelOperation\ExportExcelData.cshtml"
             Write(Url.Action("DataExportSimple","ExcelOperation"));

#line default
#line hidden
            EndContext();
            BeginContext(605, 365, true);
            WriteLiteral(@""",
            success: function (res) {
                debugger;
                layer.close(index);
                console.log(res);
                if (res.code == 1) {
                    window.location.href = res.data;
                } else {
                    alert(res.data);
                }
            }
        });
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591