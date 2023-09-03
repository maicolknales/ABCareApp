using System.ComponentModel.DataAnnotations;

namespace ABCareApp.Models
{
    public class UserRegister
    {
        public UserRegister()
        {
            Password = "Admin";
        }
        //[Required(ErrorMessage = "El nickname es obligatorio")]
        //[StringLength(50, ErrorMessage = "El {0} debe estar entre al menos 5 caracteres de longitud", MinimumLength = 5)]
        //public string UserName { get; set; }
        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress]
        public string Email { get; set; }
        //[Required(ErrorMessage = "La contraseña es obligatoria")]
        //[StringLength(50, ErrorMessage = "El {0} debe estar entre al menos 5 caracteres de longitud", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //[Required(ErrorMessage = "La confirmacion de contraseña es obligatoria")]
        //[Compare("Password", ErrorMessage = "La contraseña y confirmacion de contraseña no coinciden")]
        //[DataType(DataType.Password)]
        //public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El segundo nombre es obligatorio")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "El segundo apellido es obligatorio")]
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; }

    }
}
