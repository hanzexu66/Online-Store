#pragma checksum "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef82c30133598882b8e6bffe2ddedbc0dad3dcb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shops_ShopDetails), @"mvc.1.0.view", @"/Views/Shops/ShopDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shops/ShopDetails.cshtml", typeof(AspNetCore.Views_Shops_ShopDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef82c30133598882b8e6bffe2ddedbc0dad3dcb7", @"/Views/Shops/ShopDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a40c1456db73c9a8353b2e70a1daa81653e306", @"/Views/_ViewImports.cshtml")]
    public class Views_Shops_ShopDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml"
  
    ViewData["Title"] = "ShopDetails";

#line default
#line hidden
            BeginContext(84, 108, true);
            WriteLiteral("\r\n<div class=\"ui grid container\">\r\n    <div class=\"sixteen wide column\">\r\n        <div class=\"ui segment\">\r\n");
            EndContext();
            BeginContext(217, 57, true);
            WriteLiteral("            <div class=\"ui header\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 274, "", 300, 1);
#line 11 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml"
WriteAttributeValue("", 279, Model.shop.imagePath, 279, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(300, 129, true);
            WriteLiteral(" class=\"ui small circular image\" style=\"width:55px;height:55px;\">\r\n                <div class=\"content\">\r\n                    <a>");
            EndContext();
            BeginContext(430, 19, false);
#line 13 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml"
                  Write(Model.shop.shopName);

#line default
#line hidden
            EndContext();
            BeginContext(449, 30, true);
            WriteLiteral("</a>\r\n                </div>\r\n");
            EndContext();
            BeginContext(505, 770, true);
            WriteLiteral(@"                <div class=""ui right floated header"">
                    <div class=""tiny ui vertical animated right floated button"" tabindex=""0"" onclick=""love()"">
                        <div class=""visible content"">
                            <font style=""vertical-align: inherit;"">
                                <font style=""vertical-align: inherit;"">
                                    收藏
                                </font>
                            </font>
                        </div>
                        <div class=""hidden content"">
                            <div> </div>
                            <i class=""heart icon""></i>
                        </div>
                    </div>
                </div>
            </div>
");
            EndContext();
            BeginContext(1297, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(1313, 27, false);
#line 33 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml"
          Write(Model.shop.shopIntroduction);

#line default
#line hidden
            EndContext();
            BeginContext(1340, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(1368, 110, true);
            WriteLiteral("            <div class=\"ui right floated header\">\r\n                评分：<div class=\"ui star rating\" data-rating=");
            EndContext();
            BeginContext(1479, 24, false);
#line 36 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml"
                                                      Write(Model.shop.favorableRate);

#line default
#line hidden
            EndContext();
            BeginContext(1503, 103, true);
            WriteLiteral(" data-max-rating=\"5\"></div>\r\n            </div>\r\n            <br>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(1616, 106, true);
            WriteLiteral("<div class=\"ui grid container\">\r\n    <div class=\"sixteen wide column\">\r\n        <div class=\"ui segment\">\r\n");
            EndContext();
            BeginContext(1749, 498, true);
            WriteLiteral(@"            <div class=""ui top attached tabular menu"">
                <a class=""item active"">店铺商品 </a>
                <div class=""right menu"">
                    <div class=""item"">
                        <div class=""ui transparent icon input"">
                            <input type=""text"" placeholder=""店内搜索商品"">
                            <i class=""search link icon"" id=""sss""></i>
                        </div>
                    </div>
                </div>
            </div>
");
            EndContext();
            BeginContext(2269, 54, true);
            WriteLiteral("            <div class=\"ui bottom attached segment\">\r\n");
            EndContext();
            BeginContext(2354, 3221, true);
            WriteLiteral(@"                <div class=""ui grid"">
                    <div class=""three wide column"">
                        <div class=""ui floating dropdown labeled icon button"">
                            <i class=""filter icon""></i>
                            <span class=""text"">分类</span>
                            <div class=""menu"">
                                <div class=""ui icon search input"">
                                    <i class=""search icon""></i>
                                    <input type=""text"" placeholder=""Search tags..."">
                                </div>
                                <div class=""divider""></div>
                                <div class=""header""><i class=""tags icon""></i> 标签 </div>
                                <div class=""scrolling menu"">
                                    <div class=""item"">
                                        <div class=""ui red empty circular label""></div>家用电器
                                    </div>
                         ");
            WriteLiteral(@"           <div class=""item"">
                                        <div class=""ui blue empty circular label""></div>家具
                                    </div>
                                    <div class=""item"">
                                        <div class=""ui black empty circular label""></div>服装
                                    </div>
                                    <div class=""item"">
                                        <div class=""ui purple empty circular label""></div>手表
                                    </div>
                                    <div class=""item"">
                                        <div class=""ui orange empty circular label""></div>数码电器
                                    </div>
                                    <div class=""item"">
                                        <div class=""ui empty circular label""></div>药品
                                    </div>
                                    <div class=""item"">
                               ");
            WriteLiteral(@"         <div class=""ui yellow empty circular label""></div>食品
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""ten wide column""></div>
                    <div class=""three wide column"">
                        <div class=""ui menu"" style=""margin-left:0%"">
                            <a class=""browse item"">销量<i class=""dropdown icon""></i> </a>
                            <div class=""ui popup bottom left transition hidden"" style=""width:60%"">
                                <a class=""item"">销量从低到高</a>
                                <a class=""item"">销量从高到低</a>
                            </div>
                            <a class=""browse item"">价格<i class=""dropdown icon""></i> </a>
                            <div class=""ui popup bottom left transition hidden"" style=""width:60%"">
                                <a class=""item"">价格从低到高</a>
       ");
            WriteLiteral("                         <a class=\"item\">价格从高到低</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 115 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml"
                       
                        for(int i=0;i<(Model.shop.LSItem.Count()+3)/4;++i)
                        {

#line default
#line hidden
            BeginContext(5731, 250, true);
            WriteLiteral("                    <div class=\"ui grid container\" style=\"height:45%\">\r\n                        <div class=\"one wide column\"></div>\r\n                        <div class=\"fourteen wide column\">\r\n                            <div class=\"ui four cards\">\r\n");
            EndContext();
#line 122 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml"
                                  
                                    for (int j = i * 4; j < (i + 1) * 4 && j < Model.shop.LSItem.Count(); ++j)
                                    {

#line default
#line hidden
            BeginContext(6168, 65, true);
            WriteLiteral("                                        <div class=\"ui link card\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 6233, "\"", 6266, 1);
#line 125 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml"
WriteAttributeValue("", 6238, Model.shop.LSItem[j].itemID, 6238, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6267, 120, true);
            WriteLiteral(">\r\n                                            <div class=\"image\">\r\n                                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 6387, "", 6423, 1);
#line 127 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml"
WriteAttributeValue("", 6392, Model.shop.LSItem[j].imagePath, 6392, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6423, 284, true);
            WriteLiteral(@" style=""height:190px"" />
                                            </div>
                                            <div class=""content"">
                                                <div class=""row"">
                                                    <div class=""header"">");
            EndContext();
            BeginContext(6708, 29, false);
#line 131 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml"
                                                                   Write(Model.shop.LSItem[j].itemName);

#line default
#line hidden
            EndContext();
            BeginContext(6737, 309, true);
            WriteLiteral(@"</div>
                                                </div>
                                                <div class=""row"" style=""margin-top:5px"">
                                                    <h4>
                                                        <i class=""yen sign icon""></i>&nbsp;&nbsp;");
            EndContext();
            BeginContext(7047, 30, false);
#line 135 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml"
                                                                                            Write(Model.shop.LSItem[j].itemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(7077, 219, true);
            WriteLiteral("\r\n                                                    </h4>\r\n                                                </div>\r\n                                            </div>\r\n\r\n                                        </div>\r\n");
            EndContext();
#line 141 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml"
                                    }
                                

#line default
#line hidden
            BeginContext(7370, 96, true);
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 146 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(7516, 61, true);
            WriteLiteral("                    \r\n\r\n                    <div><br></div>\r\n");
            EndContext();
            BeginContext(7605, 535, true);
            WriteLiteral(@"                    <div class=""ui centered container"" align=""center"">
                        <div class=""ui pagination menu"" id=""page"">
                            <a class=""item active"" id=""1"">1</a>
                            <a class=""item"">2</a>
                            <a class=""item"">3</a>
                            <a class=""item"">4</a>
                        </div>
                    </div>
                    <div><br></div>
                </div>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
            BeginContext(8156, 1581, true);
            WriteLiteral(@"<div class=""ui basic modal"" id=""2"">
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
    $('.ui.rating')
        .rating()
        .rating('disable')
        ;
    $('.ui.dropdown').dropdown();
    $('.ui.rating').rating(""disable"");
    $('.ui .menu .browse')
        .popup({
            //inline: true,
            //hov");
            WriteLiteral(@"erable: true,
            position: 'bottom left',
            delay: {
                show: 300,
                hide: 800
            }
        })
        ;
    $('#page a.item').on('click', function () {
        var page = this.innerHTML;
        console.log(page);
        switch (page) {
            case ""1"": console.log(""a""); break;
        }
    });
    function love() {
        $('#2').modal('show');
    }

    $('#sss').on('click', function () {
        console.log(""aaa"");
    });
    function like() {
        var sid =");
            EndContext();
            BeginContext(9738, 17, false);
#line 224 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Shops\ShopDetails.cshtml"
            Write(Model.shop.shopID);

#line default
#line hidden
            EndContext();
            BeginContext(9755, 494, true);
            WriteLiteral(@"
        $.ajax({
            type: ""post"",
                url: ""/Collect/AddShopToCollection"",
            data: {
                s_id: sid
            },
            success: function (result) {
                alert(result)
            },
            error: function (result) {
                alert(result)
            }
        });
    }

    $('.ui.link.card').on('click', function () {
        standardPost(""/Goods/Details"", this.id, ""i_id"");
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
