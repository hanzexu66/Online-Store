#pragma checksum "E:\2--practice\vs\c#\DBPro\DBPro\Views\Search\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06dd0951f4e056aa9b5a44a86622743f97d52240"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Search), @"mvc.1.0.view", @"/Views/Search/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/Search.cshtml", typeof(AspNetCore.Views_Search_Search))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06dd0951f4e056aa9b5a44a86622743f97d52240", @"/Views/Search/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a40c1456db73c9a8353b2e70a1daa81653e306", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\2--practice\vs\c#\DBPro\DBPro\Views\Search\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
            BeginContext(42, 2839, true);
            WriteLiteral(@"
<div class=""ui grid"">
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
                        <div class=""ui black empty ci");
            WriteLiteral(@"rcular label""></div>服装
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
                <a class=""ite");
            WriteLiteral(@"m"">销量从低到高</a>
                <a class=""item"">销量从高到低</a>
            </div>
            <a class=""browse item"">价格<i class=""dropdown icon""></i> </a>
            <div class=""ui popup bottom left transition hidden"" style=""width:60%"">
                <a class=""item"">价格从低到高</a>
                <a class=""item"">价格从高到低</a>
            </div>
        </div>
    </div>
</div>
<h4 class=""ui horizontal divider header""><i class=""tag icon""></i> 搜索结果 </h4>
<br />
<div class=""ui grid container"" style=""height:300px"">
    <div class=""one wide column""></div>
    <div class=""fourteen wide column"">
        <div class=""one wide column""></div>
        <div class=""ui four cards"">
            <a class=""card"" style=""height:230px"">
                <div class=""image"">
                    ");
            EndContext();
            BeginContext(2881, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4a70b397ab0e44ba89e816f69bbd1057", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2913, 289, true);
            WriteLiteral(@"
                </div>
                <div class=""extra"">
                    评分: <div class=""ui star rating"" data-rating=""2""></div>
                </div>
            </a>
            <a class=""card"" style=""height:230px"">
                <div class=""image"">
                    ");
            EndContext();
            BeginContext(3202, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76bb908d7b2f42cdb8de05959618af79", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3234, 289, true);
            WriteLiteral(@"
                </div>
                <div class=""extra"">
                    评分: <div class=""ui star rating"" data-rating=""2""></div>
                </div>
            </a>
            <a class=""card"" style=""height:230px"">
                <div class=""image"">
                    ");
            EndContext();
            BeginContext(3523, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b06a36d2cf24e39a027833bcf6c40ac", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3555, 289, true);
            WriteLiteral(@"
                </div>
                <div class=""extra"">
                    评分: <div class=""ui star rating"" data-rating=""3""></div>
                </div>
            </a>
            <a class=""card"" style=""height:230px"">
                <div class=""image"">
                    ");
            EndContext();
            BeginContext(3844, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a63a068f920345e19891189943475ea1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3876, 544, true);
            WriteLiteral(@"
                </div>
                <div class=""extra"">
                    评分: <div class=""ui star rating"" data-rating=""4""></div>
                </div>
            </a>
        </div>
    </div>
</div>

<div class=""ui grid container"" style=""height:300px"">
    <div class=""one wide column""></div>
    <div class=""fourteen wide column"">
        <div class=""one wide column""></div>
        <div class=""ui four cards"">
            <a class=""card"" style=""height:230px"">
                <div class=""image"">
                    ");
            EndContext();
            BeginContext(4420, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6cb78235c9b545b1bd2184b2e1527d09", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4452, 289, true);
            WriteLiteral(@"
                </div>
                <div class=""extra"">
                    评分: <div class=""ui star rating"" data-rating=""2""></div>
                </div>
            </a>
            <a class=""card"" style=""height:230px"">
                <div class=""image"">
                    ");
            EndContext();
            BeginContext(4741, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0c1268c1462349dea22a4e89e266b4d3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4773, 289, true);
            WriteLiteral(@"
                </div>
                <div class=""extra"">
                    评分: <div class=""ui star rating"" data-rating=""2""></div>
                </div>
            </a>
            <a class=""card"" style=""height:230px"">
                <div class=""image"">
                    ");
            EndContext();
            BeginContext(5062, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a1a4c684988446c88f1037f01e4e3e6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5094, 289, true);
            WriteLiteral(@"
                </div>
                <div class=""extra"">
                    评分: <div class=""ui star rating"" data-rating=""3""></div>
                </div>
            </a>
            <a class=""card"" style=""height:230px"">
                <div class=""image"">
                    ");
            EndContext();
            BeginContext(5383, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fb828925b334fa991ed947fb81dab63", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5415, 544, true);
            WriteLiteral(@"
                </div>
                <div class=""extra"">
                    评分: <div class=""ui star rating"" data-rating=""4""></div>
                </div>
            </a>
        </div>
    </div>
</div>

<div class=""ui grid container"" style=""height:300px"">
    <div class=""one wide column""></div>
    <div class=""fourteen wide column"">
        <div class=""one wide column""></div>
        <div class=""ui four cards"">
            <a class=""card"" style=""height:230px"">
                <div class=""image"">
                    ");
            EndContext();
            BeginContext(5959, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c24b714945034608bbea63bdf71014f7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5991, 289, true);
            WriteLiteral(@"
                </div>
                <div class=""extra"">
                    评分: <div class=""ui star rating"" data-rating=""2""></div>
                </div>
            </a>
            <a class=""card"" style=""height:230px"">
                <div class=""image"">
                    ");
            EndContext();
            BeginContext(6280, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "528c97ce5d374e2296182db9ed83dd30", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6312, 289, true);
            WriteLiteral(@"
                </div>
                <div class=""extra"">
                    评分: <div class=""ui star rating"" data-rating=""2""></div>
                </div>
            </a>
            <a class=""card"" style=""height:230px"">
                <div class=""image"">
                    ");
            EndContext();
            BeginContext(6601, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "29791e841ab84f198cef193019e10e45", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6633, 289, true);
            WriteLiteral(@"
                </div>
                <div class=""extra"">
                    评分: <div class=""ui star rating"" data-rating=""3""></div>
                </div>
            </a>
            <a class=""card"" style=""height:230px"">
                <div class=""image"">
                    ");
            EndContext();
            BeginContext(6922, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e3c1b1605b247afb085b86e4b3a1660", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6954, 1018, true);
            WriteLiteral(@"
                </div>
                <div class=""extra"">
                    评分: <div class=""ui star rating"" data-rating=""4""></div>
                </div>
            </a>
        </div>
    </div>
</div>

<div style=""text-align:center"">
    <div class=""ui pagination menu"" id=""page"">
        <a class=""item active"" id=""1"">1</a>
        <a class=""item"">2</a>
        <a class=""item"">3</a>
        <a class=""item"">4</a>
    </div>
</div>
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
    $('#page a.item').on('click', function () {
        var page = this.innerHTML;
        console.log(page);
        switch (page) {
            case ""1"": console.log(""a""); break;
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
