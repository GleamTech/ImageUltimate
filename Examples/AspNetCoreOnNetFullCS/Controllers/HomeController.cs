using Microsoft.AspNetCore.Mvc;

namespace GleamTech.ImageUltimateExamples.AspNetCoreOnNetFullCS.Controllers
{
    public partial class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
