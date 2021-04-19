using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GjirafaLMS.Models
{
    public class Lecture
    {
        [Key]
        public int LectureId { get; set; }

        [Required]
        public string LectureTitle { get; set; }

        [Required]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [Required]

        public string LectureVideoURL { get; set; }

        [Required]
        public string LectureThumbnailURL { get; set; }

        [Required]

        public string LectureDescription { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Completed> CompletedLectures { get; set; }
    }
}
