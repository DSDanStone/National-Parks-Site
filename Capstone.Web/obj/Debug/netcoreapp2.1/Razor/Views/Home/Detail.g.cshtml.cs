#pragma checksum "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "840b7ab55bdcf388a308380f5249936bf54eb5c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\_ViewImports.cshtml"
using Capstone.Web;

#line default
#line hidden
#line 2 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\_ViewImports.cshtml"
using Capstone.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"840b7ab55bdcf388a308380f5249936bf54eb5c1", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6dbcae0f29f69ad23437f3e0abcd65e6bbafb10", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Park>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("detail-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    //int HighTempDanger = 75;
    //int TempDifferenceAdvisory = 20;
    //int LowTempDanger = 20;

    string unit = Convert.ToString(TempData["unit"]) == "C" ? "" : "?unit=us";

#line default
#line hidden
            BeginContext(240, 29, true);
            WriteLiteral("<center><h1 class=\"outlined\">");
            EndContext();
            BeginContext(270, 10, false);
#line 10 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                        Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(280, 24, true);
            WriteLiteral("</h1></center>\r\n<center>");
            EndContext();
            BeginContext(304, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ada648698c1a438bab9125c77deea4b1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 333, "~/images/parks/", 333, 15, true);
#line 11 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
AddHtmlAttributeValue("", 348, Model.Code, 348, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 361, ".jpg", 361, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
AddHtmlAttributeValue("", 372, Model.Name, 372, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(387, 63, true);
            WriteLiteral("</center>\r\n\r\n\r\n<div class=\"card\">\r\n    <p>\r\n        Welcome to ");
            EndContext();
            BeginContext(451, 10, false);
#line 16 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(461, 16, true);
            WriteLiteral(" located in the ");
            EndContext();
            BeginContext(478, 23, false);
#line 16 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                                         Write(Model.Climate.ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(501, 12, true);
            WriteLiteral(" climate of ");
            EndContext();
            BeginContext(514, 11, false);
#line 16 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                                                                             Write(Model.State);

#line default
#line hidden
            EndContext();
            BeginContext(525, 11, true);
            WriteLiteral("!\r\n        ");
            EndContext();
            BeginContext(537, 10, false);
#line 17 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(547, 43, true);
            WriteLiteral(" joined the ranks of the National Parks in ");
            EndContext();
            BeginContext(591, 17, false);
#line 17 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                                                         Write(Model.YearFounded);

#line default
#line hidden
            EndContext();
            BeginContext(608, 23, true);
            WriteLiteral(" and covers an area of ");
            EndContext();
            BeginContext(632, 28, false);
#line 17 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                                                                                                  Write(Model.Acreage.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(660, 26, true);
            WriteLiteral(" acres at an elevation of ");
            EndContext();
            BeginContext(688, 36, false);
#line 17 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                                                                                                                                                          Write(Model.ElevationInFeet.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(725, 50, true);
            WriteLiteral("ft. above sea level.\r\n        We boast an immense ");
            EndContext();
            BeginContext(776, 18, false);
#line 18 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                       Write(Model.MilesOfTrail);

#line default
#line hidden
            EndContext();
            BeginContext(794, 25, true);
            WriteLiteral(" miles of hiking trails\r\n");
            EndContext();
#line 19 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
         if (@Model.NumberOfCampsites != 0)
        {
            

#line default
#line hidden
            BeginContext(893, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(899, 23, false);
#line 21 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                  Write(Model.NumberOfCampsites);

#line default
#line hidden
            EndContext();
            BeginContext(922, 10, true);
            WriteLiteral(" campsites");
            EndContext();
#line 21 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                                                                
        }

#line default
#line hidden
            BeginContext(952, 67, true);
            WriteLiteral("        available to the public.\r\n        You might see as many as ");
            EndContext();
            BeginContext(1020, 27, false);
#line 24 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                            Write(Model.NumberOfAnimalSpecies);

#line default
#line hidden
            EndContext();
            BeginContext(1047, 54, true);
            WriteLiteral(" types of animals here, like maybe a fox or a moose!\r\n");
            EndContext();
#line 25 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
         if (@Model.InspirationalQuoteSource != "Unknown")
        {
            

#line default
#line hidden
            BeginContext(1190, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1192, 30, false);
#line 27 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
              Write(Model.InspirationalQuoteSource);

#line default
#line hidden
            EndContext();
#line 27 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                                                         
        }
        else
        {
            

#line default
#line hidden
            BeginContext(1285, 8, true);
            WriteLiteral("Someone ");
            EndContext();
#line 31 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                                 
        }

#line default
#line hidden
            BeginContext(1313, 29, true);
            WriteLiteral("        once said about us, \"");
            EndContext();
            BeginContext(1343, 24, false);
#line 33 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                        Write(Model.InspirationalQuote);

#line default
#line hidden
            EndContext();
            BeginContext(1367, 68, true);
            WriteLiteral("\" So come check it out and see for yourself!\r\n        Admission is\r\n");
            EndContext();
#line 35 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
         if (@Model.EntryFee != 0)
        {
            

#line default
#line hidden
            BeginContext(1500, 15, true);
            WriteLiteral(" just a modest ");
            EndContext();
            BeginContext(1516, 28, false);
#line 37 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                            Write(Model.EntryFee.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1544, 2, true);
            WriteLiteral(". ");
            EndContext();
#line 37 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                                                                       
        }
        else
        {
            

#line default
#line hidden
            BeginContext(1609, 31, true);
            WriteLiteral("free, so you\'ve got no excuse! ");
            EndContext();
#line 41 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                                                        
        }

#line default
#line hidden
            BeginContext(1660, 12, true);
            WriteLiteral("        The ");
            EndContext();
            BeginContext(1673, 39, false);
#line 43 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
       Write(Model.AnnualVisitorCount.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(1712, 70, true);
            WriteLiteral(" people that come see us every year can\'t be wrong!\r\n    </p>\r\n    <p>");
            EndContext();
            BeginContext(1783, 17, false);
#line 45 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
  Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1800, 56, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<a class=\"weatherwidget-io\" id=\"weather\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1856, "\"", 1916, 4);
            WriteAttributeValue("", 1863, "https://forecast7.com/en/", 1863, 25, true);
#line 48 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
WriteAttributeValue("", 1888, Model.WeatherUrlSlice, 1888, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 1910, "/", 1910, 1, true);
#line 48 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
WriteAttributeValue("", 1911, unit, 1911, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1917, 15, true);
            WriteLiteral(" data-label_1=\"");
            EndContext();
            BeginContext(1933, 20, false);
#line 48 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                                                                                                               Write(Model.Name.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(1953, 118, true);
            WriteLiteral("\" data-label_2=\"WEATHER\" data-icons=\"Climacons Animated\" data-days=\"5\" data-theme=\"original\" data-basecolor=\"#226594\">");
            EndContext();
            BeginContext(2072, 20, false);
#line 48 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
                                                                                                                                                                                                                                                          Write(Model.Name.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(2092, 112, true);
            WriteLiteral(" WEATHER</a>\r\n\r\n<button class=\"unit-btn\" id=\"convertBtn\" onclick=\"toggleTemp();\">Convert To Celsius</button>\r\n\r\n");
            EndContext();
#line 120 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
 if (Model.MapUrlSlice != null)
{

#line default
#line hidden
            BeginContext(5213, 58, true);
            WriteLiteral("    <h3 class=\"outlined\">Get Directions:</h3>\r\n    <iframe");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5271, "\"", 5332, 2);
            WriteAttributeValue("", 5277, "https://www.google.com/maps/embed?pb=", 5277, 37, true);
#line 123 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
WriteAttributeValue("", 5314, Model.MapUrlSlice, 5314, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5333, 87, true);
            WriteLiteral(" width=\"100%\" height=\"400\" frameborder=\"0\" style=\"border:0\" allowfullscreen></iframe>\r\n");
            EndContext();
#line 124 "C:\Users\Daniel Stone\TeamExercises\c-module-3-capstone-team-8\Capstone.Web\Views\Home\Detail.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Park> Html { get; private set; }
    }
}
#pragma warning restore 1591
