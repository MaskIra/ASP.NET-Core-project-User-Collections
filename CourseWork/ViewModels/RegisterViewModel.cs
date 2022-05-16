using System.ComponentModel.DataAnnotations;

namespace CourseWork.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email error")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password error")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password confirm error")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
