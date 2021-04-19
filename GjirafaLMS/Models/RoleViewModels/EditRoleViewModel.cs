using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GjirafaLMS.Models
{
    public class EditRoleViewModel
    {
        public string RoleId { get; set; }
        
        [Required]
        public string RoleName { get; set; }

        public List<User> Users { get; set; }
    }
}
