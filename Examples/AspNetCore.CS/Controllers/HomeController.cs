using Microsoft.AspNetCore.Mvc;

namespace GleamTech.ImageUltimateExamples.AspNetCore.CS.Controllers
{
    public partial class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
