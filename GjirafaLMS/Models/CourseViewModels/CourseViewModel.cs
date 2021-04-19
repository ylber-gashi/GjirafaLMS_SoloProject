using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GjirafaLMS.Models
{
    public class CourseViewModel
    {
        public Course Course { get; set; }

        public Lecture Lecture { get; set; }

        public Completed Completed { get; set; }
    }
}
