using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class EmployeeVM
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        public string Email { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string Firstname { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "Tax ID")]
        public string TaxId { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Date Joined")]
        public DateTime DateJoined { get; set; }

    }
}
