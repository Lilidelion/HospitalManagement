using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace HospitalManagement.Controllers.QuanTri
{

        [Authorize]
        public class AdminController : Controller
        {
            public ActionResult Index()
            {
                return View("~/Views/Admin/Index.cshtml");
            }
        }
    }

