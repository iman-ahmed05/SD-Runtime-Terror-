#pragma checksum "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\BID-E\Views\Queries\Age.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd9ad082dd84dd3386342859393a1afdf585869e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Queries_Age), @"mvc.1.0.view", @"/Views/Queries/Age.cshtml")]
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
#line 1 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\BID-E\Views\_ViewImports.cshtml"
using BID_E;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\BID-E\Views\_ViewImports.cshtml"
using BID_E.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd9ad082dd84dd3386342859393a1afdf585869e", @"/Views/Queries/Age.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"449f00385c1b9d3c4e1999b9b1a33c8c752aa3d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Queries_Age : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\BID-E\Views\Queries\Age.cshtml"
  
    ViewData["Title"] = "Age";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd9ad082dd84dd3386342859393a1afdf585869e3668", async() => {
                WriteLiteral(@"
    <script src=""//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>
    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
    <script type=""text/javascript"">
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.load('current', { 'packages': ['bar'] });

        //Read data from ViewBag into array
        JSONAge = '");
#nullable restore
#line 15 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\BID-E\Views\Queries\Age.cshtml"
              Write(Html.Raw(Json.Serialize(ViewBag.Age)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        console.log(JSONAge);
        var Age = [];
        Age.push(['Age', 'Number']);
        $.each(JSON.parse(JSONAge), function (index, val) {
            var arrAge = [];
            arrAge.push(val.end_Age);
            arrAge.push(val.count);
            Age.push(arrAge);
        });

        JSONMale = '");
#nullable restore
#line 26 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\BID-E\Views\Queries\Age.cshtml"
               Write(Html.Raw(Json.Serialize(ViewBag.Male)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        console.log(JSONMale);
        var Male = [];
        Male.push(['Age', 'Number']);
        $.each(JSON.parse(JSONMale), function (index, val) {
            var arrMale = [];
            arrMale.push(val.end_Age);
            arrMale.push(val.count);
            Male.push(arrMale);
        });

        JSONFemale = '");
#nullable restore
#line 37 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\BID-E\Views\Queries\Age.cshtml"
                 Write(Html.Raw(Json.Serialize(ViewBag.Female)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        console.log(JSONFemale);
        var Female = [];
        Female.push(['Age', 'Number']);
        $.each(JSON.parse(JSONFemale), function (index, val) {
            var arrFemale = [];
            arrFemale.push(val.end_Age);
            arrFemale.push(val.count);
            Female.push(arrFemale);
        });

        //Draw Google chart
        google.charts.setOnLoadCallback(drawBar);
        function drawBar() {
            var data = google.visualization.arrayToDataTable(Age);
            var materialOptions = {
                bars: 'horizontal',
                legend: { position: 'none' },
                colors: ['#DD4477'],
            };
            var materialChart = new google.charts.Bar(document.getElementById('Bar'));
            materialChart.draw(data, materialOptions);
        }

        google.charts.setOnLoadCallback(drawMale);
        function drawMale() {
            var data = google.visualization.arrayToDataTable(Male);
            var options = ");
                WriteLiteral(@"{
                title: ' Percentage of Male Students Excluded at Different Ages',
                pieHole: 0.3,
            };
            var chart = new google.visualization.PieChart(document.getElementById('piechartMale'));
            chart.draw(data, options);
        }

        google.charts.setOnLoadCallback(drawFemale);
        function drawFemale() {
            var data = google.visualization.arrayToDataTable(Female);
            var options = {
                title: ' Percentage of Female Students Excluded at Different Ages',
                pieHole: 0.3,
            };
            var chart = new google.visualization.PieChart(document.getElementById('piechartFemale'));
            chart.draw(data, options);
        }
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd9ad082dd84dd3386342859393a1afdf585869e8503", async() => {
                WriteLiteral("\r\n    <h3>Students between age ");
#nullable restore
#line 85 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\BID-E\Views\Queries\Age.cshtml"
                        Write(ViewBag.MyString);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
    <hr class=""my-4"" />
    <h5>Number of students Excluded</h5>
    <br />
    <div id=""Bar"" style=""width: 1100px; height: 500px;""></div>
    <hr class=""my-4"" />
    <table class=""columns"">
        <tr>
            <td><div id=""piechartMale"" style=""width: 550px; height: 300px;border: 1px solid #ccc""></div></td>
            <td><div id=""piechartFemale"" style=""width: 550px; height: 300px;border: 1px solid #ccc""></div></td>
        </tr>
    </table>
    <hr class=""my-4"" /><br />
    <button class=""btn btn-dark"" type=""button""");
                BeginWriteAttribute("onclick", " onclick=\"", 3721, "\"", 3780, 3);
                WriteAttributeValue("", 3731, "location.href=\'", 3731, 15, true);
#nullable restore
#line 98 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\BID-E\Views\Queries\Age.cshtml"
WriteAttributeValue("", 3746, Url.Action("Landing", "Queries"), 3746, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3779, "\'", 3779, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Return</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html> \r\n");
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
