using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Member
    {
        public int ID { get; set; }

        [Display(Name="HN")]
        public string HospitalNumber { get; set; }
        
        public string Name { get; set; }
        [Display(Name="Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name="E-mail")]
        public string Email { get; set; }
    }
}