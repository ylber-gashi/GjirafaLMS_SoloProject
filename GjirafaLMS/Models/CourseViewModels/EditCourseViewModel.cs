using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GjirafaLMS.Models
{
    public class EditCourseViewModel
    {
        public Course Course { get; set; }

        public EditCourse EditCourse { get; set; }
    }
}
