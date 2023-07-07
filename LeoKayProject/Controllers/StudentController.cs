using Microsoft.AspNetCore.Mvc;

namespace LeoKayProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
