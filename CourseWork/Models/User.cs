using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseWork.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime Registration { get; set; }

        public DateTime Authorization { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public bool Blocked { get; set; }
    }
}
