using System.ComponentModel.DataAnnotations;

namespace AllForOne_Store.ViewModels
{
    public class LogInViewModel
    {
        [Required(ErrorMessage = "Email required.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
