#pragma checksum "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Shops\ShopDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "306767f429d95aef5a43b8b18bddd3ea2e54a484"
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
#line 1 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\_ViewImports.cshtml"
using DBPro;

#line default
#line hidden
#line 2 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\_ViewImports.cshtml"
using DBPro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"306767f429d95aef5a43b8b18bddd3ea2e54a484", @"/Views/Shops/ShopDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a40c1456db73c9a8353b2e70a1daa81653e306", @"/Views/_ViewImports.cshtml")]
    public class Views_Shops_ShopDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Shops\ShopDetails.cshtml"
  
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
#line 11 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Shops\ShopDetails.cshtml"
WriteAttributeValue("", 279, Model.shop.imagePath, 279, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(300, 129, true);
            WriteLiteral(" class=\"ui small circular image\" style=\"width:55px;height:55px;\">\r\n                <div class=\"content\">\r\n                    <a>");
            EndContext();
            BeginContext(430, 19, false);
#line 13 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Shops\ShopDetails.cshtml"
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
#line 33 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Shops\ShopDetails.cshtml"
          Write(Model.shop.shopIntroduction);

#line default
#line hidden
            EndContext();
            BeginContext(1340, 60, true);
            WriteLiteral("</p>\r\n            <br>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(1410, 106, true);
            WriteLiteral("<div class=\"ui grid container\">\r\n    <div class=\"sixteen wide column\">\r\n        <div class=\"ui segment\">\r\n");
            EndContext();
            BeginContext(1543, 106, true);
            WriteLiteral("            <div class=\"ui top attached tabular menu\">\r\n                <a class=\"item active\">店铺商品 </a>\r\n");
            EndContext();
            BeginContext(2025, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
            BeginContext(2067, 54, true);
            WriteLiteral("            <div class=\"ui bottom attached segment\">\r\n");
            EndContext();
            BeginContext(2152, 92, true);
            WriteLiteral("                <div class=\"ui grid\">\r\n                    <div class=\"three wide column\">\r\n");
            EndContext();
            BeginContext(4419, 85, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"ten wide column\"></div>\r\n");
            EndContext();
#line 111 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Shops\ShopDetails.cshtml"
                       
                        for(int i=0;i<(Model.shop.LSItem.Count()+3)/4;++i)
                        {

#line default
#line hidden
            BeginContext(5537, 250, true);
            WriteLiteral("                    <div class=\"ui grid container\" style=\"height:45%\">\r\n                        <div class=\"one wide column\"></div>\r\n                        <div class=\"fourteen wide column\">\r\n                            <div class=\"ui four cards\">\r\n");
            EndContext();
#line 118 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Shops\ShopDetails.cshtml"
                                  
                                    for (int j = i * 4; j < (i + 1) * 4 && j < Model.shop.LSItem.Count(); ++j)
                                    {

#line default
#line hidden
            BeginContext(5974, 65, true);
            WriteLiteral("                                        <div class=\"ui link card\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 6039, "\"", 6072, 1);
#line 121 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Shops\ShopDetails.cshtml"
WriteAttributeValue("", 6044, Model.shop.LSItem[j].itemID, 6044, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6073, 120, true);
            WriteLiteral(">\r\n                                            <div class=\"image\">\r\n                                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 6193, "", 6229, 1);
#line 123 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Shops\ShopDetails.cshtml"
WriteAttributeValue("", 6198, Model.shop.LSItem[j].imagePath, 6198, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6229, 284, true);
            WriteLiteral(@" style=""height:190px"" />
                                            </div>
                                            <div class=""content"">
                                                <div class=""row"">
                                                    <div class=""header"">");
            EndContext();
            BeginContext(6514, 29, false);
#line 127 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Shops\ShopDetails.cshtml"
                                                                   Write(Model.shop.LSItem[j].itemName);

#line default
#line hidden
            EndContext();
            BeginContext(6543, 309, true);
            WriteLiteral(@"</div>
                                                </div>
                                                <div class=""row"" style=""margin-top:5px"">
                                                    <h4>
                                                        <i class=""yen sign icon""></i>&nbsp;&nbsp;");
            EndContext();
            BeginContext(6853, 30, false);
#line 131 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Shops\ShopDetails.cshtml"
                                                                                            Write(Model.shop.LSItem[j].itemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(6883, 219, true);
            WriteLiteral("\r\n                                                    </h4>\r\n                                                </div>\r\n                                            </div>\r\n\r\n                                        </div>\r\n");
            EndContext();
#line 137 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Shops\ShopDetails.cshtml"
                                    }
                                

#line default
#line hidden
            BeginContext(7176, 96, true);
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 142 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Shops\ShopDetails.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(7322, 61, true);
            WriteLiteral("                    \r\n\r\n                    <div><br></div>\r\n");
            EndContext();
            BeginContext(7833, 117, true);
            WriteLiteral("                    <div><br></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(7966, 1583, true);
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
        var sid = """);
            EndContext();
            BeginContext(9550, 17, false);
#line 220 "C:\Users\hanzexu66\Desktop\第8组_1754017_韩泽旭_网购系统\program\DBPro\Views\Shops\ShopDetails.cshtml"
              Write(Model.shop.shopID);

#line default
#line hidden
            EndContext();
            BeginContext(9567, 496, true);
            WriteLiteral(@""";
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
