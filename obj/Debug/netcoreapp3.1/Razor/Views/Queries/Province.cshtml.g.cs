#pragma checksum "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "033f53879ace647038afeda5295542fcd0c78bbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Queries_Province), @"mvc.1.0.view", @"/Views/Queries/Province.cshtml")]
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
#line 1 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\_ViewImports.cshtml"
using BID_E;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\_ViewImports.cshtml"
using BID_E.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033f53879ace647038afeda5295542fcd0c78bbb", @"/Views/Queries/Province.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"449f00385c1b9d3c4e1999b9b1a33c8c752aa3d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Queries_Province : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "033f53879ace647038afeda5295542fcd0c78bbb3380", async() => {
                WriteLiteral(@"
    <script src=""//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>
    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
    <script type=""text/javascript"">
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.load('current', { 'packages': ['bar'] });

        JSONExcluded = '");
#nullable restore
#line 10 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml"
                   Write(Html.Raw(Json.Serialize(ViewBag.Excluded)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        console.log(JSONExcluded);
        var Excluded = [];
        Excluded.push(['Year', 'Number']);
        $.each(JSON.parse(JSONExcluded), function (index, val) {
            var arrExcluded = [];
            arrExcluded.push(val.reg_End);
            arrExcluded.push(val.count);
            Excluded.push(arrExcluded);
        });

        JSONQualified = '");
#nullable restore
#line 21 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml"
                    Write(Html.Raw(Json.Serialize(ViewBag.Qualified)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        console.log(JSONQualified);
        var Qualified = [];
        Qualified.push(['Year', 'Number']);
        $.each(JSON.parse(JSONQualified), function (index, val) {
            var arrQualified = [];
            arrQualified.push(val.reg_End);
            arrQualified.push(val.count);
            Qualified.push(arrQualified);
        });

        JSONProceed = '");
#nullable restore
#line 32 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml"
                  Write(Html.Raw(Json.Serialize(ViewBag.Proceed)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        console.log(JSONProceed);
        var Proceed = [];
        Proceed.push(['Year', 'Number']);
        $.each(JSON.parse(JSONProceed), function (index, val) {
            var arrProceed = [];
            arrProceed.push(val.reg_End);
            arrProceed.push(val.count);
            Proceed.push(arrProceed);
        });

        JSONNotCategorised = '");
#nullable restore
#line 43 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml"
                         Write(Html.Raw(Json.Serialize(ViewBag.NotCategorised)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        console.log(JSONNotCategorised);
        var NotCategorised = [];
        NotCategorised.push(['Year', 'Number']);
        $.each(JSON.parse(JSONNotCategorised), function (index, val) {
            var arrNotCategorised = [];
            arrNotCategorised.push(val.reg_End);
            arrNotCategorised.push(val.count);
            NotCategorised.push(arrNotCategorised);
        });

        JSONMale = '");
#nullable restore
#line 54 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml"
               Write(Html.Raw(Json.Serialize(ViewBag.Male)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        console.log(JSONMale);
        var Male = [];
        Male.push(['Outcome', 'Number']);
        $.each(JSON.parse(JSONMale), function (index, val) {
            var arrMale = [];
            arrMale.push(val.outcome);
            arrMale.push(val.count);
            Male.push(arrMale);
        });

        JSONFemale = '");
#nullable restore
#line 65 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml"
                 Write(Html.Raw(Json.Serialize(ViewBag.Female)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        console.log(JSONFemale);
        var Female = [];
        Female.push(['Outcome', 'Number']);
        $.each(JSON.parse(JSONFemale), function (index, val) {
            var arrFemale = [];
            arrFemale.push(val.outcome);
            arrFemale.push(val.count);
            Female.push(arrFemale);
        });

        console.log();

        google.charts.setOnLoadCallback(drawExcluded);
        function drawExcluded() {
            var data = google.visualization.arrayToDataTable(Excluded);
            var materialOptions = {
                title: 'Students Excluded in ");
#nullable restore
#line 82 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml"
                                        Write(ViewBag.MyString);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                legend: { position: 'none' },
                colors: ['#DC3912'],
            };
            var materialChart = new google.visualization.LineChart(document.getElementById('barExcluded'));
            materialChart.draw(data, materialOptions);
        }
        google.charts.setOnLoadCallback(drawQualified);
        function drawQualified() {
            var data = google.visualization.arrayToDataTable(Qualified);
            var materialOptions = {
                title: 'Students Qualified in ");
#nullable restore
#line 93 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml"
                                         Write(ViewBag.MyString);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                legend: { position: 'none' },
                colors: ['#109618'],
            };
            var materialChart = new google.visualization.LineChart(document.getElementById('barQualified'));
            materialChart.draw(data, materialOptions);
        }
        google.charts.setOnLoadCallback(drawProceed);
        function drawProceed() {
            var data = google.visualization.arrayToDataTable(Proceed);
            var materialOptions = {
                title: 'Students Proceed in ");
#nullable restore
#line 104 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml"
                                       Write(ViewBag.MyString);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                legend: { position: 'none' },
                colors: ['#3366CC'],
            };
            var materialChart = new google.visualization.LineChart(document.getElementById('barProceed'));
            materialChart.draw(data, materialOptions);
        }
        google.charts.setOnLoadCallback(drawNotCategorised);
        function drawNotCategorised() {
            var data = google.visualization.arrayToDataTable(NotCategorised);
            var materialOptions = {
                title: 'Students Not Categorised in ");
#nullable restore
#line 115 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml"
                                               Write(ViewBag.MyString);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                legend: { position: 'none' },
                colors: ['#FF9900'],
            };
            var materialChart = new google.visualization.LineChart(document.getElementById('barNotCategorised'));
            materialChart.draw(data, materialOptions);
        }

        google.charts.setOnLoadCallback(drawMale);
        function drawMale() {
            var data = google.visualization.arrayToDataTable(Male);
            var options = {
                title: 'Percentage of progression outcomes for Male students in ");
#nullable restore
#line 127 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml"
                                                                           Write(ViewBag.MyString);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                pieHole: 0.3,
                colors: ['#DC3912', '#FF9900', '#3366CC', '#109618'],

            };
            var chart = new google.visualization.PieChart(document.getElementById('piechartMale'));
            chart.draw(data, options);
        }

        google.charts.setOnLoadCallback(drawFemale);
        function drawFemale() {
            var data = google.visualization.arrayToDataTable(Female);
            var options = {
                title: 'Percentage of progression outcomes for Female students in ");
#nullable restore
#line 140 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml"
                                                                             Write(ViewBag.MyString);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                pieHole: 0.3,
                colors: ['#DC3912', '#FF9900', '#3366CC', '#109618'],

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "033f53879ace647038afeda5295542fcd0c78bbb14140", async() => {
                WriteLiteral("\r\n    <h4>");
#nullable restore
#line 152 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml"
   Write(ViewBag.MyString);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h4><br />
    <table class=""columns"">
        <tr>
            <td><div id=""barExcluded"" style=""width: 500px; height: 500px;border: 1px solid #ccc""></div></td>
            <td><div id=""barQualified"" style=""width: 500px; height: 500px;border: 1px solid #ccc""></div></td>
        </tr>
    </table>
    <table class=""columns"">
        <tr>
            <td><div id=""barProceed"" style=""width: 500px; height: 500px;border: 1px solid #ccc""></div></td>
            <td><div id=""barNotCategorised"" style=""width: 500px; height: 500px;border: 1px solid #ccc""></div></td>
        </tr>
    </table>
    <hr class=""my-4"" />
    <h5>Progression of outcomes by Gender</h5>
    <br />
    <table class=""columns"">
        <tr>
            <td><div id=""piechartMale"" style=""width: 500px; height: 300px;border: 1px solid #ccc""></div></td>
            <td><div id=""piechartFemale"" style=""width: 500px; height: 300px;border: 1px solid #ccc""></div></td>
        </tr>
    </table>
    <hr class=""my-4"" /><br />
    <butt");
                WriteLiteral("on class=\"btn btn-dark\" type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 7387, "\"", 7446, 3);
                WriteAttributeValue("", 7397, "location.href=\'", 7397, 15, true);
#nullable restore
#line 175 "C:\Users\craig\Desktop\Computer Science\COMS3009A Software Design 2020\SD Project\SD-Runtime-Terror-\Views\Queries\Province.cshtml"
WriteAttributeValue("", 7412, Url.Action("Landing", "Queries"), 7412, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7445, "\'", 7445, 1, true);
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
            WriteLiteral("\r\n</html> ");
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
