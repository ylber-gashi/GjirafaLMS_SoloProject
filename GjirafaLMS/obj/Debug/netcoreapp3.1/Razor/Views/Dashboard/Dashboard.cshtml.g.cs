#pragma checksum "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2003274f868738daeb325833a61621dc441d58be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Dashboard), @"mvc.1.0.view", @"/Views/Dashboard/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2003274f868738daeb325833a61621dc441d58be", @"/Views/Dashboard/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb12fb4cd1ed9456a3bd2c3c529c5bdd2c7bce51", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
  
  var user = @userManager.GetUserAsync(User).Result;
  Layout = "~/Views/Shared/_DashboardLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"<div id=""wrapper"" class=""shadow-sm mb-5"">
  <div class=""d-flex flex-column"" id=""content-wrapper"">
    <div class=""d-sm-flex justify-content-between align-items-center p-3 gradient-primary"">
      <h3>Dashboard</h3>
      <a href=""/users""><button class=""btn btn-light shadow"">Users</button></a>

    </div>
    <div id=""content"">
      <div class=""container-fluid"">
        <div class=""col-md-12"">
          <section class=""article-list bg-white"">
            <div class=""container"">
              <div class=""d-flex justify-content-between align-items-center border-bottom"">
                <h2>Latest Courses</h2>
                <a href=""/courses""><button class=""btn btn-dark"">All Courses</button></a>
              </div>
              <div class=""row articles mt-2"">
");
#nullable restore
#line 25 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                  
                  var count = Model.Courses.Count;
                  var loop = 0;
                  if(count >= 3)
                  {
                    loop = 3;
                  }else{
                    loop = count;
                  }
                for (int i = 0; i < loop; i++)
                {
                  var course = Model.Courses[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <div class=\"col-sm-6 col-md-4 item shadow-sm pb-2\"><a");
            BeginWriteAttribute("href", " href=\"", 1397, "\"", 1428, 2);
            WriteAttributeValue("", 1404, "/course/", 1404, 8, true);
#nullable restore
#line 37 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
WriteAttributeValue("", 1412, course.CourseId, 1412, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img\n                      class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1474, "\"", 1500, 1);
#nullable restore
#line 38 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
WriteAttributeValue("", 1480, course.CourseImgURL, 1480, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1531, "\"", 1562, 2);
            WriteAttributeValue("", 1538, "/course/", 1538, 8, true);
#nullable restore
#line 39 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
WriteAttributeValue("", 1546, course.CourseId, 1546, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                      <h3 class=\"name\">");
#nullable restore
#line 40 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                                  Write(course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    </a>\n                    <p class=\"description\">");
#nullable restore
#line 42 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                                      Write(course.CourseDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><a class=\"action\"");
            BeginWriteAttribute("href", "\n                    href=\"", 1742, "\"", 1793, 2);
            WriteAttributeValue("", 1769, "/course/", 1769, 8, true);
#nullable restore
#line 43 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
WriteAttributeValue("", 1777, course.CourseId, 1777, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-arrow-circle-right\"></i></a>\n                  </div>\n");
#nullable restore
#line 45 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              </div>
            </div>
          </section>
        </div>
        <div class=""row pb-5"">
          <div class=""col-md-6"">
            <div class=""card shadow border-left-warning py-2"">
              <div class=""card-body"">
                <div class=""row align-items-center no-gutters"">
                  <div class=""col mr-2"">
                    <div class=""text-uppercase text-warning font-weight-bold text-xs mb-1""><span>all students</span>
                    </div>
                    <div class=""text-dark font-weight-bold h5 mb-0""><span>");
#nullable restore
#line 59 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                                                                     Write(Model.AllUsers);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                  </div>
                  <div class=""col-auto""><i class=""fas fa-comments fa-2x text-gray-300""></i></div>
                </div>
              </div>
            </div>
          </div>
          <div class=""col-md-6"">
            <div class=""card shadow border-left-info py-2"">
              <div class=""card-body"">
                <div class=""row align-items-center no-gutters"">
                  <div class=""col mr-2"">
");
#nullable restore
#line 71 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                      
                      var progressCounter = 0.0;
                      var lectureCount = 0;
                      foreach (var course in Model.Courses)
                      {
                        lectureCount += course.Lectures.Count;
                        foreach (var progress in course.Progresses)
                        {
                          if (progress.CompletedByUserId == user.Id && progress.CourseId == course.CourseId)
                          {
                            progressCounter++;
                          }
                        }
                      }
                      var mainProgress = Math.Round((progressCounter/lectureCount * 100),2);
                      if(double.IsNaN(mainProgress))
                      {
                        mainProgress = 0;
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                      <div class=""text-uppercase text-info font-weight-bold text-xs mb-1""><span>Progress</span></div>
                    <div class=""row no-gutters align-items-center"">
                      <div class=""col-auto"">
                        <div class=""text-dark font-weight-bold h5 mb-0 mr-3""><span>");
#nullable restore
#line 93 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                                                                              Write(mainProgress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span></div>
                      </div>
                      <div class=""col"">
                        <div class=""progress progress-sm"">
                          <div class=""progress-bar bg-info"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""");
            BeginWriteAttribute("style", "\n                            style=\"", 4374, "\"", 4432, 3);
            WriteAttributeValue("", 4410, "width:", 4410, 6, true);
#nullable restore
#line 98 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
WriteAttributeValue(" ", 4416, mainProgress, 4417, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4430, "%;", 4430, 2, true);
            EndWriteAttribute();
            WriteLiteral("><span class=\"sr-only\">");
#nullable restore
#line 98 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                                                                            Write(mainProgress);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span></div>\n                        </div>\n                      </div>\n                    </div>\n");
            WriteLiteral("                  </div>\n                  <div class=\"col-auto\"><i class=\"fas fa-clipboard-list fa-2x text-gray-300\"></i></div>\n                </div>\n              </div>\n            </div>\n          </div>\n        </div>\n");
#nullable restore
#line 110 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
         if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          <div class=""row pb-4"">
            <div class=""col-md-4 offset-xl-0"">
              <p><a class=""btn btn-success btn-circle ml-1"" role=""button""><i class=""fas fa-check text-white""></i></a> <a
                href=""/Account/Register""><strong> Users</strong></a> |<small> <a href=""/Account/Register"">Add User</a></small></p>
            </div>
            <div class=""col-md-4 offset-xl-0"">
              <p><a class=""btn btn-success btn-circle ml-1"" role=""button""><i class=""fas fa-check text-white""></i></a> <a
                href=""/events""><strong> Events</strong></a> |<small> <a href=""/addevent"">Add Event</a></small></p>
            </div>
            <div class=""col-md-4"">
              <p><a href=""/allcourses"" class=""btn btn-info btn-circle ml-1"" role=""button""><i
                  class=""fas fa-info-circle text-white""></i></a><a href=""/courses""><strong> Courses</strong></a> |<small> <a
                  href=""/createcourse""> Add Course</a></small></p>
            </div>
          </div>
");
#nullable restore
#line 127 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
          <div class=""col-lg-6 mb-4"">
            <div class=""card shadow mb-4"">
              <div class=""card-header py-3"">
                <h6 class=""text-primary font-weight-bold m-0"">Course Progress</h6>
              </div>
              <div class=""card-body"">
");
#nullable restore
#line 135 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                 foreach (var course in Model.Courses)

                {

                  var result = 0.0;
                  var counter = 0.0;
                  foreach (var progress in course.Progresses)
                  {
                    
                    if (progress.CompletedByUserId == user.Id && progress.CourseId == course.CourseId)
                    {
                      counter++;
                    }
                  }
                  result = Math.Round(((counter/course.Lectures.Count) * 100), 2);
                  if(double.IsNaN(result))
                  {
                    result = 0;
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <h4 class=\"small font-weight-bold\">");
#nullable restore
#line 154 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                                                Write(course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"float-right\">");
#nullable restore
#line 154 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                                                                                            Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span></h4>\n                  <div class=\"progress mb-4\">\n                    <div class=\"progress-bar bg-danger\" aria-valuenow=\"20\" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", "\n                    style=\"", 7135, "\"", 7179, 3);
            WriteAttributeValue("", 7163, "width:", 7163, 6, true);
#nullable restore
#line 157 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
WriteAttributeValue(" ", 7169, result, 7170, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7177, "%;", 7177, 2, true);
            EndWriteAttribute();
            WriteLiteral("><span class=\"sr-only\">");
#nullable restore
#line 157 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                                                              Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span></div>\n                  </div>\n");
#nullable restore
#line 159 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              </div>
            </div>
          </div>
          <div class=""col-lg-6 mb-4"">
            <div class=""card shadow mb-4"">
              <div class=""card-header py-3"">
                <a href=""/events""><h6 class=""text-primary font-weight-bold m-0"">Scheduled Events</h6></a>
              </div>
              <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 169 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                 if(Model.JoinedEvents != null)
                { foreach (var joined in Model.JoinedEvents)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li class=\"list-group-item\">\n                    <div class=\"row align-items-center no-gutters\">\n                      <div class=\"col\">\n                        <h6 class=\"mb-0\"><a href=\"/events\"><strong>");
#nullable restore
#line 175 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                                                              Write(joined.Event.EventTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></a></h6><span class=\"text-xs\">");
#nullable restore
#line 175 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                                                                                                                              Write(joined.Event.StartTime.ToString("dddd, dd MMMM yyyy hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                      </div>\n                      <div class=\"col\">\n                        <a class=\"float-right\" target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 8248, "\"", 8278, 1);
#nullable restore
#line 178 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
WriteAttributeValue("", 8255, joined.Event.EventLink, 8255, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-google fa-2x\"></i></a>\n                      </div>\n                    </div>\n                  </li>\n");
#nullable restore
#line 182 "C:\Users\ylber\Desktop\CodingDojo\C# - .NET Core\GjirafaLMS\Views\Dashboard\Dashboard.cshtml"
                }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </ul>\n            </div>\n          </div>\n        </div>\n      </div>\n    </div>\n  </div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
