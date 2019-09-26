#pragma checksum "E:\2--practice\vs\c#\DBPro\DBPro\Views\Search\ItemSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "065b7e305148cc9baccd64d214b6dfb0dffee3c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_ItemSearch), @"mvc.1.0.view", @"/Views/Search/ItemSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/ItemSearch.cshtml", typeof(AspNetCore.Views_Search_ItemSearch))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"065b7e305148cc9baccd64d214b6dfb0dffee3c2", @"/Views/Search/ItemSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a40c1456db73c9a8353b2e70a1daa81653e306", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_ItemSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("four wide column"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Search\ItemSearch.cshtml"
  
    ViewData["Title"] = "ItemSearch";

#line default
#line hidden
            BeginContext(70, 2614, true);
            WriteLiteral(@"<div class=""ui grid"">
    <div class=""three wide column""></div>
    <div class=""four wide column"">
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
                    <div class=""item"">
                        <div class=""ui blue empty circular label""></div>家具
                    </div>
                    <div class=""item"">
                        <div class=""ui black empty circ");
            WriteLiteral(@"ular label""></div>服装
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
                        <div class=""ui yellow empty circular label""></div>食品
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""three wide column""></div>
    <div class=""three wide column"">
        <div class=""ui menu"" style=""margin-left:30%"">
            <a class=""browse item"">销量<i class=""dropdown icon""></i> </a>
            <div class=""ui popup bottom left transition hidden"" style=""width:60%"">
                <a class=""item""");
            WriteLiteral(@" onclick=""SortScoreUp()"">销量从低到高</a>
                <a class=""item"" onclick=""SortScoreDown()"">销量从高到低</a>
            </div>
            <a class=""browse item"">价格<i class=""dropdown icon""></i> </a>
            <div class=""ui popup bottom left transition hidden"" style=""width:60%"">
                <a class=""item"" onclick=""SortPriceUp()"">价格从低到高</a>
                <a class=""item"" onclick=""SortPriceDown()"">价格从高到低</a>
            </div>
        </div>
    </div>
</div>
<h4 class=""ui horizontal divider header""><i class=""tag icon""></i> 搜索结果 </h4>
<br />

");
            EndContext();
#line 63 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Search\ItemSearch.cshtml"
   
    for(int j=0;j< (@Model.LSItem.Count()+3)/4;++j)
    {

#line default
#line hidden
            BeginContext(2749, 170, true);
            WriteLiteral("<div class=\"ui grid container\" style=\"height:45%\">\r\n    <div class=\"one wide column\"></div>\r\n    <div class=\"fourteen wide column\">\r\n        <div class=\"ui four cards\">\r\n");
            EndContext();
#line 70 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Search\ItemSearch.cshtml"
              
                for (int i = j*4; i < @Model.LSItem.Count() && i < (j+1)*4; ++i)
                {

#line default
#line hidden
            BeginContext(3036, 78, true);
            WriteLiteral("                    <div class=\"ui link card\" onmousedown=\"clickCard(this.id)\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 3114, "", 3141, 1);
#line 73 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Search\ItemSearch.cshtml"
WriteAttributeValue("", 3118, Model.LSItem[i].itemID, 3118, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3141, 80, true);
            WriteLiteral(">\r\n                        <div class=\"image\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 3221, "", 3252, 1);
#line 75 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Search\ItemSearch.cshtml"
WriteAttributeValue("", 3226, Model.LSItem[i].imagePath, 3226, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3252, 204, true);
            WriteLiteral(" style=\"height:190px\" />\r\n                        </div>\r\n                        <div class=\"content\">\r\n                            <div class=\"row\">\r\n                                <div class=\"header\">");
            EndContext();
            BeginContext(3457, 24, false);
#line 79 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Search\ItemSearch.cshtml"
                                               Write(Model.LSItem[i].itemName);

#line default
#line hidden
            EndContext();
            BeginContext(3481, 229, true);
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"row\" style=\"margin-top:5px\">\r\n                                <h4>\r\n                                    <i class=\"yen sign icon\"></i>&nbsp;&nbsp;");
            EndContext();
            BeginContext(3711, 25, false);
#line 83 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Search\ItemSearch.cshtml"
                                                                        Write(Model.LSItem[i].itemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(3736, 270, true);
            WriteLiteral(@"
                                </h4>
                            </div>
                        </div>
                        <div class=""extra content"">
                            <i class=""home blue link icon"" onmousemove=""deleteFunc()"" onmouseout=""addFunc()""");
            EndContext();
            BeginWriteAttribute("id", " id=", 4006, "", 4033, 1);
#line 88 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Search\ItemSearch.cshtml"
WriteAttributeValue("", 4010, Model.LSItem[i].shopID, 4010, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4033, 23, true);
            WriteLiteral("></i>&nbsp;&nbsp;&nbsp;");
            EndContext();
            BeginContext(4057, 24, false);
#line 88 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Search\ItemSearch.cshtml"
                                                                                                                                                         Write(Model.LSItem[i].shopName);

#line default
#line hidden
            EndContext();
            BeginContext(4081, 62, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 91 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Search\ItemSearch.cshtml"
                }
            

#line default
#line hidden
            BeginContext(4177, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 96 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Search\ItemSearch.cshtml"
    }

#line default
#line hidden
            BeginContext(4223, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(4240, 303, true);
            WriteLiteral(@"<div class=""ui grid container"">
    <div class=""five wide column""></div>
    <div class=""six wide column"" style=""text-align:center"">
        <i class=""large chevron left link icon""></i>
        <b><font size=""3"">1/4</font></b>
        <i class=""large chevron right link icon""></i>
    </div>
    ");
            EndContext();
            BeginContext(4543, 430, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1823b862ee7a426ea797a68aac58306b", async() => {
                BeginContext(4613, 353, true);
                WriteLiteral(@"
        <b>
            <font size=""3"">
                第
                <div class=""ui input mini focus"">
                    <input type=""text"" value=""1"" style=""width:41px;height:28px"">
                </div>
                页
            </font>
        </b>
        <button type=""submit"" class=""ui tiny compact button"">GO!</button>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(4973, 1009, true);
            WriteLiteral(@"
</div>
<script>
    function SortScoreDown() {
        standardPost(""/Search/ItemSearch"", 0, ""sortType"");
    }
    function SortScoreUp() {
        standardPost(""/Search/ItemSearch"", 1, ""sortType"");
    }
    function SortPriceUp() {
        standardPost(""/Search/ItemSearch"", 3, ""sortType"");
    }
    function SortPriceDown() {
        standardPost(""/Search/ItemSearch"", 2, ""sortType"");
    }
</script>
<script>
    $('.ui.dropdown').dropdown();
    $('.ui.rating').rating(""disable"");
    $('.ui .menu .browse')
        .popup({
            //inline: true,
            //hoverable: true,
            position: 'bottom left',
            delay: {
                show: 300,
                hide: 800
            }
        })
        ;
    //不用
    //$('#page a.item').on('click', function () {
    //    var page = this.innerHTML;
    //    console.log(page);
    //    switch (page) {
    //        case ""1"": console.log(""a""); break;
    //    }
    //});
</script>
");
            EndContext();
            BeginContext(5997, 655, true);
            WriteLiteral(@"<script>
    //$('.ui.link.card').on('click', function () {
    //    //alert(this.id);
    //    standardPost(""/Goods/Details"", this.id, ""i_id"");
    //});

    //跳转到对应店铺页面
    $('.home').on('click', function () {
       // alert(this.id);
        standardPost(""/Shops/ShopDetails"", this.id, ""s_id"");
    });
    //跳转到商品页面
    function clickCard(id) {
       // alert(id);
        standardPost(""/Goods/Details"", id, ""i_id"");
    }
    function deleteFunc() {
        $('.ui.link.card').removeAttr('onmousedown');
    }
    function addFunc() {
        $('.ui.link.card').attr({ ""onmousedown"": ""clickCard(this.id)""});
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
