using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GjirafaLMS.CustomValidation;
using Microsoft.AspNetCore.Identity;

namespace GjirafaLMS.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        public string EventTitle { get; set; }

        public string EventLink { get; set; }

        [Required]
        [FutureDate]
        public DateTime StartTime { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value greater than 0")]
        public int Duration {get; set;}

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        [MaxLength(20)]
        public string Description { get; set; }

        [Required]
        public string DurationType { get; set; }

        [Required]
        public string EventCreatorId { get; set; }
        public User EventCreator { get; set; }
        public List<Participant> Participants {get; set;}
        public List<Notification> Notifications {get; set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
