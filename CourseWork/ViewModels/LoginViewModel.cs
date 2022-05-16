using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CourseWork.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email error")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password error")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
