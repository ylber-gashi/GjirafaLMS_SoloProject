using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GjirafaLMS.Models
{
    public class ProfileViewModel
    {
        public List<Course> courses { get; set; }
        public User user { get; set; }
        public string userRole { get; set; }

        public Post Post { get; set; }
        public List<Post> Posts { get; set; }
        public Comment Comment { get; set; }
    }
}
