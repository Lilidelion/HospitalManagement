using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers.Khach
{
    public class TinTucController : Controller
    {
        public IActionResult Index()
        {
           

            return View("~/Views/Home/TinTuc.cshtml");
        }
    }
}
