using Microsoft.AspNetCore.Mvc;

namespace JobManagementWeb.Controllers
{
    public class AdminController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}