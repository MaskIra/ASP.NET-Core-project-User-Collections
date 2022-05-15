using System;
using System.Collections.Generic;

namespace CourseWork.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime Registration { get; set; }

        public DateTime Authorization { get; set; }

        public string Role { get; set; }

        public bool Blocked { get; set; }

        public ICollection<Collection> Collections { get; set; }
    }
}
