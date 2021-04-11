using JobManagementWeb.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobManagementWeb.Controllers
{
    public class JobAssignmentController : Controller
    {
        JobAssignmentVM _JobAssignmentVM;
        public IActionResult Index()
        {
            _JobAssignmentVM = new JobAssignmentVM();
            return View(_JobAssignmentVM);
        }
    }
}