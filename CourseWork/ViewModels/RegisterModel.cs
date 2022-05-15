using System.ComponentModel.DataAnnotations;

namespace CourseWork.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "email not specified")]
        public string Email { get; set; }

        [Required(ErrorMessage = "password not specified")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "password entered incorrectly")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
