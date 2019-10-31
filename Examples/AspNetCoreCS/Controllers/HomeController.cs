using Microsoft.AspNetCore.Mvc;

namespace GleamTech.ImageUltimateExamples.AspNetCoreCS.Controllers
{
    public partial class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
