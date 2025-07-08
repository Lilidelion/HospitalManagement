using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace HospitalManagement.Controllers.BacSi
{
    [Authorize]
    public class DoctorController:Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Doctor/Index.cshtml");
        }
    }
}

