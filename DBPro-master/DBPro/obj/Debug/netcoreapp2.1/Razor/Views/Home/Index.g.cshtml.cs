#pragma checksum "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91c58818b7fbcfdc85020415cc71c111570a2957"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c58818b7fbcfdc85020415cc71c111570a2957", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a40c1456db73c9a8353b2e70a1daa81653e306", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DBPro.Models.HomeIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(85, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(90, 19, false);
#line 5 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(109, 1093, true);
            WriteLiteral(@"</h1>
<div class=""ui grid container"" style=""height:500px"">
    <div class=""one wide column""></div>
    <div class=""three wide column"">
        <div class=""ui vertical pointing menu"" style=""text-align:center;"">
            <a class=""item"" id=""electric"">家用电器 </a>
            <a class=""item"" id=""smartphone"">手机 </a>
            <a class=""item"" id=""computer"">电脑 </a>
            <a class=""item"" id=""furniture"">家具 </a>
            <a class=""item"" id=""clothing"">服装 </a>
            <a class=""item"" id=""makeup"">美妆 </a>
            <a class=""item"" id=""shoes"">女鞋 </a>
            <a class=""item"" id=""car"">汽车 </a>
            <a class=""item"" id=""food"">食品 </a>
            <a class=""item"" id=""medicine"">医药 </a>
            <a class=""item"" id=""book"">图书 </a>
            <a class=""item"" id=""vproduct"">虚拟商品 </a>
        </div>
    </div>
    <div class=""eleven wide column"" style=""position: relative"">
        <div class=""container"" style=""height:350px;"">
            <div align=""center"">
                <img name=");
            WriteLiteral("\"obj\" id=\"改成商品id，此id作为ItemID传入Details\" class=\"ui medium rounde image\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 1202, "", 1236, 1);
#line 27 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
WriteAttributeValue("", 1207, Model.CycleItem[0].imagePath, 1207, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1236, 319, true);
            WriteLiteral(@"
                     style=""height:460px; width:730px;margin-left:20px;margin-top:10px"">

            </div>
        </div>
        <div class=""container"" style=""height:50px"">
            <div align=""center"">
                <div class=""blue mini ui buttons"" style=""position: absolute;left:295px;bottom:25px"">
");
            EndContext();
#line 35 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
                      
                        for (int i = 0; i < 5; i++)
                        {

#line default
#line hidden
            BeginContext(1659, 35, true);
            WriteLiteral("                            <button");
            EndContext();
            BeginWriteAttribute("id", " id=", 1694, "", 1717, 1);
#line 38 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
WriteAttributeValue("", 1698, (i+1).ToString(), 1698, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1717, 106, true);
            WriteLiteral(" onmousemove=\"seePicture(this.id)\" onmouseout=\"releasePicture(this.id)\" class=\"ui inverted  basic button\">");
            EndContext();
            BeginContext(1825, 5, false);
#line 38 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
                                                                                                                                                                Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1831, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 39 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1892, 460, true);
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>



<div class=""ui grid container"" style=""height:45%"">
    <div class=""one wide column""></div>
    <div class=""fourteen wide column"" style=""background-color:lightgrey"">
        <a class=""ui teal ribbon label"" style=""width:10%; height:10%"">
            <font size=""3"">服装</font>
        </a>
        <div class=""one wide column""></div>
        <div class=""ui four cards"">
");
            EndContext();
#line 57 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
              
                for (int i = 0; i < 4&&i< Model.CostumeItem.Count(); ++i)
                {

#line default
#line hidden
            BeginContext(2462, 58, true);
            WriteLiteral("            <div class=\"ui link card\" style=\"height:290px\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 2520, "", 2556, 1);
#line 60 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
WriteAttributeValue("", 2524, string.Format("Costume{0}",i), 2524, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2556, 31, true);
            WriteLiteral(">\r\n                <div hidden>");
            EndContext();
            BeginContext(2588, 27, false);
#line 61 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
                       Write(Model.CostumeItem[i].itemID);

#line default
#line hidden
            EndContext();
            BeginContext(2615, 69, true);
            WriteLiteral("</div>\r\n                <div class=\"image\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 2684, "", 2720, 1);
#line 63 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
WriteAttributeValue("", 2689, Model.CostumeItem[i].imagePath, 2689, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2720, 152, true);
            WriteLiteral(" style=\"height:245px;\" />\r\n                </div>\r\n                <div class=\"extra\">\r\n                    评分: <div class=\"ui star rating\" data-rating=");
            EndContext();
            BeginContext(2873, 30, false);
#line 66 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
                                                           Write(Model.CostumeItem[i].itemScore);

#line default
#line hidden
            EndContext();
            BeginContext(2903, 73, true);
            WriteLiteral(" data-max-rating=\"5\"></div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 69 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(3010, 390, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<br />
<br />
<br />
<div class=""ui grid container"" style=""height:50%"">
    <div class=""one wide column""></div>
    <div class=""fourteen wide column"" style=""background-color:lightgrey"">
        <a class=""ui red ribbon label"" style=""width:10%; height:10%"">
            <font size=""3"">电脑数码</font>
        </a>
        <div class=""ui four cards"">
");
            EndContext();
#line 84 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
              
                for (int i = 0; i < 4&&i< Model.DigitItem.Count(); ++i)
                {


#line default
#line hidden
            BeginContext(3510, 58, true);
            WriteLiteral("            <div class=\"ui link card\" style=\"height:290px\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 3568, "", 3602, 1);
#line 88 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
WriteAttributeValue("", 3572, string.Format("Digit{0}",i), 3572, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3602, 31, true);
            WriteLiteral(">\r\n                <div hidden>");
            EndContext();
            BeginContext(3634, 25, false);
#line 89 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
                       Write(Model.DigitItem[i].itemID);

#line default
#line hidden
            EndContext();
            BeginContext(3659, 69, true);
            WriteLiteral("</div>\r\n                <div class=\"image\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 3728, "", 3762, 1);
#line 91 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
WriteAttributeValue("", 3733, Model.DigitItem[i].imagePath, 3733, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3762, 150, true);
            WriteLiteral(" style=\"height:245px\"/>\r\n                </div>\r\n                <div class=\"extra\">\r\n                    评分: <div class=\"ui star rating\" data-rating=");
            EndContext();
            BeginContext(3913, 28, false);
#line 94 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
                                                           Write(Model.DigitItem[i].itemScore);

#line default
#line hidden
            EndContext();
            BeginContext(3941, 73, true);
            WriteLiteral(" data-max-rating=\"5\"></div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 97 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(4048, 393, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<br />
<br />
<br />
<div class=""ui grid container"" style=""height:50%"">
    <div class=""one wide column""></div>
    <div class=""fourteen wide column"" style=""background-color:lightgrey"">
        <a class=""ui blue ribbon label"" style=""width:10%; height:10%"">
            <font size=""3"">居家用品</font>
        </a>
        <div class=""ui four cards"">
");
            EndContext();
#line 113 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
              
                for (int i = 0; i < 4&&i< Model.DailyItem.Count(); ++i)
                {

#line default
#line hidden
            BeginContext(4549, 58, true);
            WriteLiteral("            <div class=\"ui link card\" style=\"height:290px\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 4607, "", 4641, 1);
#line 116 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
WriteAttributeValue("", 4611, string.Format("Daily{0}",i), 4611, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4641, 31, true);
            WriteLiteral(">\r\n                <div hidden>");
            EndContext();
            BeginContext(4673, 25, false);
#line 117 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
                       Write(Model.DailyItem[i].itemID);

#line default
#line hidden
            EndContext();
            BeginContext(4698, 69, true);
            WriteLiteral("</div>\r\n                <div class=\"image\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 4767, "", 4801, 1);
#line 119 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
WriteAttributeValue("", 4772, Model.DailyItem[i].imagePath, 4772, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4801, 150, true);
            WriteLiteral(" style=\"height:245px\"/>\r\n                </div>\r\n                <div class=\"extra\">\r\n                    评分: <div class=\"ui star rating\" data-rating=");
            EndContext();
            BeginContext(4952, 28, false);
#line 122 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
                                                           Write(Model.DailyItem[i].itemScore);

#line default
#line hidden
            EndContext();
            BeginContext(4980, 73, true);
            WriteLiteral(" data-max-rating=\"5\"></div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 125 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(5087, 283, true);
            WriteLiteral(@"

        </div>
    </div>
</div>
<script>
    $('.ui.dropdown').dropdown();
    $('.ui.rating').rating(""disable"");
</script>
<script language=javascript>
    var curIndex = 0;
    var timeInterval = 3000;
    var isfocus = 0;
    var arr = new Array();
    arr[0] = """);
            EndContext();
            BeginContext(5371, 28, false);
#line 141 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
         Write(Model.CycleItem[0].imagePath);

#line default
#line hidden
            EndContext();
            BeginContext(5399, 18, true);
            WriteLiteral("\";\r\n    arr[1] = \"");
            EndContext();
            BeginContext(5418, 28, false);
#line 142 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
         Write(Model.CycleItem[1].imagePath);

#line default
#line hidden
            EndContext();
            BeginContext(5446, 18, true);
            WriteLiteral("\";\r\n    arr[2] = \"");
            EndContext();
            BeginContext(5465, 28, false);
#line 143 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
         Write(Model.CycleItem[2].imagePath);

#line default
#line hidden
            EndContext();
            BeginContext(5493, 18, true);
            WriteLiteral("\";\r\n    arr[3] = \"");
            EndContext();
            BeginContext(5512, 28, false);
#line 144 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
         Write(Model.CycleItem[3].imagePath);

#line default
#line hidden
            EndContext();
            BeginContext(5540, 18, true);
            WriteLiteral("\";\r\n    arr[4] = \"");
            EndContext();
            BeginContext(5559, 28, false);
#line 145 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Home\Index.cshtml"
         Write(Model.CycleItem[4].imagePath);

#line default
#line hidden
            EndContext();
            BeginContext(5587, 879, true);
            WriteLiteral(@""";
    setInterval(changeImg, timeInterval);
    function sleep_() {
        obj.src = arr[curIndex];
        $('.ui.medium.rounded.bordered.image').transition('fade left');
    }
    function changeImg() {
        if (isfocus == 0) {
            var obj = document.getElementsByName(""obj"")[0];
            $('.ui.medium.rounded.bordered.image').transition('fade right');
            if (curIndex == arr.length - 1) {
                curIndex = 0;
            }
            else {
                curIndex += 1;
            }

            setTimeout(sleep_, 320);
        }
    }
</script>
<script>
    function seePicture(id) {
        var obj = document.getElementsByName(""obj"")[0];
        isfocus = 1;
        obj.src = arr[id - 1];
        curIndex = id - 1;
    }
    function releasePicture(id) {

        isfocus = 0;

    }

</script>
");
            EndContext();
            BeginContext(6475, 599, true);
            WriteLiteral(@"<script>
    $('.ui.link.card').on('click', function () {
        var i_id = document.getElementById(this.id).getElementsByTagName(""div"")[0].innerHTML;

        standardPost(""/Goods/Details"", i_id,""i_id"");
    });
    $('.ui.medium.rounded.bordered.image').on('click', function () {
        var i_id = document.getElementById(this.id).getElementsByTagName(""div"")[0].innerHTML;
        standardPost(""/Goods/Details"", i_id, ""i_id"");
    });
    $('.ui.vertical.pointing.menu a.item').on('click', function () {
        standardPost(""/Search/ItemSearch"", this.id, ""type"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DBPro.Models.HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591