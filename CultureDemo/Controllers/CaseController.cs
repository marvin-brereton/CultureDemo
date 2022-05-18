using CultureDemo.Models.Case;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace CultureDemo.Controllers
{
    public class CaseController : Controller
    {
        CasePresenter _casePresenter;
        private readonly IStringLocalizer<CaseController> _localizer;
        ResourceManager resourceManager;

        public CaseController(IStringLocalizer<CaseController> localizer)
        {
            _casePresenter = new CasePresenter();
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            var caseDetails = new CaseDTO();

            caseDetails.WelcomeMessage = _localizer["WelcomeMessage"];

            caseDetails.CaseList = _casePresenter.GeneratedCaseList()
                .OrderBy(e => e.Case_CreatedDateT)
                .ToList();

            return View(caseDetails);
        }

        [HttpGet]
        public IActionResult CreateCase()
        {
            return View(new CaseBO());
        }

        [HttpPost]
        public IActionResult CreateCase(CaseBO caseDetails)
        {
            if (ModelState.IsValid && _casePresenter.IsCaseValid(caseDetails))
            {
                caseDetails = _casePresenter.PopulateCreateDummyData(caseDetails);

                return RedirectToAction(nameof(Details), caseDetails);
            }
            else
            {
                return View(caseDetails);
            }
        }

        public IActionResult DetailsFromList(string cName, string cDesc, string cStatus, string cDateT, string mDateT, string cBy, string mBy)
        {
            var caseDetails = new CaseBO
            {
                Case_Name = cName,
                Case_Description = cDesc,
                Case_Status = cStatus,
                Case_CreatedDateT = cDateT,
                Case_ModifiedDateT = mDateT,
                User_CreatedBy = cBy,
                User_ModifiedBy = mBy
            };

            if (_casePresenter.IsCaseValid(caseDetails))
            {
                return RedirectToAction(nameof(Details), caseDetails);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Details(CaseBO caseDetails)
        {
            return View(caseDetails);
        }
    }
}
