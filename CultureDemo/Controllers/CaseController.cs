using CultureDemo.Models.Case;
using Microsoft.AspNetCore.Mvc;

namespace CultureDemo.Controllers
{
    public class CaseController : Controller
    {
        public IActionResult Index()
        {
            var caseDetails = new CaseDTO();

            var casePresenter = new CasePresenter();

            caseDetails.CaseList = casePresenter.GeneratedCaseList()
                .OrderBy(e => e.Case_CreatedDateT)
                .ToList();

            return View(caseDetails);
        }

        [HttpGet]
        public IActionResult CreateCase()
        {
            return View(new CaseDTO());
        }

        [HttpPost]
        public IActionResult CreateCase(CaseBO caseDetails)
        {
            return View(caseDetails);
        }

        public IActionResult Details(string cName, string cDesc, string cStatus, string cDateT, string mDateT, string cBy, string mBy)
        {
            var caseBO = new CaseBO
            {
                Case_Name = cName,
                Case_Description = cDesc,
                Case_Status = cStatus,
                Case_CreatedDateT = cDateT,
                Case_ModifiedDateT = mDateT,
                User_CreatedBy = cBy,
                User_ModifiedBy = mBy
            };

            return View(caseBO);
        }
    }
}
