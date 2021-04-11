using JobManagementWeb.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace JobManagementWeb.Controllers
{
    public class JobAssignmentController : BaseController
    {
        JobAssignmentVM _JobAssignmentVM;
        public IActionResult Index()
        {
            _JobAssignmentVM = new JobAssignmentVM();
            _JobAssignmentVM.Jobs = GetJobs();
            return View(_JobAssignmentVM);
        }

        public IActionResult Assign(string id)
        {
            _JobAssignmentVM = new JobAssignmentVM();
            var jobVM = GetJobs().FirstOrDefault(j => j.JobId == id);
            _JobAssignmentVM.Job = jobVM;
            _JobAssignmentVM.Engineers = GetEngineers();

            return View(_JobAssignmentVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, JobVM job)
        {
            _JobAssignmentVM = new JobAssignmentVM();
            _JobAssignmentVM.Jobs = GetJobs();
            return RedirectToAction(nameof(Index));
        }
    }
}