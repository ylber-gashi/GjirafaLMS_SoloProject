using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GjirafaLMS.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public string UserIdFrom { get; set; }
        public User UserFrom { get; set; }

        [Required]
        public string UserIdTo { get; set; }
        public User UserTo { get; set; }

        [Required]
        [Display(Name = "Post text")]
        public string PostText { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Comment> Comments { get; set; }
    }
}