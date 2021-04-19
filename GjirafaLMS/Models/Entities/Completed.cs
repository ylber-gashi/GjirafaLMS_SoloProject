using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GjirafaLMS.Models
{
    public class Completed
    {
        [Key]
        public int CompletedId { get; set; }

        [Required]
        public int CompletedLectureId { get; set; }
        public Lecture CompletedLecture { get; set; }

        [Required]
        public string CompletedByUserId { get; set; }

        public User CompletedByUser { get; set; }

        [Required]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
