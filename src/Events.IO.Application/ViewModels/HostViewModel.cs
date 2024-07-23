using System.ComponentModel.DataAnnotations;

namespace Events.IO.Application.ViewModels
{
    public class HostViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="The Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The CPF is required")]
        [StringLength(11)]
        public string CPF { get; set; }
        [Required(ErrorMessage = "The Email is required")]
        [EmailAddress(ErrorMessage = "Email in invalid format")]
        public string Email { get; private set; }

    }
}
