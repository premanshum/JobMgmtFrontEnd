using Microsoft.AspNetCore.Mvc;

namespace JobManagementWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}