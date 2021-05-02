using JobManagementWeb.Infrastructure.Interfaces.Services;
using JobManagementWeb.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace JobManagementWeb.Controllers
{
    public class DashboardController : BaseController
    {
        DashboardVM _DashboardVM;

        public DashboardController(
            ISessionValues sessionValues,
            ILogger<DashboardController> logger) : base(sessionValues, logger)
        {
        }

        public IActionResult Index()
        {
            ViewData["User"] = SessionValues.UserId;
            var name = HttpContext.Session.GetString("UserId");
            _DashboardVM = new DashboardVM();
            _DashboardVM.Jobs = GetJobs();
            _DashboardVM.Groups = GetGroups();
            _DashboardVM.Group = _DashboardVM.Groups.First();
            return View(_DashboardVM);
        }
    }
}