#pragma checksum "E:\2--practice\vs\c#\DBPro\DBPro\Views\Report\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba8b697d04b814308a0a19815257b72153cfc1d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_Report), @"mvc.1.0.view", @"/Views/Report/Report.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/Report.cshtml", typeof(AspNetCore.Views_Report_Report))]
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
#line 1 "E:\2--practice\vs\c#\DBPro\DBPro\Views\_ViewImports.cshtml"
using DBPro;

#line default
#line hidden
#line 2 "E:\2--practice\vs\c#\DBPro\DBPro\Views\_ViewImports.cshtml"
using DBPro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba8b697d04b814308a0a19815257b72153cfc1d6", @"/Views/Report/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a40c1456db73c9a8353b2e70a1daa81653e306", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DBPro.Models.ReportViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ui large form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Report\Report.cshtml"
  
    ViewData["Title"] = "Report";

#line default
#line hidden
            BeginContext(80, 59, true);
            WriteLiteral("<div class=\"ui centered container\" style=\"width:60%\">\r\n    ");
            EndContext();
            BeginContext(139, 1224, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbbce6ef3ea04b3494ec3c9f32ef7dcd", async() => {
                BeginContext(167, 320, true);
                WriteLiteral(@"
        <div class=""field"">
            <label>
                <font style=""vertical-align: inherit;"">
                    <font style=""vertical-align: inherit;"">
                        请输入举报原因
                    </font>
                </font>
            </label>
            <input name=""itemID"" readonly");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 487, "\"", 509, 1);
#line 15 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Report\Report.cshtml"
WriteAttributeValue("", 496, Model.itemID, 496, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(510, 846, true);
                WriteLiteral(@" hidden=""hidden""/>
            <textarea name=""reason"" placeholder=""举报原因"" style=""margin:auto"" id=""reportReason""></textarea>
        </div>
        <div class=""ui centered container"" align=""center"">
            <a class=""ui primary button"" onclick=""back()"">
                <font style=""vertical-align: inherit;"">
                    <font style=""vertical-align: inherit;"">
                        返回
                    </font>
                </font>
            </a>
            <div class=""ui primary button"" onclick=""check()"">
                <font style=""vertical-align: inherit;"">
                    <font style=""vertical-align: inherit;"">
                        提交
                    </font>
                </font>
            </div>
        </div>
        <br />
        <div class="" ui error message""></div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1363, 1757, true);
            WriteLiteral(@"
    <div class=""ui bottom attached warning message"" align=""center"">
        <i class=""exclamation icon""></i>
        杜绝恶意举报，从你我做起！
    </div>
</div>

<div class=""ui basic modal"" id=""suretosubm"">
    <div class=""ui icon header"">
        <i class=""exclamation icon""></i><font style=""vertical-align: inherit;"">
            <font style=""vertical-align: inherit;"">
                注意
            </font>
        </font>
    </div>
    <div class=""content"" align=""center"">
        <p><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">确定要提交举报信息？</font></font></p>
    </div>
    <div class=""actions"">
        <div class=""ui red basic cancel inverted button"" onclick=""back()"">
            <i class=""remove icon""></i>
            我改变主意了
        </div>
        <div class=""ui green ok inverted button"" onclick=""send()"">
            <i class=""checkmark icon""></i>
            是的，我确定
        </div>
    </div>
</div>

<div class=""ui basic modal"" id=""reportsuccess"">
    <div c");
            WriteLiteral(@"lass=""ui icon header"">
        <i class=""check icon""></i><font style=""vertical-align: inherit;"">
            <font style=""vertical-align: inherit;"">
                提交成功
            </font>
        </font>
    </div>
</div>

<script>

    //提交信息后
    function send() {
        $('#reportsuccess').modal('show');

        setTimeout(subm, 3000);
    }

    //将表单提交
    function subm(){
        //$('form').submit(function () {
        //    return true;
        //});
        var fileInput = document.getElementById(""reportReason"");
        //window.history.back(-1);//返回到商品详情页面
        $.ajax({
            type: ""post"",
            url: ""/Report/addReport"",
            data: {
                itemID: """);
            EndContext();
            BeginContext(3121, 12, false);
#line 96 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Report\Report.cshtml"
                    Write(Model.itemID);

#line default
#line hidden
            EndContext();
            BeginContext(3133, 955, true);
            WriteLiteral(@""",
                reason: fileInput.value
            },
            success: function (result) {
                standardPost(""/Goods/Details"",result, ""i_id"");
            }
        });
    }

    //检验信息
    function check() {
        if ($('.ui.form').form('is valid')) {
            $('form').submit(function () {
                return false;
            });
            $('#suretosubm').modal('show');
        }
    }

    //返回
    function back() {
        window.history.back(-1);
    }

    //表单校验
    $(document).ready(function () {
        $('.ui.form').form({
            fields: {
                reason: {
                    identifier: 'reason',
                    rules: [
                        {
                            type: 'empty',
                            prompt: '请输入举报原因'
                        }
                    ]
                }
            }
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DBPro.Models.ReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
