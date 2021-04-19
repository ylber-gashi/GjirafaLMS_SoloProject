using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GjirafaLMS.Models
{
    public class DashboardViewModel
    {
        public List<Course> Courses { get; set; }

        public int AllUsers { get; set; }

        public List<Completed> Progress { get; set; }
        public List<Participant> JoinedEvents { get; set; }
    }
}
