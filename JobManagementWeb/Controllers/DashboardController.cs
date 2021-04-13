using JobManagementWeb.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobManagementWeb.Controllers
{
    public class DashboardController : BaseController
    {
        DashboardVM _DashboardVM;
        public IActionResult Index()
        {
            _DashboardVM = new DashboardVM();
            _DashboardVM.Jobs = GetJobs();
            return View(_DashboardVM);
        }
    }
}