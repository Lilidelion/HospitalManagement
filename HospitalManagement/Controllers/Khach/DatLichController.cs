using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers.Khach
{
    public class DatLichController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/DatLich.cshtml");
        }
    }
}
