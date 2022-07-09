using CultureDemo.Languages;
using System.ComponentModel.DataAnnotations;

namespace CultureDemo.Models.User
{
    public class UserBO
    {
        // DEMO: 2
        [Required(ErrorMessageResourceName = "User_FirstName_Validation", ErrorMessageResourceType = typeof(Resources))]
        [Display(Name = "User_FirstName_Label", ResourceType = typeof(Resources))]
        public string User_FirstName { get; set; } = "";

        [Display(Name = "User_LastName_Label", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "User_LastName_Validation", ErrorMessageResourceType = typeof(Resources))]
        public string User_LastName { get; set; } = "";

        [Display(Name = "User_CreatedBy_Label", ResourceType = typeof(Resources))]
        public string User_CreatedBy { get; set; } = "";

        [Display(Name = "User_ModifiedBy_Label", ResourceType = typeof(Resources))]
        public string User_ModifiedBy { get; set; } = "";
    }
}
