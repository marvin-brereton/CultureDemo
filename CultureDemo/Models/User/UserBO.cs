using System.ComponentModel.DataAnnotations;

namespace CultureDemo.Models.User
{
    public class UserBO
    {
        [Required(ErrorMessage = "FirstNameRequired")]
        [Display(Name = "FirstName")]
        public string User_FirstName { get; set; } = "";

        [Display(Name = "SecondName")]
        [Required(ErrorMessage = "SecondNameRequired")]
        public string User_LastName { get; set; } = "";

        [Display(Name = "CreatedBy")]
        public string User_CreatedBy { get; set; } = "";

        [Display(Name = "ModifiedBy")]
        public string User_ModifiedBy { get; set; } = "";
    }
}
