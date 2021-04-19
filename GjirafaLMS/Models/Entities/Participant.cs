using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GjirafaLMS.Models
{
    public class Participant
    {
        [Key]
        public int ParticipantId { get; set; }

        [Required]
        public int EventId { get; set; }
        public Event Event { get; set; }

        [Required]
        public string UserId { get; set; }
        public User User { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}