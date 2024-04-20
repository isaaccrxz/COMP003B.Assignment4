using System.ComponentModel.DataAnnotations;
namespace COMP003B.Assignment4.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        [StringLength (100)]
        public string Address { get; set; }
    }
}
