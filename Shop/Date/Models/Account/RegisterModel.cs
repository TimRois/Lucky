using System.ComponentModel.DataAnnotations;

namespace Lucky.Date.Models.Account
{
    public class RegisterModel
    {
        

        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]

        public string Password { get; set; }

    
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }
    }
}
