using System.ComponentModel.DataAnnotations;

namespace Zambia_Police_Service_Repository.DALL.Models
{
    public class Register
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = " Password")]
        public string Password { get; set; }

        [Display(Name = "Comfirm-Password")]
        [DataType(DataType.Password)]
        [Compare("Password",
            ErrorMessage = "Two Passwords did not match")]
        public string ComfirmPassword { get; set; }
    }
}
