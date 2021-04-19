using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GjirafaLMS.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ProfileImgUrl { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public List<Course> CourseInstructors { get; set; }
        public List<Notification> Notifications { get; set; }

        public List<Completed> CompletedLectures { get; set; }

        public List<Post> PostsFrom { get; set; }
        public List<Post> PostsTo { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
