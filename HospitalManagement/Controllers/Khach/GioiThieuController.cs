using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers.Khach
{
    public class GioiThieuController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/GioiThieu.cshtml");
        }
    }
}
