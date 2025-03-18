using System.ComponentModel.DataAnnotations;

namespace ASPNETCore_Localization.Models
{
    public class ContactFormViewModel
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "NameRequired")]
        public required string Name { get; set; }

        [Display(Name = "Message")]
        [Required]
        public required string Message { get; set; }
    }
}
