using System.ComponentModel.DataAnnotations;

namespace Events.IO.Web.Models
{
    public class RegisterViewModel : ApllicationUser
    {
        [Required(ErrorMessage = "The Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The CPF is required")]
        [StringLength(11)]
        public string CPF { get; set; }
        [Required(ErrorMessage = "The Email is required")]
        [EmailAddress(ErrorMessage = "Email in invalid format")]
        public string Email { get; private set; }
        [Required]
        [StringLength(100, ErrorMessage = "The{0} must be at least {2} and at max {1}chars long."), MinLength(2)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string Confirmpassword { get; set; }


    }
}
