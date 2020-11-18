#pragma checksum "E:\Sneaker\SneakerShop\SneakerShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77ec7b3cdb52770cce236772e3b7179bac69abd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "E:\Sneaker\SneakerShop\SneakerShop\Views\_ViewImports.cshtml"
using SneakerShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Sneaker\SneakerShop\SneakerShop\Views\_ViewImports.cshtml"
using SneakerShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77ec7b3cdb52770cce236772e3b7179bac69abd5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6f7dcd9f6a759b60a3b3f677538b0f8009ea62", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Sneaker\SneakerShop\SneakerShop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""slide-show"">
    <div id=""mycarousel"" class=""carousel slide"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#mycarousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#mycarousel"" data-slide-to=""1""");
            BeginWriteAttribute("class", " class=\"", 331, "\"", 339, 0);
            EndWriteAttribute();
            WriteLiteral(@"></li>
        </ol>
        <ol class=""carousel-iconbar"">
            <li><i class=""fab fa-instagram carousel-icon""></i> </li>
            <li><i class=""fab fa-facebook-square carousel-icon""></i></li>
            <li><i class=""fab fa-pinterest-square carousel-icon""></i></li>
            <li><i class=""fab fa-twitter-square carousel-icon""></i></li>
        </ol>
        <div class=""carousel-inner"">
            <!--Slide 1-->
            <div class=""carousel-item active"">
                <img class=""d-block w-100"" src=""/img/hero-1.jpg"">
                <div class=""carousel-content"">
                    <h1>
                        Summer Collection
                    </h1>
                    <h2>Fall - Winter Collections 2030</h2>
                    <p>A speciallist label creating luxry essentials. Ethically crafted with an unwavering commitment to exceptional quality.</p>
                    <a class=""carousel-shop"" href=""#""> SHOP NOW </a>
                </div>
            </div>
     ");
            WriteLiteral(@"       <!--Slide 2-->
            <div class=""carousel-item"">
                <img class=""d-block w-100"" src=""/img/hero-2.jpg"">
                <div class=""carousel-content"">
                    <h1>
                        Summer Collection B
                    </h1>
                    <h2>Fall - Winter Collections 2030</h2>
                    <p>A speciallist label creating luxry essentials. Ethically crafted with an unwavering commitment to exceptional quality.</p>
                    <a class=""carousel-shop"" href=""#""> SHOP NOW </a>
                </div>
            </div>

        </div>

        <a class=""carousel-control-prev"" href=""#mycarousel"" role=""button"" data-slide=""prev""> <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span> <span class=""sr-only"">Previous</span></a>
        <a class=""carousel-control-next"" href=""#mycarousel"" role=""button"" data-slide=""next""> <span class=""carousel-control-next-icon"" aria-hidden=""true""></span> <span class=""sr-only"">Next</span> </a>
");
            WriteLiteral(@"    </div>
</section>

<section class=""banner sqad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7 offset-lg-4"">
                <div class=""banner_item"">
                    <div class=""banner_item_pic"">
                        <img src=""/img/banner-1.jpg"" />
                    </div>
                    <div class=""banner_item_text"">
                        <h2>Clothing Collections 2030</h2>
                        <a class=""banner-shop"" href=""#"">Shop now</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-5 banner1"">
                <div class=""banner_item banner_item-middle"">
                    <div class=""banner_item_pic"">
                        <img src=""/img/banner-2.jpg"" />
                    </div>
                    <div class=""banner_item_text"">
                        <h2>Accessories</h2>
                        <a class=""banner-shop"" href=""#"">Shop now</a>
                    ");
            WriteLiteral(@"</div>
                </div>
            </div>
            <div class=""col-lg-7 banner2"">
                <div class=""banner_item banner_item-bottom"">
                    <div class=""banner_item_pic"">
                        <img src=""img/banner-3.jpg"" />
                    </div>
                    <div class=""banner_item_text"">
                        <h2>Shoes Spring <br> 2030</h2>
                        <a class=""banner-shop"" href=""#"">Shop now</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""categories-sqad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 sale1"">
                <div class=""categories-text"">
                    <h2>
                        Converse <br>
                        <span>Shoe Collection</span> <br>
                        Palladium
                    </h2>
                </div>
            </div>
            <div class=""col-");
            WriteLiteral(@"lg-4 sale2"">
                <div class=""hot-deal"">
                    <img src=""img/product-sale.png"" />
                </div>
                <div class=""hot-deal-sticker"">
                    <span>Get</span>
                    <h5>THIS</h5>
                </div>
            </div>
            <div class=""col-lg-4 offset-lg-1 sale3"">
                <span>Deal Only For The Week</span>
                <h2>Multi-pocket Chest Bag Black</h2>
                <h5>
                    Buy 1 Get 1 Bonus <br>
                    <span>Multi-pocket Chest Bag Black</span>
                </h5>
                <a href=""#"" class=""sale-btn"">Shop now</a>
            </div>
        </div>
    </div>
</section>
");
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
