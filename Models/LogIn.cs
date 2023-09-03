using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel.DataAnnotations;

namespace ABCareApp.Models
{
    public class LogIn
    {
        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress]
        [Display(Name = "Correo")]
        public string Email { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        [Display(Name = "Recordar datos")]
        public bool RememberMe { get; set; }

    }
}
