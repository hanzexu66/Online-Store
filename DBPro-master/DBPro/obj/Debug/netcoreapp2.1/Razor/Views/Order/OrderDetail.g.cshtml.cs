#pragma checksum "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0562bb85746658040acdeb7742f528f7ef76f85e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderDetail), @"mvc.1.0.view", @"/Views/Order/OrderDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/OrderDetail.cshtml", typeof(AspNetCore.Views_Order_OrderDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0562bb85746658040acdeb7742f528f7ef76f85e", @"/Views/Order/OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a40c1456db73c9a8353b2e70a1daa81653e306", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
  
    ViewData["Title"] = "OrderDetail";

#line default
#line hidden
            BeginContext(72, 735, true);
            WriteLiteral(@"<div class=""ui grid container"">
    <div class=""two wide column""></div>
    <div class=""one wide column"">
        <a tabindex=""0"" class=""ui animated fade button"" onclick=""ReturnOrder()"" >
            <div class=""visible content"">
                <i class=""left arrow icon""></i>
            </div>
            <div class=""hidden content"">返回 </div>
        </a>     
    </div>
    <div class=""ten wide column"">
        <div class=""ui  segment"">
            <div class=""ui segment"" id=""Order001"">
                <div class=""ui grid"" style=""background-color:#f7f7f7;"">
                    <div class=""row"">
                        <div class=""fourteen wide  column"">
                            <a style=""color:#000000;"">");
            EndContext();
            BeginContext(808, 24, false);
#line 22 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                                                 Write(Model.LSItem[0].shopName);

#line default
#line hidden
            EndContext();
            BeginContext(832, 123, true);
            WriteLiteral("</a>\r\n                        </div>\r\n                        <div class=\" two wide  column\">\r\n                            ");
            EndContext();
            BeginContext(956, 54, false);
#line 25 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                       Write(DBPro.Entity.Order.OrderStateConvert[Model.orderState]);

#line default
#line hidden
            EndContext();
            BeginContext(1010, 132, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div> \r\n                <div class=\"ui hiden grid\">\r\n");
            EndContext();
#line 30 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                       
                        double totalPrice = 0;
                        for (int i = 0; i < Model.LSItem.Count(); ++i)
                        {
                            totalPrice += Model.LSItem[i].itemPrice * Model.LSItem[i].itemAmount;

#line default
#line hidden
            BeginContext(1413, 44, true);
            WriteLiteral("                            <div class=\"row\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1457, "", 1492, 1);
#line 35 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
WriteAttributeValue("", 1461, string.Format("goods{0:D3}",i), 1461, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1492, 137, true);
            WriteLiteral(">\r\n                                <div class=\"four wide hidden column\">\r\n                                    <img class=\"ui small image\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 1629, "", 1660, 1);
#line 37 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
WriteAttributeValue("", 1634, Model.LSItem[i].imagePath, 1634, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1660, 149, true);
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"six wide hidden column\">\r\n                                    ");
            EndContext();
            BeginContext(1810, 24, false);
#line 40 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                               Write(Model.LSItem[i].itemName);

#line default
#line hidden
            EndContext();
            BeginContext(1834, 150, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"three wide hidden column\">\r\n                                    ");
            EndContext();
            BeginContext(1985, 25, false);
#line 43 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                               Write(Model.LSItem[i].itemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2010, 150, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"three wide hidden column\">\r\n                                    ");
            EndContext();
            BeginContext(2161, 26, false);
#line 46 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                               Write(Model.LSItem[i].itemAmount);

#line default
#line hidden
            EndContext();
            BeginContext(2187, 78, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 49 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                        }

                    

#line default
#line hidden
            BeginContext(2317, 717, true);
            WriteLiteral(@"
                </div>


            </div>
            <div class=""ui red attached segment"">
                <div class=""ui hiden grid"">
                    <div class=""row"">
                        <a class=""ui red ribbon label"">订单信息</a>
                    </div>
                </div>
                <div class=""ui hiden grid"">
                    <div class=""row"">
                        <div class=""one wide column""></div>
                        <div class=""six wide column"">
                            <div class=""ui label""> <i class=""clipboard list icon""></i>订单编号 </div>
                        </div>
                        <div class=""nine wide column"">
                            ");
            EndContext();
            BeginContext(3035, 13, false);
#line 70 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                       Write(Model.orderID);

#line default
#line hidden
            EndContext();
            BeginContext(3048, 474, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""ui divider""></div>
                    <div class=""row"">
                        <div class=""one wide column""></div>
                        <div class=""six wide column"">
                            <div class=""ui label""> <i class=""user icon""></i>用户姓名 </div>
                        </div>
                        <div class=""nine wide column"">
                            ");
            EndContext();
            BeginContext(3523, 14, false);
#line 80 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                       Write(Model.userName);

#line default
#line hidden
            EndContext();
            BeginContext(3537, 474, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""ui divider""></div>
                    <div class=""row"">
                        <div class=""one wide column""></div>
                        <div class=""six wide column"">
                            <div class=""ui label""><i class=""truck icon""></i>收货地址 </div>
                        </div>
                        <div class=""nine wide column"">
                            ");
            EndContext();
            BeginContext(4012, 14, false);
#line 90 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                       Write(Model.province);

#line default
#line hidden
            EndContext();
            BeginContext(4027, 10, false);
#line 90 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                                      Write(Model.city);

#line default
#line hidden
            EndContext();
            BeginContext(4038, 14, false);
#line 90 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                                                 Write(Model.district);

#line default
#line hidden
            EndContext();
            BeginContext(4053, 12, false);
#line 90 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                                                                Write(Model.street);

#line default
#line hidden
            EndContext();
            BeginContext(4065, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4067, 18, false);
#line 90 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                                                                              Write(Model.detailAdress);

#line default
#line hidden
            EndContext();
            BeginContext(4085, 498, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""ui divider""></div>
                    <div class=""row"">
                        <div class=""one wide column""></div>
                        <div class=""six wide column"">
                            <div class=""ui label""> <i class=""money bill alternate outline icon""></i>订单总价 </div>
                        </div>
                        <div class=""nine wide column"">
                            ");
            EndContext();
            BeginContext(4584, 10, false);
#line 100 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                       Write(totalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(4594, 497, true);
            WriteLiteral(@" 元
                        </div>
                    </div>
                    <div class=""ui divider""></div>
                    <div class=""row"">
                        <div class=""one wide column""></div>
                        <div class=""six wide column"">
                            <div class=""ui label""><i class=""calendar alternate outline icon""></i>交易时间 </div>
                        </div>
                        <div class=""nine wide column"">
                            ");
            EndContext();
            BeginContext(5092, 16, false);
#line 110 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Order\OrderDetail.cshtml"
                       Write(Model.createTime);

#line default
#line hidden
            EndContext();
            BeginContext(5108, 2007, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""ui two bottom attached buttons"">
                <a class=""ui button"">
                    <i class=""big rocketchat icon""></i>
                    联系卖家
                </a>
                <a class=""ui button"" id=""001"" onclick=""RefundEnsure(this.id)"">
                    <i class=""big share icon""></i>
                    退款
                </a>
            </div>
        </div>
    </div>
</div>

<div class=""ui basic modal""id=""Ensure"">
    <div class=""ui icon header"">
        <i class=""trash alternate outline icon""></i>
        您确定要对此订单退款吗？
    </div>

    <div class=""actions"">
        <div class=""ui red basic cancel inverted button"">
            <i class=""remove icon"" ></i>
            取消
        </div>
        <div class=""ui green ok inverted button"" onclick=""RefundOrder()"">
            <i class=""checkmark icon""></i>
            确定
        </div>
    ");
            WriteLiteral(@"</div>
</div>

<div class=""ui basic modal""id=""Warning"">
    <div class=""ui icon header"">
        <i class=""trash alternate outline icon""></i>
        该订单已进入退款流程！
    </div>

    <div class=""actions"">
        <div class=""ui green ok inverted button"" >
            <i class=""checkmark icon""></i>
            确定
        </div>
    </div>
</div>

<script>
    function ReturnOrder()
    {
        standardPost(""/Order/Order"", null, null);
    }
</script>
<script>
    var refundid;//当前被选中退款的订单的id
    var refundcheck = 0;//当前订单是否已退款过
    function RefundOrder() {
        refundcheck = 1;
    }
    function RefundEnsure(id) {
        //console.log(id);
        //refundid =  id;
        //console.log(refundid);
        if (refundcheck == 0) {
            $(""#Ensure"")
                .modal('show')
                ;
        }
        else {
            $(""#Warning"")
                .modal('show')
                ;
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591