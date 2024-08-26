using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerceNEW.Shared
{
    public class UserRegister
    {
        [Required, EmailAddress(ErrorMessage = "Bitte geben Sie eine gültige E-Mail-Adresse ein!")]
        public string Email { get; set; } = string.Empty;
        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;
        [Compare("Password", ErrorMessage = "Die Passwörter stimmen nicht überein!")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
