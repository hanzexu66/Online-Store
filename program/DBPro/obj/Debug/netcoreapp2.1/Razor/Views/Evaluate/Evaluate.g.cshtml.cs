#pragma checksum "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Evaluate\Evaluate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9695204cdece13ac4bc81bc496764335b00dc68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evaluate_Evaluate), @"mvc.1.0.view", @"/Views/Evaluate/Evaluate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Evaluate/Evaluate.cshtml", typeof(AspNetCore.Views_Evaluate_Evaluate))]
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
#line 1 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\_ViewImports.cshtml"
using DBPro;

#line default
#line hidden
#line 2 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\_ViewImports.cshtml"
using DBPro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9695204cdece13ac4bc81bc496764335b00dc68", @"/Views/Evaluate/Evaluate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a40c1456db73c9a8353b2e70a1daa81653e306", @"/Views/_ViewImports.cshtml")]
    public class Views_Evaluate_Evaluate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DBPro.Models.EvaluateViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Evaluate\Evaluate.cshtml"
  
    ViewData["Title"] = "Evaluate";

#line default
#line hidden
            BeginContext(85, 118, true);
            WriteLiteral("<div class=\"ui centered grid\" align=\"center\">\r\n    <div class=\"eight wide column\">\r\n        <div class=\"ui segment\">\r\n");
            EndContext();
            BeginContext(296, 115, true);
            WriteLiteral("            <div class=\"ui form\" id=\"evaluate\" onsubmit=\"Comment()\">\r\n                <div hidden id=\"ModelItemID\">");
            EndContext();
            BeginContext(412, 12, false);
#line 11 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Evaluate\Evaluate.cshtml"
                                        Write(Model.itemID);

#line default
#line hidden
            EndContext();
            BeginContext(424, 157, true);
            WriteLiteral("</div>\r\n                <div class=\"field\">\r\n                    <label>商品名</label>\r\n                    <input id=\"itemID\" name=\"itemID\" readonly=\"readonly\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 581, "\"", 609, 1);
#line 14 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Evaluate\Evaluate.cshtml"
WriteAttributeValue("", 589, Model.item.itemName, 589, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(610, 29, true);
            WriteLiteral(" />\r\n                </div>\r\n");
            EndContext();
            BeginContext(817, 386, true);
            WriteLiteral(@"                <div class=""field"">
                    <label>评论</label>
                    <textarea type=""text"" name=""comment"" id=""cmText""></textarea>
                </div>
                <div align=""center"">
                    <div class=""ui teal submit button"" >确认提交</div>
                </div>
                <div class=""ui error message""></div>
            </div>
");
            EndContext();
            BeginContext(1228, 2087, true);
            WriteLiteral(@"        </div>
    </div>
</div>

<div class=""ui basic modal"">
    <div class=""ui icon header"">
        <i class=""check icon""></i>
        <font style=""vertical-align: inherit;"">
            <font style=""vertical-align: inherit;"">
                评价已提交
            </font>
        </font>
    </div>
</div>

<script>
    $(document).ready(function () {
        $('.ui.rating').rating({
            maxRating: 5
        });
        $('#evaluate').form({
            fields: {
                comment: {
                    identifier: 'comment',
                    rules: [
                        {
                            type: 'empty',
                            prompt: '请输入评论'
                        }
                    ]
                }
            }
        });
    });

    function Comment() {
        if ($('.ui.rating').rating('get rating') == 0) {
            alert(""请为商品评分"");
            return false;
        }   
        if ($('#evaluate').form('is valid') &&");
            WriteLiteral(@" $('.ui.rating').rating('get rating') != 0) {

            var id = document.getElementById(""ModelItemID"").innerHTML;
            //var comm = document.getElementById(""cmText"").innerText;
            var text = $(""#cmText"").val();
            //alert(id);
            //alert(text);

            $.post(""/Evaluate/EvaluateHandle"", { ""i_id"": id, ""comment"": text }, function (result) {
                //alert(result);
                if (result == ""评价成功"") {

                    $('.ui.basic.modal').modal('show');
                    
                    standardPost(""/Goods/Details"", id, ""i_id"");
                }
                else if (result == ""账号异常"") {
                    alert(result)
                    window.location.href = ""/Login/Login"";
                }
                else 
                    alert(result)
            }
                )
            
            //setTimeout(reload, 2000);
            //return true;
        }
    }

    function reload() {
        loc");
            WriteLiteral("ation.reload(true);\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DBPro.Models.EvaluateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
