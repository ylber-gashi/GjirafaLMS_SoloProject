using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GjirafaLMS.Models
{
    public class EditCourse
    {
        public int CourseId { get; set; }

        [Required]
        [MaxLength(30)]
        public string CourseName { get; set; }

        [Required]
        [MaxLength(12)]
        public string CourseCategory { get; set; }

        [Required]
        [MaxLength(20)]
        public string CourseTechnology { get; set; }
        
        [Required]
        public string CourseInstructorId { get; set; }
        public User CourseInstructor { get; set; }

        [Required]
        public string CourseImgURL { get; set; }

        [Required]
        public string CourseDescription { get; set; }
    }
}
