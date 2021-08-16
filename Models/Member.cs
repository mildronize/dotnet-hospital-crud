using System;
using System.Collections.Generic;

namespace Hospital.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string HospitalNumber { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}