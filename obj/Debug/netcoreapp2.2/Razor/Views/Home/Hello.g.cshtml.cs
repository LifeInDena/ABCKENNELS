#pragma checksum "C:\Users\Peyton White\Desktop\CAPL\ABCKENNELS\Views\Home\Hello.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5019340001bb91acf0f814b849ea339a179de213"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Hello), @"mvc.1.0.view", @"/Views/Home/Hello.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Hello.cshtml", typeof(AspNetCore.Views_Home_Hello))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5019340001bb91acf0f814b849ea339a179de213", @"/Views/Home/Hello.cshtml")]
    public class Views_Home_Hello : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/yeahh.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Me"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-image w3-padding-32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("600"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("650"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-light-grey w3-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:1600px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2469, true);
            WriteLiteral(@" <!DOCTYPE html>
<html lang=""en"">
<title>Owners</title>
<meta charset=""UTF-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Raleway"">
<style>
body,h1,h2,h3,h4,h5 {font-family: ""Raleway"", sans-serif}
.w3-third img{margin-bottom: -6px; opacity: 0.8; cursor: pointer}
.w3-third img:hover{opacity: 1}
.noo{
  font-size:25px;
}
</style>
<script>
// Script to open and close sidebar
function w3_open() {
    document.getElementById(""mySidebar"").style.display = ""block"";
    document.getElementById(""myOverlay"").style.display = ""block"";
}

function w3_close() {
    document.getElementById(""mySidebar"").style.display = ""none"";
    document.getElementById(""myOverlay"").style.display = ""none"";
}

// Modal Image Gallery
function onClick(element) {
    document.getElementById(""img01"").src = element.src;
    document.getElementById(""modal");
            WriteLiteral(@"01"").style.display = ""block"";
    var captionText = document.getElementById(""caption"");
    captionText.innerHTML = element.alt;
}

</script>
<!-- Sidebar/menu -->
<nav class=""w3-sidebar w3-bar-block w3-white w3-animate-left w3-text-grey w3-collapse w3-top w3-center"" style=""z-index:3;width:300px;font-weight:bold"" id=""mySidebar""><br>
    <h3 class=""w3-padding-64 w3-center noo""><b>ABC<br>KENNELS</b></h3>
    <a href=""/"" class=""w3-bar-item w3-button noo"">HOME</a>
    <a href=""javascript:void(0)"" onclick=""w3_close()"" class=""w3-bar-item w3-button w3-padding w3-hide-large"">CLOSE</a>
    <a href=""/hello"" onclick=""w3_close()"" class=""w3-bar-item w3-button noo"">About Us</a> 
    <a href=""/great"" class=""w3-bar-item w3-button noo"">Great Danes</a> 
    <a href=""/york"" onclick=""w3_close()"" class=""w3-bar-item w3-button noo"">Yorkshire Terrier</a>
    <a href=""/buy"" class=""w3-bar-item w3-button noo"">Available Puppies</a>
</nav>

<!-- Top menu on small screens -->
<header class=""w3-container w3-top w3-hide-la");
            WriteLiteral(@"rge w3-white w3-xlarge w3-padding-16"">
    <span class=""w3-left w3-padding"">ABC KENNELS</span>
    <a href=""javascript:void(0)"" class=""w3-right w3-button w3-white"" onclick=""w3_open()"">☰</a>
</header>

<!-- Overlay effect when opening sidebar on small screens -->
<div class=""w3-overlay w3-hide-large w3-animate-opacity"" onclick=""w3_close()"" style=""cursor:pointer"" title=""close side menu"" id=""myOverlay""></div>


");
            EndContext();
            BeginContext(2469, 2890, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5019340001bb91acf0f814b849ea339a179de2137972", async() => {
                BeginContext(2533, 162, true);
                WriteLiteral("\r\n<!-- About section -->\r\n    <div class=\"w3-container w3-dark-grey w3-center w3-text-light-grey w3-padding-32\" id=\"about\">\r\n    <h4><b>ABC KENNELS</b></h4>\r\n    ");
                EndContext();
                BeginContext(2695, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5019340001bb91acf0f814b849ea339a179de2138527", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2790, 2562, true);
                WriteLiteral(@"
    <div class=""w3-content w3-justify"" style=""max-width:600px"">
        <h4>OWNERS</h4>
        <p>Brian is a professional barber and Agnes a police officer. In our spare time we enjoy our Great danes and Yorkshire terriers. 
            They bring us so much joy that we decided to start breeding to share our joy with others.  We have been breeding for six years.
            Agnes is currently enrolled at Penn Foster to get her degree in veterinarian technician.
            Let one of our puppies large or small bring joy to your life.
        </p>
        <a href=""mailto: kennelsabc@gmail.com"" >
        <i class=""fa fa-book w3-xxlarge""></i>
        <p>kennelsabc@gmail.com</p>
        </a>
        <a href=""tel:626-827-8455"" >
            <i class=""fa fa-phone w3-xxlarge""></i>
            <p>626-827-8455</p>
        </a>

        <h4 class=""w3-padding-16"">Pricing</h4>
        <div class=""w3-row-padding"" style=""margin:0 -16px"">
        <div class=""w3-half w3-margin-bottom"">
            <ul c");
                WriteLiteral(@"lass=""w3-ul w3-white w3-center w3-opacity w3-hover-opacity-off"">
            <li class=""w3-black w3-xlarge w3-padding-32 noo"">Great Danes</li>
            <li class=""w3-padding-16 noo"">Large Breed</li>
            <li class=""w3-padding-16 noo""><a href=""/gdpups"">Great Dane Puppies</a></li>
            <li class=""w3-padding-16 noo"">Sire:Sir Bentley</li>
            <li class=""w3-padding-16 noo"">Sire:Sir Fred</li>
            <li class=""w3-padding-16 noo"">Dam:Isis</li>
            <li class=""w3-padding-16 noo"">Dam:Diamond</li>
            <li class=""w3-padding-16 noo"">
            <h2><a href=""mailto: kennelsabc@gmail.com"" >
        <i class=""fa fa-book w3-xxlarge""></i>
        <p>Email for pricing</p></h2>
            </li>
            </ul>
        </div>
        
        <div class=""w3-half"">
            <ul class=""w3-ul w3-white w3-center w3-opacity w3-hover-opacity-off"">
            <li class=""w3-black w3-xlarge w3-padding-32 noo"">Yorkies</li>
            <li class=""w3-padding-16 noo"">Sma");
                WriteLiteral(@"ll Breed</li>
            <li class=""w3-padding-16 noo""><a href=""/ypups"">Yorkshire Terrier Puppies</a></li>
            <li class=""w3-padding-16 noo"">Sire:Sir Buster</li>
            <li class=""w3-padding-16 noo"">Dam:Cardi</li>
            <li class=""w3-padding-16 noo"">
            <h2><a href=""mailto: kennelsabc@gmail.com"" >
        <i class=""fa fa-book w3-xxlarge""></i>
        <p>Email for pricing</p></h2>
            </li>
            </ul>
        </div>
        </div>
    </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
