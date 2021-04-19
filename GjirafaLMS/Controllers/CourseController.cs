using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GjirafaLMS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using GjirafaLMS.Data;
using Microsoft.EntityFrameworkCore;

namespace GjirafaLMS.Controllers
{
    public class CourseController : Controller
    {
        private readonly LMSContext context;

        public CourseController(LMSContext context)
        {
            this.context = context;
        }

        [HttpGet("course/{courseId}")]
        public IActionResult CourseView(int courseId)
        {
            CourseViewModel courseViewModel = new CourseViewModel();
            courseViewModel.Course = context.Courses.Include(c => c.Lectures).ThenInclude(l => l.CompletedLectures).FirstOrDefault(c => c.CourseId == courseId);
            return View(courseViewModel);
        }

        [HttpGet("courses")]
        public IActionResult AllCourses()
        {
            List<Course> courses = context.Courses.ToList();
            return View(courses);
        }

        [HttpGet("createcourse")]
        [Authorize(Roles = "Admin,Instructor")]
        public IActionResult CreateCourse()
        {
            return View();
        }

        [HttpPost("search")]
        public IActionResult SearchCourse(string query)
        {
            List<Course> courses = context.Courses.Where(c => c.CourseName.Contains(query)).ToList();
            return View("AllCourses", courses);
        }

        [HttpPost("createcourse")]
        [Authorize(Roles = "Admin,Instructor")]
        public IActionResult CreateCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                context.Courses.Add(course);
                context.SaveChanges();
                return RedirectToAction("CourseView", new { courseId = course.CourseId });
            }
            return View();
        }


        [HttpGet("editcourse/{courseId}")]
        [Authorize(Roles = "Admin,Instructor")]
        public IActionResult EditCourse(int courseId)
        {
            EditCourseViewModel editCourseView = new EditCourseViewModel();
            editCourseView.Course = context.Courses.FirstOrDefault(c => c.CourseId == courseId);
            return View(editCourseView);
        }

        [HttpPost("saveEdit")]
        [Authorize(Roles = "Admin,Instructor")]
        public IActionResult SaveEdit(EditCourseViewModel editCourseView)
        {
            if (ModelState.IsValid)
            {
                Course course1 = context.Courses.FirstOrDefault(c => c.CourseId == editCourseView.EditCourse.CourseId);
                course1.CourseName = editCourseView.EditCourse.CourseName;
                course1.CourseCategory = editCourseView.EditCourse.CourseCategory;
                course1.CourseTechnology = editCourseView.EditCourse.CourseTechnology;
                course1.CourseInstructorId = editCourseView.EditCourse.CourseInstructorId;
                course1.CourseImgURL = editCourseView.EditCourse.CourseImgURL;
                course1.CourseDescription = editCourseView.EditCourse.CourseDescription;
                context.SaveChanges();
                return RedirectToAction("CourseView", new { courseId = editCourseView.EditCourse.CourseId });
            }
            EditCourseViewModel editCourseView1 = new EditCourseViewModel();
            editCourseView1.Course = context.Courses.FirstOrDefault(c => c.CourseId == editCourseView.EditCourse.CourseId);
            return View("EditCourse", editCourseView1);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Instructor")]
        public IActionResult AddLecture(CourseViewModel courseView)
        {
            if (ModelState.IsValid)
            {
                context.Lectures.Add(courseView.Lecture);
                context.SaveChanges();
                return RedirectToAction("CourseView", new { courseId = courseView.Lecture.CourseId });
            }
            CourseViewModel courseViewModel = new CourseViewModel();
            courseViewModel.Course = context.Courses.Include(c => c.Lectures).FirstOrDefault(c => c.CourseId == courseView.Lecture.CourseId);
            return View("CourseView", courseViewModel);
        }

        [HttpPost("complete")]
        public IActionResult CompleteLecture(CourseViewModel courseView)
        {
            if (ModelState.IsValid)
            {
                Completed completed = context.CompletedLectures.FirstOrDefault(c => c.CompletedLectureId == courseView.Completed.CompletedLectureId && c.CompletedByUserId == courseView.Completed.CompletedByUserId);
                if (completed == null)
                {
                    context.CompletedLectures.Add(courseView.Completed);
                    context.SaveChanges();
                    return RedirectToAction("CourseView", new { courseId = courseView.Completed.CourseId });
                }
                return RedirectToAction("CourseView", new { courseId = courseView.Completed.CourseId });
            }
            CourseViewModel courseViewModel = new CourseViewModel();
            courseViewModel.Course = context.Courses.Include(c => c.Lectures).ThenInclude(l => l.CompletedLectures).FirstOrDefault(c => c.CourseId == courseView.Lecture.CourseId);
            return View("CourseView", courseViewModel);
        }
    }
}
