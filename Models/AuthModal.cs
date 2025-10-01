using System.ComponentModel.DataAnnotations;

namespace FirstProject.Models
{
  
    public class Loginreq
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class Loginres
    {
        public int Statuscode { get; set; }
        public string msg { get; set; }
    }
    public class Users
    {
        [Required(ErrorMessage ="Name is required.")]
        public string Full_Name { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage ="Your Email is Invalid")]
        public string  Email{ get; set; }
        [Required(ErrorMessage = "Email is required")]
        [Phone(ErrorMessage ="Your Phone number is Invalid")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,20}$",
        ErrorMessage = "Password must be 6-20 characters, include uppercase, lowercase, number, and special character.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Plese Confirm your password")]
        [Compare("Password", ErrorMessage ="This is not matching password")]

        public string Confirm_Password { get; set; }
        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

    }
}
