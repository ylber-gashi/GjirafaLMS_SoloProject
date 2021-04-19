using System;
using System.ComponentModel.DataAnnotations;

namespace GjirafaLMS.Models
{
    public class EditLocationModel
    {
        [Required]
        public string LocUserId { get; set; }

        [Required]
        public string LocAddress { get; set; }

        [Required]
        public string LocCity { get; set; }

        [Required]
        public string LocCountry { get; set; }
    }
}
