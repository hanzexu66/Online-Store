#pragma checksum "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ec7a91b71619437be15e012b2b3b2269a1a8982"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Goods_Details), @"mvc.1.0.view", @"/Views/Goods/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Goods/Details.cshtml", typeof(AspNetCore.Views_Goods_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ec7a91b71619437be15e012b2b3b2269a1a8982", @"/Views/Goods/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a40c1456db73c9a8353b2e70a1daa81653e306", @"/Views/_ViewImports.cshtml")]
    public class Views_Goods_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(71, 89, true);
            WriteLiteral("<div class=\"ui two column centered grid\">\r\n    <div class=\"twelve column centered row\">\r\n");
            EndContext();
            BeginContext(178, 210, true);
            WriteLiteral("        <div class=\"six wide column\">\r\n            <div class=\"container\" style=\"height:50px\"></div>\r\n            <div class=\"container\">\r\n                <div align=\"center\">\r\n                    <img id=\"obj\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 388, "", 418, 1);
#line 12 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
WriteAttributeValue("", 393, Model.image[0].imagePath, 393, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(418, 636, true);
            WriteLiteral(@" height=""350"" width=""500"">
                </div>
            </div>
            <br />
            <div class=""ui two column centered grid"">
                <div class=""row"">
                    <div class=""column"">
                        <div class=""ui raised segment"">
                            <a class=""ui red ribbon label"" style=""width:10%; height:10%"">
                                <font size=""3"">
                                    店铺名称
                                </font>
                            </a>
                            <h3 class=""ui header"" style=""text-align:left; vertical-align:inherit"">");
            EndContext();
            BeginContext(1063, 35, true);
            WriteLiteral("\r\n                                 ");
            EndContext();
            BeginContext(1099, 14, false);
#line 26 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
                            Write(Model.shopName);

#line default
#line hidden
            EndContext();
            BeginContext(1113, 267, true);
            WriteLiteral(@"
                            </h3>
                        </div>
                    </div>
                    <div class=""column"" style=""margin:auto"">
                        <div class=""ui raised segment"">
                            <div class=""ui header"">");
            EndContext();
            BeginContext(1391, 97, true);
            WriteLiteral("\r\n                                评分：<div class=\"ui star rating\" data-rating=\"3\" data-max-rating=");
            EndContext();
            BeginContext(1489, 15, false);
#line 33 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
                                                                                          Write(Model.itemScore);

#line default
#line hidden
            EndContext();
            BeginContext(1504, 96, true);
            WriteLiteral("></div>\r\n                            </div>\r\n                            <div class=\"ui header\">");
            EndContext();
            BeginContext(1611, 38, true);
            WriteLiteral("\r\n                                收藏量：");
            EndContext();
            BeginContext(1650, 16, false);
#line 36 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
                               Write(Model.itemFollow);

#line default
#line hidden
            EndContext();
            BeginContext(1666, 948, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class=""ui centered container"" align=""center"">
                <label>选择数量：</label>
                <div class=""ui icon disabled button"" id=""minus"" onclick=""minus1()"">
                    <i class=""minus icon""></i>
                </div>
                <div class=""ui big label"">
                    <i class=""shopping bag icon""></i>
                    <font style=""vertical-align: inherit;"">
                        <font id=""num"">1</font>
                    </font>
                </div>
                <div class=""ui icon button"" onclick=""plus1()"">
                    <i class=""add icon""></i>
                </div>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <div class=""ui labeled icon button"" onclick=""report(this.id)""");
            EndContext();
            BeginWriteAttribute("id", " id=", 2614, "", 2631, 1);
#line 58 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
WriteAttributeValue("", 2618, Model.itemID, 2618, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2631, 337, true);
            WriteLiteral(@">
                    <i class=""exclamation icon""></i>
                    <font style=""vertical-align: inherit;"">
                        <font style=""vertical-align: inherit;"">
                            举报
                        </font>
                    </font>
                </div>
            </div>
        </div>
");
            EndContext();
            BeginContext(2986, 452, true);
            WriteLiteral(@"        <div class=""six wide column"">
            <div class=""row"">
                <div class=""ui raised segment"">
                    <a class=""ui red ribbon label"" style=""width:10%; height:10%"">
                        <font size=""3"">
                            商品名称
                        </font>
                    </a>
                    <h2 class=""ui header"" style=""text-align:left; vertical-align:inherit"">
                        ");
            EndContext();
            BeginContext(3439, 14, false);
#line 78 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
                   Write(Model.itemName);

#line default
#line hidden
            EndContext();
            BeginContext(3453, 270, true);
            WriteLiteral(@"
                    </h2>
                    <a class=""ui yellow ribbon label"" style=""width:8%; height:10%"">
                        <font size=""3"">
                            库存
                        </font>
                    </a>
                    <h3>");
            EndContext();
            BeginContext(3724, 14, false);
#line 85 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
                   Write(Model.storeNum);

#line default
#line hidden
            EndContext();
            BeginContext(3738, 254, true);
            WriteLiteral(" 件</h3>\r\n                    <a class=\"ui blue ribbon label\" style=\"width:8%; height:10%\">\r\n                        <font size=\"3\">\r\n                            龟龟商城售价\r\n                        </font>\r\n                    </a>\r\n                    <h1>￥ ");
            EndContext();
            BeginContext(3993, 15, false);
#line 91 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
                     Write(Model.itemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(4008, 250, true);
            WriteLiteral("</h1>\r\n                    <a class=\"ui green ribbon label\" style=\"width:10%; height:10%\">\r\n                        <font size=\"3\">\r\n                            商品介绍\r\n                        </font>\r\n                    </a>\r\n                    <h4>");
            EndContext();
            BeginContext(4259, 22, false);
#line 97 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
                   Write(Model.itemIntroduction);

#line default
#line hidden
            EndContext();
            BeginContext(4281, 53, true);
            WriteLiteral("</h4>\r\n                </div>\r\n            </div>\r\n\r\n");
            EndContext();
            BeginContext(4356, 538, true);
            WriteLiteral(@"            <div class=""row"">
                <br />
                <div class=""ui raised segment"">
                    <a class=""ui red ribbon label"" style=""width:10%; height:10%"">
                        <font size=""3"">
                            折扣信息
                        </font>
                    </a>
                    <h3 class=""ui header"" style=""text-align:left; vertical-align:inherit"">
                        折扣信息
                    </h3>
                </div>
            </div>

            <br />

");
            EndContext();
            BeginContext(4914, 760, true);
            WriteLiteral(@"            <div class=""row"">
                <div class=""container"">
                    <a class=""huge ui animated fade right floated button"" tabindex=""0"" onclick=""buy()"">
                        <div class=""visible content"">
                            <font style=""vertical-align: inherit;"">
                                <font style=""vertical-align: inherit;"">
                                    立即购买
                                </font>
                            </font>
                        </div>
                        <div class=""hidden content"">
                            <font style=""vertical-align: inherit;"">
                                <font style=""vertical-align: inherit;"">
                                    ￥ ");
            EndContext();
            BeginContext(5675, 15, false);
#line 132 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
                                 Write(Model.itemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(5690, 1515, true);
            WriteLiteral(@"
                                </font>
                            </font>
                        </div>
                    </a>
                    <div class=""huge ui vertical animated right floated button"" tabindex=""0"" onclick=""take()"">
                        <div class=""visible content"">
                            <font style=""vertical-align: inherit;"">
                                <font style=""vertical-align: inherit;"">
                                    加入购物车
                                </font>
                            </font>
                        </div>
                        <div class=""hidden content"">
                            <i class=""shop icon""></i>
                        </div>
                    </div>
                    <div class=""huge ui vertical animated right floated button"" tabindex=""0"" onclick=""love()"">
                        <div class=""visible content"">
                            <font style=""vertical-align: inherit;"">
                   ");
            WriteLiteral(@"             <font style=""vertical-align: inherit;"">
                                    收藏
                                </font>
                            </font>
                        </div>
                        <div class=""hidden content"">
                            <i class=""heart icon""></i>
                        </div>
                    </div>
                    <div class=""huge ui vertical animated right floated button"" tabindex=""0"" onclick=""getin(this.id)""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 7205, "\"", 7223, 1);
#line 161 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
WriteAttributeValue("", 7210, Model.shopID, 7210, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7224, 40, true);
            WriteLiteral(" >\r\n                        <div hidden>");
            EndContext();
            BeginContext(7265, 12, false);
#line 162 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
                               Write(Model.shopID);

#line default
#line hidden
            EndContext();
            BeginContext(7277, 909, true);
            WriteLiteral(@"</div>
                        <div class=""visible content"">
                            <font style=""vertical-align: inherit;"">
                                <font style=""vertical-align: inherit;"">
                                    进店
                                </font>
                            </font>
                        </div>
                        <div class=""hidden content"">
                            <i class=""sign in alternate icon""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<br /><br />

<div class=""ui center aligned container"">
    <div class=""ui horizontal divider"">
        <font style=""vertical-align: inherit;"">
            <h2 style=""vertical-align: inherit;"">
                商品评论
            </h2>
        </font>
    </div>
</div>

<br />

");
            EndContext();
#line 194 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
      
        for(int i=0;i<Model.itemComment.Count();++i)
        {

#line default
#line hidden
            BeginContext(8259, 204, true);
            WriteLiteral("        <br /><br />\r\n        <div class=\"ui container\">\r\n            <div class=\"ui comments\">\r\n                <div class=\"comment\">\r\n                    <a class=\"avatar\">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 8463, "", 8499, 1);
#line 202 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
WriteAttributeValue("", 8468, Model.itemComment[i].imagePath, 8468, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8499, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(8508, 191, true);
            WriteLiteral("\r\n                    </a>\r\n                    <div class=\"content\">\r\n                        <a class=\"author\"><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
            EndContext();
            BeginContext(8700, 29, false);
#line 205 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
                                                                                                                   Write(Model.itemComment[i].userName);

#line default
#line hidden
            EndContext();
            BeginContext(8729, 18, true);
            WriteLiteral("</font></font></a>");
            EndContext();
            BeginContext(8756, 174, true);
            WriteLiteral("\r\n                        <div class=\"metadata\">\r\n                            <div class=\"date\"><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
            EndContext();
            BeginContext(8931, 35, false);
#line 207 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
                                                                                                                       Write(Model.itemComment[i].evaluationTime);

#line default
#line hidden
            EndContext();
            BeginContext(8966, 20, true);
            WriteLiteral("</font></font></div>");
            EndContext();
            BeginContext(8994, 220, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"text\">\r\n                            <font style=\"vertical-align: inherit;\">\r\n                                <font style=\"vertical-align: inherit;\">\r\n");
            EndContext();
            BeginContext(9262, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(9299, 38, false);
#line 213 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
                               Write(Model.itemComment[i].evaluationContent);

#line default
#line hidden
            EndContext();
            BeginContext(9337, 200, true);
            WriteLiteral("\r\n                                </font>\r\n                            </font>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 221 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
        }
    

#line default
#line hidden
            BeginContext(9555, 10, true);
            WriteLiteral("    \r\n\r\n\r\n");
            EndContext();
            BeginContext(9584, 776, true);
            WriteLiteral(@"<div class=""ui basic modal"" id=""shopcartconf"">
    <div class=""ui icon header"">
        <i class=""shop icon""></i><font style=""vertical-align: inherit;"">
            <font style=""vertical-align: inherit;"">
                购物车
            </font>
        </font>
    </div>
    <div class=""content"" align=""center"">
        <p><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">是否加入购物车？</font></font></p>
    </div>
    <div class=""actions"">
        <div class=""ui red basic cancel inverted button"">
            <i class=""remove icon""></i>
            不必了
        </div>
        <div class=""ui green ok inverted button"" onclick=""add()"">
            <i class=""checkmark icon""></i>
            好的
        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(10378, 788, true);
            WriteLiteral(@"<div class=""ui basic modal"" id=""buyconf"">
    <div class=""ui icon header"">
        <i class=""shop icon""></i><font style=""vertical-align: inherit;"">
            <font style=""vertical-align: inherit;"">
                交易
            </font>
        </font>
    </div>
    <div class=""content"" align=""center"">
        <p><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">你确定要购买选中的这些商品并生成交易信息吗？</font></font></p>
    </div>
    <div class=""actions"">
        <div class=""ui red basic cancel inverted button"">
            <i class=""remove icon""></i>
            再想想
        </div>
        <a class=""ui green ok inverted button"" onclick=""morder()"">
            <i class=""checkmark icon""></i>
            是的，就是这些
        </a>
    </div>
</div>

");
            EndContext();
            BeginContext(11182, 1058, true);
            WriteLiteral(@"<div class=""ui basic modal"" id=""collectconf"">
    <div class=""ui icon header"">
        <i class=""heart icon""></i><font style=""vertical-align: inherit;"">
            <font style=""vertical-align: inherit;"">
                收藏
            </font>
        </font>
    </div>
    <div class=""content"" align=""center"">
        <p><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">是否加入收藏夹？</font></font></p>
    </div>
    <div class=""actions"">
        <div class=""ui red basic cancel inverted button"">
            <i class=""remove icon""></i>
            不必了
        </div>
        <div class=""ui green ok inverted button"" onclick=""like()"">
            <i class=""checkmark icon""></i>
            好的
        </div>
    </div>
</div>
<script>
    //进店按钮点击
    function getin(id) {
        //alert(id);
        
        standardPost(""/Shops/ShopDetails"", id, ""s_id"");

    }
</script>
<script language=javascript>
    var curIndex = 0;
    var timeInterval = 5000;
    var ");
            WriteLiteral("arr = new Array();\r\n    arr[0] = \"");
            EndContext();
            BeginContext(12241, 24, false);
#line 310 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
         Write(Model.image[0].imagePath);

#line default
#line hidden
            EndContext();
            BeginContext(12265, 19, true);
            WriteLiteral("\" ;\r\n    arr[1] = \"");
            EndContext();
            BeginContext(12285, 24, false);
#line 311 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
         Write(Model.image[0].imagePath);

#line default
#line hidden
            EndContext();
            BeginContext(12309, 19, true);
            WriteLiteral("\" ;\r\n    arr[2] = \"");
            EndContext();
            BeginContext(12329, 24, false);
#line 312 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
         Write(Model.image[0].imagePath);

#line default
#line hidden
            EndContext();
            BeginContext(12353, 1711, true);
            WriteLiteral(@""" ;

    setInterval(removeImg, timeInterval);

    function removeImg() {
        var obj = document.getElementById(""obj"");
        $('#obj').transition('fade right');
        if (curIndex == arr.length - 1) {
            curIndex = 0;
        }
        else {
            curIndex += 1;
        }
        //sleep(1500);
        setTimeout(sleep_, 200);  
    }

    function sleep_() {
        obj.src = arr[curIndex];
        $('#obj').transition('fade left');
    }

    //加按钮
    function plus1() {
        var p = document.getElementById('num');
        p.innerHTML++;
        if (p.innerHTML > 1) {
            var q = document.getElementById('minus');
            q.className = 'ui icon button';
        }
        else {
            var q = document.getElementById('minus');
            q.className = 'ui icon disable button';
        }
    }

    //减按钮
    function minus1() {
        var p = document.getElementById('num');
        if (p.innerHTML > 1) {
            p.inner");
            WriteLiteral(@"HTML--;
        }
        if (p.innerHTML > 1) {
            var q = document.getElementById('minus');
            q.className = 'ui icon button';
        }
        else {
            var q = document.getElementById('minus');
            q.className = 'ui icon disabled button';
        }
    }

    //举报按钮点击
    function report(id) {
        //alert(id);
        standardPost(""/Report/Report"", id, ""i_id"");
    }

    //购物车按钮点击
    function take() {
        $('#shopcartconf').modal('show');
    }

    //收藏按钮点击
    function love() {
        $('#collectconf').modal('show');
    }

    //立即购买按钮点击
    function buy() {
        $('#buyconf').modal('show');
");
            EndContext();
            BeginContext(14374, 73, true);
            WriteLiteral("    }\r\n\r\n\r\n\r\n    //加入到收藏夹事件\r\n    function like() {\r\n        var itemid =\"");
            EndContext();
            BeginContext(14448, 12, false);
#line 396 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
                Write(Model.itemID);

#line default
#line hidden
            EndContext();
            BeginContext(14460, 422, true);
            WriteLiteral(@""";
        $.ajax({
            type: ""post"",
            url: ""/Collect/AddItemToCollection"",
            data: {
                i_id: itemid
            },
            success: function (result) {
                alert(result)
            },
            error: function (result) {
                alert(result)
            }
        });
    }

    //加入到购物车事件
    function add() {
        var itemid =""");
            EndContext();
            BeginContext(14883, 12, false);
#line 414 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
                Write(Model.itemID);

#line default
#line hidden
            EndContext();
            BeginContext(14895, 518, true);
            WriteLiteral(@""";
        $.ajax({
            type: ""post"",
            url: ""/Cart/AddItem"",
            data: {
                i_id: itemid
            },
            success: function (result) {
                alert(result)
            },
            error: function (result) {
                alert(result)
            }
        });
    }

    //直接购买
    function comm() {

    }
    function morder() {
        var num = document.getElementById('num').innerHTML;
        //alert(num);
        var id =""");
            EndContext();
            BeginContext(15414, 12, false);
#line 437 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Goods\Details.cshtml"
            Write(Model.itemID);

#line default
#line hidden
            EndContext();
            BeginContext(15426, 282, true);
            WriteLiteral(@""";
        var goodslist = new Array();
        var numberlist = new Array();
        goodslist[0] = id;
        numberlist[0] = num;
         twoArgsPost(""/Pay/Pay"", goodslist, ""i_ids"", numberlist, ""amounts"");
    }
    $('.ui.rating').rating().rating('disable');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591