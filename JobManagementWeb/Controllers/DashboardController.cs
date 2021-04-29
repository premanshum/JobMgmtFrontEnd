using JobManagementWeb.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace JobManagementWeb.Controllers
{
    public class DashboardController : BaseController
    {
        DashboardVM _DashboardVM;
        public IActionResult Index()
        {
            _DashboardVM = new DashboardVM();
            _DashboardVM.Jobs = GetJobs();
            _DashboardVM.Groups = GetGroups();
            _DashboardVM.Group = _DashboardVM.Groups.First();
            return View(_DashboardVM);
        }
    }
}