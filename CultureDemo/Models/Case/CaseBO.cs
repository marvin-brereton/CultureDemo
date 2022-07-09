using CultureDemo.Models.User;
using System.ComponentModel.DataAnnotations;
using CultureDemo.Languages;

namespace CultureDemo.Models.Case
{
    public class CaseBO : UserBO
    {
        [Required(ErrorMessageResourceName = "Case_Name_Validation", ErrorMessageResourceType = typeof(Resources))]
        [Display(Name = "Case_Name_Label", ResourceType = typeof(Resources))]
        public string Case_Name { get; set; } = "";

        [Required(ErrorMessageResourceName = "Case_Description_Validation", ErrorMessageResourceType = typeof(Resources))]
        [Display(Name = "Case_Description_Label", ResourceType = typeof(Resources))]
        public string Case_Description { get; set; } = "";

        [Display(Name = "Case_Status_Label", ResourceType = typeof(Resources))]
        public string Case_Status { get; set; } = "";

        [Display(Name = "Case_CreatedDateT_Label", ResourceType = typeof(Resources))]
        public string Case_CreatedDateT { get; set; } = "";

        [Display(Name = "Case_ModifiedDateT_Label", ResourceType = typeof(Resources))]
        public string Case_ModifiedDateT { get; set; } = "";
    }
}
