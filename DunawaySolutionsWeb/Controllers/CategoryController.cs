using Microsoft.AspNetCore.Mvc;

namespace DunawaySolutionsWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
