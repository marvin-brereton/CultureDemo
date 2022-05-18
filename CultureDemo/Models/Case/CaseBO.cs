using CultureDemo.Models.User;
using System.ComponentModel.DataAnnotations;
using CultureDemo.Languages;

namespace CultureDemo.Models.Case
{
    public class CaseBO : UserBO
    {
        [Required(ErrorMessageResourceName = "CaseNameRequired", ErrorMessageResourceType = typeof(Resources))]
        [Display(Name = "CaseName", ResourceType = typeof(Resources))]
        public string Case_Name { get; set; } = "";

        [Required(ErrorMessageResourceName = "CaseDescriptionRequired", ErrorMessageResourceType = typeof(Resources))]
        [Display(Name = "CaseDescription", ResourceType = typeof(Resources))]
        public string Case_Description { get; set; } = "";

        [Display(Name = "CaseStatus", ResourceType = typeof(Resources))]
        public string Case_Status { get; set; } = "";

        [Display(Name = "CaseCreatedDateT", ResourceType = typeof(Resources))]
        public string Case_CreatedDateT { get; set; } = "";

        [Display(Name = "CaseModifiedDateT", ResourceType = typeof(Resources))]
        public string Case_ModifiedDateT { get; set; } = "";
    }
}
