using System;
using System.ComponentModel.DataAnnotations;

namespace GjirafaLMS.Models
{
    public class EditInfoModel
    {
        [Required]
        public string InfoUserId { get; set; }
        
        [Required]
        [MaxLength(30)]
        [Display(Name = "First Name")]
        public string InfoFirstName { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Last Name")]
        public string InfoLastName { get; set; }

        [Required]
        public string InfoProfileImgUrl { get; set; }

        [Required]
        [EmailAddress]
        public string InfoEmail { get; set; }
    }
}
