#pragma checksum "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Course\AllCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f109fdf619d4d86362a6d890eaf910d5a325361"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_AllCourses), @"mvc.1.0.view", @"/Views/Course/AllCourses.cshtml")]
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
#line 1 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\_ViewImports.cshtml"
using GjirafaLMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\_ViewImports.cshtml"
using GjirafaLMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f109fdf619d4d86362a6d890eaf910d5a325361", @"/Views/Course/AllCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb12fb4cd1ed9456a3bd2c3c529c5bdd2c7bce51", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_AllCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Course\AllCourses.cshtml"
  
    Layout = "~/Views/Shared/_DashboardLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""shadow-sm mb-5"">
    <section class=""article-list bg-white"">
        <div class=""d-sm-flex justify-content-between align-items-center p-3 gradient-primary"">
            <h3>All Courses</h3>
            <div>
                <a href=""/dashboard""><button class=""btn btn-light shadow mr-2"">Dashboard</button></a>
");
#nullable restore
#line 11 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Course\AllCourses.cshtml"
                 if(User.Identity.IsAuthenticated && (User.IsInRole("Admin") || User.IsInRole("Instructor")))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"/createcourse\"><button class=\"btn btn-light shadow\">Create Course</button></a>\r\n");
#nullable restore
#line 14 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Course\AllCourses.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"container\">\r\n            <div class=\"row articles\">\r\n");
#nullable restore
#line 19 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Course\AllCourses.cshtml"
                 foreach (var course in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-sm-6 col-md-4 item shadow-sm pb-2\"><a");
            BeginWriteAttribute("href", " href=\"", 919, "\"", 950, 2);
            WriteAttributeValue("", 926, "/course/", 926, 8, true);
#nullable restore
#line 21 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Course\AllCourses.cshtml"
WriteAttributeValue("", 934, course.CourseId, 934, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 974, "\"", 1000, 1);
#nullable restore
#line 21 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Course\AllCourses.cshtml"
WriteAttributeValue("", 980, course.CourseImgURL, 980, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1036, "\"", 1067, 2);
            WriteAttributeValue("", 1043, "/course/", 1043, 8, true);
#nullable restore
#line 22 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Course\AllCourses.cshtml"
WriteAttributeValue("", 1051, course.CourseId, 1051, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h3 class=\"name\">");
#nullable restore
#line 22 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Course\AllCourses.cshtml"
                                                                       Write(course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></a>\r\n                        <p class=\"description\">");
#nullable restore
#line 23 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Course\AllCourses.cshtml"
                                          Write(course.CourseDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><a class=\"action\"");
            BeginWriteAttribute("href", "\r\n                        href=\"", 1208, "\"", 1264, 2);
            WriteAttributeValue("", 1240, "/course/", 1240, 8, true);
#nullable restore
#line 24 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Course\AllCourses.cshtml"
WriteAttributeValue("", 1248, course.CourseId, 1248, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-arrow-circle-right\"></i></a>\r\n                    </div>\r\n");
#nullable restore
#line 26 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Course\AllCourses.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
