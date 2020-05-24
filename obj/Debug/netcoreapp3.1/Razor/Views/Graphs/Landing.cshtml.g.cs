#pragma checksum "C:\Users\Aslam Suliman\Downloads\BID-E with DB Latest-20200522T181534Z-001\BID-E with DB Latest\Views\Graphs\Landing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebc416301ab853755d86fce4d520a49507ee18d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Graphs_Landing), @"mvc.1.0.view", @"/Views/Graphs/Landing.cshtml")]
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
#line 1 "C:\Users\Aslam Suliman\Downloads\BID-E with DB Latest-20200522T181534Z-001\BID-E with DB Latest\Views\_ViewImports.cshtml"
using BID_E;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aslam Suliman\Downloads\BID-E with DB Latest-20200522T181534Z-001\BID-E with DB Latest\Views\_ViewImports.cshtml"
using BID_E.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebc416301ab853755d86fce4d520a49507ee18d7", @"/Views/Graphs/Landing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"449f00385c1b9d3c4e1999b9b1a33c8c752aa3d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Graphs_Landing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Aslam Suliman\Downloads\BID-E with DB Latest-20200522T181534Z-001\BID-E with DB Latest\Views\Graphs\Landing.cshtml"
  
    ViewData["Title"] = "Landing";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h5>General Queries For Research</h5>
<hr class=""my-4"" />
<div>
    <p>This will be the page a user lands on when they click the Graph tab</p>
</div>
<hr class=""my-4"" />
<div>
    <p>Pre determined graphs will be displayed here. This means queries that we decide on will be displayed here every time the user logs in.</p>
    <p> Example: Number of registrations per year, Percentage of male and female exclusions. Basically Generic queries</p>
</div><br />
<div id=""chartContainer""></div>
<script type=""text/javascript"">
        window.onload = function () {
        var chart = new CanvasJS.Chart(""chartContainer"", {
            theme: ""light2"",
            animationEnabled: true,
            title: {
                text: ""Number of registrations per year""
            },
            data: [
                {
                    type: ""column"",
                    dataPoints: [
                        { x: 2008, y: 1953 },
                        { x: 2009, y: 1044 },
                    ");
            WriteLiteral(@"    { x: 2010, y: 1089 },
                        { x: 2011, y: 1112 },
                        { x: 2012, y: 1067 },
                        { x: 2013, y: 1193 },
                        { x: 2014, y: 1152 },
                        { x: 2015, y: 1307 },
                        { x: 2016, y: 1480 },
                        { x: 2017, y: 1388 },
                        { x: 2018, y: 1541 }
                    ]
                }
            ]
        });
        chart.render();
    };
</script>
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