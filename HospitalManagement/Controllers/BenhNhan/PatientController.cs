using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace HospitalManagement.Controllers.BenhNhan
{
    [Authorize]
    public class PatientController:Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Patient/Index.cshtml");
        }
    }
}
