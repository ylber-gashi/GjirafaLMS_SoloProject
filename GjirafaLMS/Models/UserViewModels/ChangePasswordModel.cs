using System;
using System.ComponentModel.DataAnnotations;

namespace GjirafaLMS.Models
{
    public class ChangePasswordModel
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("NewPassword", ErrorMessage = "Password doesn't match")]
        public string ConfirmPassword { get; set; }
        
    }
}
