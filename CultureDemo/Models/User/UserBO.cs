using CultureDemo.Languages;
using System.ComponentModel.DataAnnotations;

namespace CultureDemo.Models.User
{
    public class UserBO
    {
        // DEMO: 2
        [Required(ErrorMessageResourceName = "FirstNameRequired", ErrorMessageResourceType = typeof(Resources))]
        [Display(Name = "FirstName", ResourceType = typeof(Resources))]
        public string User_FirstName { get; set; } = "";

        [Display(Name = "LastName", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "LastNameRequired", ErrorMessageResourceType = typeof(Resources))]
        public string User_LastName { get; set; } = "";

        [Display(Name = "CreatedBy", ResourceType = typeof(Resources))]
        public string User_CreatedBy { get; set; } = "";

        [Display(Name = "ModifiedBy", ResourceType = typeof(Resources))]
        public string User_ModifiedBy { get; set; } = "";
    }
}
