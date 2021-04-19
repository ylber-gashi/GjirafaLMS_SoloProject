using System;
using System.ComponentModel.DataAnnotations;

namespace GjirafaLMS.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public int PostId { get; set; }
        public Post Post { get; set; }

        [Required]
        public string UserId { get; set; }
        public User User { get; set; }

        [Required]
        public string ProfileOf { get; set;}

        [Required]
        [Display(Name = "Reply message")]
        public string CommentText { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}