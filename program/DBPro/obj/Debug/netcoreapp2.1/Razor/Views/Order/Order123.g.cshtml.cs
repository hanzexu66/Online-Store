#pragma checksum "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e40b817adab303005c3076eb005650c17f6c22a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order123), @"mvc.1.0.view", @"/Views/Order/Order123.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Order123.cshtml", typeof(AspNetCore.Views_Order_Order123))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e40b817adab303005c3076eb005650c17f6c22a9", @"/Views/Order/Order123.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a40c1456db73c9a8353b2e70a1daa81653e306", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Order123 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
            BeginContext(70, 1316, true);
            WriteLiteral(@"

<div class=""ui  grid container"">

    <div class=""two wide column"">
        <div class=""ui massive vertical menu"">
            <div class=""item"">
                <div class=""header"">我的订单</div>
                <div class=""menu"">
                    <a class=""active item"" id=""All"" onclick=""ChangeOrderView(this.id)"">全部订单</a>
                    <a class=""item"" id=""WaitDeliver"" onclick=""ChangeOrderView(this.id)"">待发货</a>
                    <a class=""item"" id=""WaitReceive"" onclick=""ChangeOrderView(this.id)"">待收货</a>
                    <a class=""item"" id=""WaitPay"" onclick=""ChangeOrderView(this.id)"">待付款</a>
                    <a class=""item"" id=""WaitComment"" onclick=""ChangeOrderView(this.id)"">待评价</a>
                    <a class=""item"" id=""Finish"" onclick=""ChangeOrderView(this.id)"">已完成</a>
                    <a class=""item"" id=""WaitRefund"" onclick=""ChangeOrderView(this.id)"">待退款</a>
                    <a class=""item"" id=""Refunded"" onclick=""ChangeOrderView(this.id)"">已退款</a>
                </div>");
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""twelve wide column"">
        <div class=""ui red segment"" id=""OrderList"" style=""display:block"">
            <div class=""ui red segment"" id=""Empty"" style=""display:block"">
                您现在还没有订单，快去买买买吧！
            </div>
");
            EndContext();
#line 31 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
               
                for (int i = 0; i < Model.Count(); ++i)
                {

#line default
#line hidden
            BeginContext(1479, 39, true);
            WriteLiteral("            <div class=\"ui red segment\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1518, "", 1554, 1);
#line 34 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
WriteAttributeValue("", 1522, string.Format("Order{0:D3}", i), 1522, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1554, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
            BeginContext(1584, 225, true);
            WriteLiteral("                <div class=\"ui grid\">\r\n                    <div class=\"row\">\r\n                        <a class=\"ui red image label\">\r\n                            <i class=\"clipboard outline icon\"></i>订单状态 <div class=\"detail\">");
            EndContext();
            BeginContext(1810, 19, false);
#line 39 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
                                                                                      Write(Model[i].orderState);

#line default
#line hidden
            EndContext();
            BeginContext(1829, 90, true);
            WriteLiteral("</div>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 43 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
                  
                    int j = 0;
                

#line default
#line hidden
            BeginContext(1990, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 46 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
                 foreach (var order in Model[i].DSItem)
                {


#line default
#line hidden
            BeginContext(2068, 117, true);
            WriteLiteral("                    <div class=\"ui grid\" style=\"background-color:#f7f7f7;\">\r\n                        <div class=\"row\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 2185, "", 2227, 1);
#line 50 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
WriteAttributeValue("", 2189, string.Format("shop{0:D3}{1:D3}",i,j), 2189, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2227, 126, true);
            WriteLiteral(">\r\n                            <div class=\"fourteen wide  column\">\r\n                                <a style=\"color:#000000;\">");
            EndContext();
            BeginContext(2354, 23, false);
#line 52 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
                                                     Write(order.Value[0].shopName);

#line default
#line hidden
            EndContext();
            BeginContext(2377, 151, true);
            WriteLiteral("</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"ui hiden grid\">\r\n");
            EndContext();
#line 57 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
                         for (int k = 0; k < order.Value.Count(); ++k)
                        {


#line default
#line hidden
            BeginContext(2629, 44, true);
            WriteLiteral("                            <div class=\"row\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 2673, "", 2724, 1);
#line 60 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
WriteAttributeValue("", 2677, string.Format("goods{0:D3}{1:D3}{2:D3}",i,j,k), 2677, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2724, 137, true);
            WriteLiteral(">\r\n                                <div class=\"four wide hidden column\">\r\n                                    <img class=\"ui small image\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 2861, "", 2891, 1);
#line 62 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
WriteAttributeValue("", 2866, order.Value[k].imagePath, 2866, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2891, 149, true);
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"six wide hidden column\">\r\n                                    ");
            EndContext();
            BeginContext(3041, 23, false);
#line 65 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
                               Write(order.Value[k].itemName);

#line default
#line hidden
            EndContext();
            BeginContext(3064, 150, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"three wide hidden column\">\r\n                                    ");
            EndContext();
            BeginContext(3215, 24, false);
#line 68 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
                               Write(order.Value[k].itemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(3239, 148, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"one wide hidden column\">\r\n                                    ");
            EndContext();
            BeginContext(3388, 25, false);
#line 71 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
                               Write(order.Value[k].itemAmount);

#line default
#line hidden
            EndContext();
            BeginContext(3413, 80, true);
            WriteLiteral("\r\n                                </div>\r\n\r\n                            </div>\r\n");
            EndContext();
#line 75 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
                        }

#line default
#line hidden
            BeginContext(3520, 28, true);
            WriteLiteral("                    </div>\r\n");
            EndContext();
#line 77 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
                        }    

#line default
#line hidden
            BeginContext(3579, 126, true);
            WriteLiteral("                    <div class=\"ui hiden grid\">\r\n                        <div class=\"row\" style=\"background-color:#f7f7f7;\">\r\n");
            EndContext();
            BeginContext(3744, 269, true);
            WriteLiteral(@"                            <div class=""eleven wide hidden column"">
                            </div>
                            <div class=""five wide hidden column"">
                                <a tabindex=""0"" class=""ui animated  button"" onclick=""viewOrder()""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4013, "\"", 4035, 1);
#line 84 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
WriteAttributeValue("", 4018, Model[i].orderID, 4018, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4036, 844, true);
            WriteLiteral(@">
                                    <div class=""visible content"">查看订单</div>
                                    <div class=""hidden content"">
                                        <i class=""eye icon""></i>
                                    </div>
                                </a>
                                <div tabindex=""0"" class=""ui animated fade button"" onclick=""DeleteEnsure(this.id)"" id=""001"">
                                    <div class=""visible content"">删除订单</div>
                                    <div class=""hidden content"">
                                        <i class=""trash alternate icon""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
            EndContext();
#line 100 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order123.cshtml"
                }
            

#line default
#line hidden
            BeginContext(4914, 2598, true);
            WriteLiteral(@"        </div>
    </div>
</div>

<div class=""ui basic modal"">
    <div class=""ui icon header"">
        <i class=""trash alternate outline icon""></i>
        您确定要删除此订单吗？
    </div>

    <div class=""actions"">
        <div class=""ui red basic cancel inverted button"">
            <i class=""remove icon"" id=""CancelDelete""></i>
            取消
        </div>
        <div class=""ui green ok inverted button""  onclick=""DeleteOrder()"">
            <i class=""checkmark icon"" id=""EnsureDele""></i>
            确定
        </div>
    </div>
</div>

<script>
    var orderNotEmpty = document.getElementById(""OrderList"").hasChildNodes();
    function OrderEmpty() {
        orderNotEmpty = document.getElementById(""OrderList"").hasChildNodes();
        if (orderNotEmpty) {
            document.getElementById(""Empty"").style.display = ""none"";
        }
        else {
            document.getElementById(""Empty"").style.display = ""block"";
            document.getElementById(""OrderList"").style.display = ""none""");
            WriteLiteral(@";
        }
    }
    //暂时不用
    //function DeleteEnsure(id) {
    //    var key = id;
    //    var deleteorder = document.getElementById(""Order"" + key);
    //    DeleteEnsure1();
    //    if (confirm(""确定要删除改订单吗？"")) {
    //        deleteorder.parentNode.removeChild(deleteorder);
    //        OrderEmpty();
    //        alert(""删除成功！"");
    //    } else {
    //        alert(""已经取消了删除操作"");
    //    }
    //}
    function DeleteOrder() {
        console.log(deleteid);
        var deleteorder = document.getElementById(deleteid);
        deleteorder.parentNode.removeChild(deleteorder);

    }
    function ChangeOrderView(id) {

    }
    function Test() {
        
        alert(id);
    }
    OrderEmpty();
   
</script>

<script>
    var deleteid;//当前被选中删除的订单的id

    function DeleteEnsure(id) {
        console.log(id);
        deleteid = ""Order""+id;
        console.log(deleteid);
        $('.ui.basic.modal')
            .modal('show')
            ;
    }

    $('#A");
            WriteLiteral(@"ll').on('click', function () {

    })
    $('#WaitPay').on('click', function () {

    })
    $('#WaitComment').on('click', function () {

    })
    $('#Finish').on('click', function () {

    })
    $('#WaitDeliver').on('click', function () {

    })
    $('#WaitReceive').on('click', function () {

    })
</script>
<script>
    function viewOrder() {
        
       // alert(event.currentTarget.id);
        var o_id = event.currentTarget.id;
        standardPost(""/Order/OrderDetail"", o_id, ""o_id"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591