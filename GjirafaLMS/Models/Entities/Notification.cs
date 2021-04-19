using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GjirafaLMS.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        public string NotificationTitle { get; set; }

        [Required]
        public string NotificationForUserId { get; set; }
        public User NotificationForUser { get; set; }

        public string PathToURL { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
