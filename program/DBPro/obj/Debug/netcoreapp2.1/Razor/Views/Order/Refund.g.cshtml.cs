#pragma checksum "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Refund.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2376afd11e4e9353af1dda7d0afa72447fd1bc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Refund), @"mvc.1.0.view", @"/Views/Order/Refund.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Refund.cshtml", typeof(AspNetCore.Views_Order_Refund))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2376afd11e4e9353af1dda7d0afa72447fd1bc6", @"/Views/Order/Refund.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a40c1456db73c9a8353b2e70a1daa81653e306", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Refund : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/img1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("90"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("90"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Refund.cshtml"
  
    ViewData["Title"] = "Refund";

#line default
#line hidden
            BeginContext(44, 2789, true);
            WriteLiteral(@"
<div class=""ui grid container"">
    <div class=""one wide column""></div>
    <div class=""two wide column"">
        <a tabindex=""0"" class=""ui animated fade button"" href=""/Order/OrderDetail"">
            <div class=""visible content"">
                <i class=""left arrow icon""></i>
            </div>
            <div class=""hidden content"">返回 </div>
        </a>
    </div>
</div>

<div class=""ui grid container"">
    <div class=""two wide column""></div>
    <div class=""twelve wide column"">
        <div class=""ui red segment"">
            <div class=""ui red segment"" id=""RefundHead"">
                <div class=""ui hiden grid"">
                    <div class=""row"">
                        <div class=""three wide column"">
                            <div class=""ui checkbox"">
                                <input type=""checkbox"" id=""all"" onclick=""Allcheckout(event)"">
                                <label></label>
                            </div>
                        </div>
              ");
            WriteLiteral(@"          <div class=""four wide hidden column"">
                            商品信息
                        </div>
                        <div class=""two wide column"">
                            单价
                        </div>
                        <div class=""two wide column"">
                            数量
                        </div>
                        <div class=""two wide column"">
                            金额
                        </div>
                        <div class=""three wide column"">
                            状态
                        </div>
                    </div>
                </div>
            </div>
            <div class=""ui red  segment"" id=""depart001"">
                <div class=""ui hiden grid"">
                    <div class=""row"">
                        <div class=""three wide column"">
                            <div class=""ui checkbox"">
                                <input type=""checkbox"" id=""box001"" onclick=""Departcheckout(event)"">
    ");
            WriteLiteral(@"                            <label></label>
                            </div>
                            店铺名字
                        </div>
                    </div>
                </div>
                <div class=""ui hiden grid"">
                    <div class=""row"" id=""goods001001"">
                        <div class=""three wide column"">
                            <div class=""ui child checkbox"">
                                <div class=""ui checkbox"">
                                    <input type=""checkbox"" id=""box001001"" onclick=""Goodscheckout(event)"">
                                    <label></label>
                                </div>
                            </div>
                            ");
            EndContext();
            BeginContext(2833, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "97619527497c4e918d47034c51a0d47e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2885, 1440, true);
            WriteLiteral(@"
                        </div>
                        <div class=""four wide hidden column"" id=""name001001"">
                            商品名
                        </div>
                        <div class=""two wide column"">
                            <label id=""price001001"">48</label>
                        </div>
                        <div class=""two wide column"">
                            <label id=""number001001"">1</label>
                        </div>
                        <div class=""two wide column"">
                            <label id=""total001001"">48</label>
                        </div>
                        <div class=""three wide column"">
                            <div class=""ui label"">
                                <i class=""cart arrow down icon""></i>
                                订单中
                            </div>
                        </div>
                    </div>
                    <div class=""row"" id=""goods001002"">
                        <");
            WriteLiteral(@"div class=""three wide column"">
                            <div class=""ui child checkbox"">
                                <div class=""ui checkbox"">
                                    <input type=""checkbox"" id=""box001002"" onclick=""Goodscheckout(event)"">
                                    <label></label>
                                </div>
                            </div>
                            ");
            EndContext();
            BeginContext(4325, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dbf7f0ef28474771a5b7daa7a3032677", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4377, 6412, true);
            WriteLiteral(@"
                        </div>
                        <div class=""four wide hidden column"" id=""name001002"">
                            商品名
                        </div>
                        <div class=""two wide column"">
                            <label id=""price001002"">78</label>
                        </div>
                        <div class=""two wide column"">
                            <label id=""number001002"">1</label>
                        </div>
                        <div class=""two wide column"">
                            <label id=""total001002"">78</label>
                        </div>
                        <div class=""three wide column"">
                            <div class=""ui label"">
                                <i class=""cart arrow down icon""></i>
                                订单中
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""u");
            WriteLiteral(@"i red segment"" id=""Bottom"">
            <div class=""ui hiden grid"">
                <div class=""row"">
                    <div class=""two wide column"">
                        <div class=""ui checkbox"">
                            <input type=""checkbox"" onclick=""Allcheckout(event) "">
                            <label>全选</label>
                        </div>
                    </div>
                    <div class=""six wide hidden column"">
                    </div>
                    <div class=""three wide column"">
                        已选商品
                        <label id=""totalnum"">0</label>
                        件
                    </div>
                    <div class=""three wide column"">
                        合计
                        <label id=""totalprice"">0</label>
                        元
                    </div>
                    <div class=""two wide column"">
                        <button class=""compact ui button"" disabled=""disabled"" id=""Refund"" onclick=""Ref");
            WriteLiteral(@"undEnsure()"">退款 </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""ui basic modal"">
    <div class=""ui icon header"">
        <i class=""archive icon""></i>
        您确定要退款吗？
    </div>

    <div class=""actions"">
        <div class=""ui red basic cancel inverted button"">
            <i class=""remove icon"" id=""CancelDelete""></i>
            取消
        </div>
        <div class=""ui green ok inverted button"">
            <i class=""checkmark icon"" id=""EnsureDele""></i>
            确定
        </div>
    </div>
</div>

<script>
    var goodsnumber = 0;
    var pricenumber = 0;
    var finalnum = document.getElementById(""totalnum"");
    var finalprice = document.getElementById(""totalprice"");
    var confirmRefund = document.getElementById(""Refund"");
    function Allcheckout(event) {
        var mydepart = event.target.id.substr(3, 3);
        var re = /^[0-9]+.?[0-9]*$/;
        var getCheckBox = document.getElemen");
            WriteLiteral(@"tsByTagName('input');
        for (var i = 0; i < getCheckBox.length; i++) {
            whichObj = getCheckBox[i];
            if (whichObj.type == ""checkbox"") {
                if (event.target.checked && re.test(whichObj.id.substr(-4, 1)) && !whichObj.checked) {
                    confirmRefund.disabled = false;
                    goodsnumber++;
                    var key = whichObj.id.substr(3, 6);
                    var totalprice = document.getElementById(""total"" + key);

                    pricenumber = pricenumber + parseFloat(totalprice.innerHTML);
                }
                else if (!event.target.checked && re.test(whichObj.id.substr(-4, 1)) && whichObj.checked) {
                    goodsnumber--;
                    confirmRefund.disabled = true;
                    var key = whichObj.id.substr(3, 6);
                    var totalprice = document.getElementById(""total"" + key);

                    pricenumber = pricenumber - parseFloat(totalprice.innerHTML);
        ");
            WriteLiteral(@"        }
                whichObj.checked = event.target.checked;
            }
        }
        finalnum.innerHTML = goodsnumber;
        finalprice.innerHTML = pricenumber;
    }
    function Goodscheckout(event) {
        var key = event.target.id.substr(3, 6);
        var totalprice = document.getElementById(""total"" + key);

        if (event.target.checked) {
            goodsnumber++;
            pricenumber = pricenumber + parseFloat(totalprice.innerHTML);
            confirmRefund.disabled = false;
        }
        else {
            goodsnumber--;
            pricenumber = pricenumber - parseFloat(totalprice.innerHTML);
        }
        finalnum.innerHTML = goodsnumber;
        finalprice.innerHTML = pricenumber;
        if (goodsnumber == 0) {
            confirmRefund.disabled = true;
        }
    }
    function Departcheckout(event) {
        var mydepart = event.target.id.substr(3, 3);
        var getCheckBox = document.getElementById(""depart"" + mydepart).getEleme");
            WriteLiteral(@"ntsByTagName('input');
        for (var i = 1; i < getCheckBox.length; i++) {
            whichObj = getCheckBox[i];
            if (whichObj.type == ""checkbox"") {

                if (event.target.checked && !whichObj.checked) {
                    confirmRefund.disabled = false;
                    goodsnumber++;
                    var key = whichObj.id.substr(3, 6);
                    var totalprice = document.getElementById(""total"" + key);

                    pricenumber = pricenumber + parseFloat(totalprice.innerHTML);

                }
                else if (!event.target.checked && whichObj.checked) {
                    goodsnumber--;
                    var key = whichObj.id.substr(3, 6);
                    var totalprice = document.getElementById(""total"" + key);
                    pricenumber = pricenumber - parseFloat(totalprice.innerHTML);
                }
                whichObj.checked = event.target.checked;
            }
        }
        finalnum.innerHTML = g");
            WriteLiteral(@"oodsnumber;
        finalprice.innerHTML = pricenumber;
        if (goodsnumber == 0) {
            confirmRefund.disabled = true;
        }
    }
</script>

<script>
    function RefundEnsure() {
        $('.ui.basic.modal').modal('show');
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
