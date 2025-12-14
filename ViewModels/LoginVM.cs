using System.ComponentModel.DataAnnotations;

namespace Todo_SRP_DIP.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Username obligatoire")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password obligatoire")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
