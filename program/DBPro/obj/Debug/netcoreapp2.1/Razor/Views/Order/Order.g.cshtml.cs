#pragma checksum "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c141fe60cc76fa01a5edcb42596a2317fe6d4c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order), @"mvc.1.0.view", @"/Views/Order/Order.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Order.cshtml", typeof(AspNetCore.Views_Order_Order))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c141fe60cc76fa01a5edcb42596a2317fe6d4c7", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a40c1456db73c9a8353b2e70a1daa81653e306", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
            BeginContext(70, 430, true);
            WriteLiteral(@"

<div class=""ui grid container"">
    <div class=""two wide column"">
        <div class=""ui massive vertical menu"">
            <div class=""item"">
                <div class=""header"">我的订单</div>
                <div class=""menu"">
                    <a class=""active item"" id=""All"" onclick=""ChangeOrderView(this.id)"">全部订单</a>
                    <a class=""item"" id=""WaitDeliver"" onclick=""ChangeOrderView(this.id)"">待发货</a>
");
            EndContext();
            BeginContext(698, 189, true);
            WriteLiteral("                    <a class=\"item\" id=\"WaitComment\" onclick=\"ChangeOrderView(this.id)\">待评价</a>\r\n                    <a class=\"item\" id=\"Finish\" onclick=\"ChangeOrderView(this.id)\">已完成</a>\r\n");
            EndContext();
            BeginContext(1081, 187, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"twelve wide column\">\r\n        <div class=\"ui black segment\" id=\"OrderList\" style=\"display:block\">\r\n");
            EndContext();
            BeginContext(1296, 191, true);
            WriteLiteral("            <div class=\"ui red center aligned segment\" id=\"Empty\" style=\"display:block\">\r\n                <br /><br />\r\n                <p>您现在还没有订单，快去买买买吧！</p>\r\n                <br /><br />\r\n");
            EndContext();
            BeginContext(1553, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 35 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
               


                    for (int i=0;i<Model.Count();++i)
                    {

#line default
#line hidden
            BeginContext(1700, 39, true);
            WriteLiteral("            <div class=\"ui red segment\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1739, "", 1774, 1);
#line 40 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
WriteAttributeValue("", 1743, string.Format("Order{0:D3}",i), 1743, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1774, 25, true);
            WriteLiteral(" style=\"display:block\">\r\n");
            EndContext();
            BeginContext(1826, 225, true);
            WriteLiteral("                <div class=\"ui grid\">\r\n                    <div class=\"row\">\r\n                        <a class=\"ui red image label\">\r\n                            <i class=\"clipboard outline icon\"></i>订单状态 <div class=\"detail\">");
            EndContext();
            BeginContext(2052, 57, false);
#line 45 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
                                                                                      Write(DBPro.Entity.Order.OrderStateConvert[Model[i].orderState]);

#line default
#line hidden
            EndContext();
            BeginContext(2109, 90, true);
            WriteLiteral("</div>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 50 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
                 foreach (var shop in Model[i].DSItem)
                {

#line default
#line hidden
            BeginContext(2306, 77, true);
            WriteLiteral("                    <div class=\"ui grid\" style=\"background-color:#f7f7f7;\">\r\n");
            EndContext();
            BeginContext(2423, 166, true);
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"fourteen wide  column\">\r\n                                <a style=\"color:#000000;\">");
            EndContext();
            BeginContext(2590, 22, false);
#line 56 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
                                                     Write(shop.Value[0].shopName);

#line default
#line hidden
            EndContext();
            BeginContext(2612, 151, true);
            WriteLiteral("</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"ui hiden grid\">\r\n");
            EndContext();
#line 63 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
                         for(int k=0;k<shop.Value.Count();++k)
                        {

#line default
#line hidden
            BeginContext(2938, 44, true);
            WriteLiteral("                            <div class=\"row\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2982, "\"", 3026, 1);
#line 65 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
WriteAttributeValue("", 2987, string.Format("goods{0:D3}{1:D3}",i,k), 2987, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3027, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
            BeginContext(3079, 126, true);
            WriteLiteral("                            <div class=\"four wide hidden column\">\r\n                                <img class=\"ui small image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3205, "\"", 3235, 1);
#line 68 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
WriteAttributeValue("", 3211, shop.Value[k].imagePath, 3211, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3236, 137, true);
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"six wide hidden column\">\r\n                                ");
            EndContext();
            BeginContext(3374, 22, false);
#line 71 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
                           Write(shop.Value[k].itemName);

#line default
#line hidden
            EndContext();
            BeginContext(3396, 138, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"three wide hidden column\">\r\n                                ");
            EndContext();
            BeginContext(3535, 23, false);
#line 74 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
                           Write(shop.Value[k].itemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(3558, 136, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"one wide hidden column\">\r\n                                ");
            EndContext();
            BeginContext(3695, 24, false);
#line 77 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
                           Write(shop.Value[k].itemAmount);

#line default
#line hidden
            EndContext();
            BeginContext(3719, 104, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"two wide hidden column\">\r\n");
            EndContext();
            BeginContext(3911, 101, true);
            WriteLiteral("                                <div class=\"small ui button\" name=\"evaluate\" onclick=\"evaluateItem()\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4012, "\"", 4038, 1);
#line 81 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
WriteAttributeValue("", 4017, shop.Value[k].itemID, 4017, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4039, 79, true);
            WriteLiteral(">评价</div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 84 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"

                        }

#line default
#line hidden
            BeginContext(4147, 54, true);
            WriteLiteral("                        \r\n                    </div>\r\n");
            EndContext();
#line 88 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
                }

#line default
#line hidden
            BeginContext(4220, 120, true);
            WriteLiteral("\r\n                <div class=\"ui hiden grid\">\r\n                    <div class=\"row\" style=\"background-color:#f7f7f7;\">\r\n");
            EndContext();
            BeginContext(4375, 264, true);
            WriteLiteral(@"                        <div class=""nine wide hidden column"">
                        </div>
                        <div class=""seven wide hidden column"">
                            <a tabindex=""0"" class=""ui animated  button"" name=""Look"" onclick=""viewOrder()""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4639, "\"", 4661, 1);
#line 96 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
WriteAttributeValue("", 4644, Model[i].orderID, 4644, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4662, 397, true);
            WriteLiteral(@">
                                <div class=""visible content"">查看订单</div>
                                <div class=""hidden content"">
                                    <i class=""eye icon""></i>
                                </div>
                            </a>
                            <div tabindex=""0"" class=""ui animated fade button"" name=""Delete"" onclick=""DeleteEnsure(this.id)""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5059, "\"", 5090, 1);
#line 102 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
WriteAttributeValue("", 5064, string.Format("{0:D3}",i), 5064, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5091, 47, true);
            WriteLiteral(" >\r\n                                <div hidden");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5138, "\"", 5181, 1);
#line 103 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
WriteAttributeValue("", 5143, string.Format("ModelOrderID{0:D3}",i), 5143, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5182, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5184, 16, false);
#line 103 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
                                                                                   Write(Model[i].orderID);

#line default
#line hidden
            EndContext();
            BeginContext(5200, 397, true);
            WriteLiteral(@"</div>
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
#line 113 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Order\Order.cshtml"
                }
            

#line default
#line hidden
            BeginContext(5631, 7581, true);
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
        <div class=""ui green ok inverted button"" onclick=""DeleteOrder()"">
            <i class=""checkmark icon""></i>
            确定
        </div>
    </div>
</div>

<script>
    function CheckNotEmpty() {
        var re = /\s/;
        var Childs = document.getElementById(""OrderList"").childNodes;
        for (var i = 0; i < Childs.length; i++) {
            var node = Childs[i];
            // nodetype 和 re的正则匹配
            if (node.nodeType == 3 && re.test(node.nodeValue)) {
                node.parentNode.removeChild(node);
            }
        }//去除空文本节点
        var displaynum = 0;
        for (var i = 1; i < Childs.length; ");
            WriteLiteral(@"i++) {
            var node = Childs[i];
            if (node.style.display == ""block"") {
                displaynum++;
            }
        }
        console.log(Childs.length);
        console.log(displaynum);
        if (displaynum == 0) {
            return 0;
        }
        else {
            return 1;
        }
    }
    function OrderEmpty() {
        if (CheckNotEmpty()) {
            document.getElementById(""Empty"").style.display = ""none"";
        }
        else {
            document.getElementById(""Empty"").style.display = ""block"";
        }
    }
    function DeleteOrder() {
        //console.log(deleteid);
        var deleteorder = document.getElementById(deleteid);
        deleteorder.parentNode.removeChild(deleteorder);
        OrderEmpty();

        $.ajax({
            type: ""post"",
            url: ""/Order/deleteOrder"",
            data: {
                o_id: deleteOrder_id
            },
            success: function (result) {
                alert(");
            WriteLiteral(@"result);
            }
        });
    }
    function ChangeOrderView(id) {
        var StateList = document.querySelectorAll("".detail"");
        var i = 0;
        if (id == ""WaitPay"") {
            for (i = 0; i < StateList.length; i++) {
                var OrderX = StateList[i].parentNode.parentNode.parentNode.parentNode;
                if (StateList[i].innerText == ""待付款"") {

                    OrderX.style.display = ""block"";
                }
                else {
                    OrderX.style.display = ""none"";
                }
            }
        }
        else if (id == ""All"") {
            for (i = 0; i < StateList.length; i++) {
                var OrderX = StateList[i].parentNode.parentNode.parentNode.parentNode;
                OrderX.style.display = ""block"";
            }
        }
        else if (id == ""WaitDeliver"") {
            for (i = 0; i < StateList.length; i++) {
                var OrderX = StateList[i].parentNode.parentNode.parentNode.parentNode;
  ");
            WriteLiteral(@"              if (StateList[i].innerText == ""待发货"") {
                    OrderX.style.display = ""block"";
                }
                else {
                    OrderX.style.display = ""none"";
                }
            }
        }
        else if (id == ""WaitReceive"") {
            for (i = 0; i < StateList.length; i++) {
                var OrderX = StateList[i].parentNode.parentNode.parentNode.parentNode;
                if (StateList[i].innerText == ""待收货"") {
                    OrderX.style.display = ""block"";
                }
                else {
                    OrderX.style.display = ""none"";
                }
            }
        }
        else if (id == ""WaitComment"") {
            for (i = 0; i < StateList.length; i++) {
                var OrderX = StateList[i].parentNode.parentNode.parentNode.parentNode;
                if (StateList[i].innerText == ""待评价"") {
                    OrderX.style.display = ""block"";
                }
                else {
          ");
            WriteLiteral(@"          OrderX.style.display = ""none"";
                }
            }
        }
        else if (id == ""Finish"") {
            for (i = 0; i < StateList.length; i++) {
                var OrderX = StateList[i].parentNode.parentNode.parentNode.parentNode;
                if (StateList[i].innerText == ""已完成"") {
                    OrderX.style.display = ""block"";
                }
                else {
                    OrderX.style.display = ""none"";
                }
            }
        }
        else if (id == ""WaitRefund"") {
            for (i = 0; i < StateList.length; i++) {
                var OrderX = StateList[i].parentNode.parentNode.parentNode.parentNode;
                if (StateList[i].innerText == ""待退款"") {
                    OrderX.style.display = ""block"";
                }
                else {
                    OrderX.style.display = ""none"";
                }
            }
        }
        else if (id == ""Refunded"") {
            for (i = 0; i < StateList.len");
            WriteLiteral(@"gth; i++) {
                var OrderX = StateList[i].parentNode.parentNode.parentNode.parentNode;
                if (StateList[i].innerText == ""已退款"") {
                    OrderX.style.display = ""block"";
                }
                else {
                    OrderX.style.display = ""none"";
                }
            }
        }
        OrderEmpty();
    }
    function Inti() {
        var OrderList = document.querySelectorAll("".ui.red.segment"");
        var Button1 = document.getElementsByName(""evaluate"");
        var Button2 = document.getElementsByName(""Delete"");
        for (var i = 0; i < Button1.length; i++) {
            var Order1 = Button1[i].parentNode.parentNode.parentNode.parentNode;
            var State = Order1.children[0].children[0].children[0].children[1];
            //console.log(Order1);
            //console.log(State.innerText);
            if (State.innerText == ""待评价"") {
                Button1[i].style.display = ""true"";
            }
            else {");
            WriteLiteral(@"
                Button1[i].style.display = ""none"";
            }
        }
        for (var i = 0; i < Button2.length; i++) {
            var Order1 = Button1[i].parentNode.parentNode.parentNode.parentNode;
            var State = Order1.children[0].children[0].children[0].children[1];
            //console.log(Order1);
            //console.log(State.innerText);
            if (State.innerText == ""待收货"" || State.innerText == ""待发货"" || State.innerText == ""待退款"") {
                Button2[i].style.display = ""none"";
            }
            else {
                Button2[i].style.display = ""true"";
            }
        }
    }
    OrderEmpty();
    Inti();
</script>
<script>
    function viewOrder() {

        // alert(event.currentTarget.id);
        var o_id = event.currentTarget.id;
        standardPost(""/Order/OrderDetail"", o_id, ""o_id"");
    }
</script>
<script>
    var deleteid;//当前被选中删除的订单的id
    var deleteOrder_id;
    function DeleteEnsure(id) {

        deleteOrder_id =");
            WriteLiteral(@" document.getElementById(""ModelOrderID"" + id).innerHTML;
        //console.log(id);
        deleteid = ""Order"" + id;
        //console.log(deleteid);
        $('.ui.basic.modal')
            .modal('show')
            ;

    }
</script>
<script>
    function evaluateItem() {
        var itemid = event.currentTarget.id;
        standardPost(""/Evaluate/Evaluate"", itemid, ""i_id"");
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
