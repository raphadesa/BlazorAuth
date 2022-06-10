using System.ComponentModel.DataAnnotations;

namespace BlazorAuth.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Please provide your login !")]
        public string login { get; set; } = "johndoe@contoso.com";
        [Required(ErrorMessage = "Please provide your password !")]
        public string password { get; set; } = "test";
    }
}
