using JobManagementWeb.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace JobManagementWeb.Controllers
{

    public class GroupController : BaseController
    {
        private GroupMainVM _GroupMainVM;
        private GroupVM _GroupVM;

        public IActionResult Index()
        {
            _GroupMainVM = new GroupMainVM();
            _GroupMainVM.Groups = GetGroups();
            return View(_GroupMainVM);
        }

        public IActionResult Edit(string id)
        {
            _GroupVM = GetGroups().First(p => p.GroupId == id);

            return View(_GroupVM);
        }

        public IActionResult Details(string id)
        {
            _GroupVM = GetGroups().FirstOrDefault(p => p.GroupId == id);

            if(_GroupVM == null)
            {
                return RedirectToAction(nameof(Error));
            }

            return View(_GroupVM);
        }

        [HttpGet]
        public IActionResult AddEngineer(string groupId, string engineerId)
        {
            _GroupVM = GetGroups().FirstOrDefault(p => p.GroupId == "");

            if(_GroupVM == null)
            {
                return RedirectToAction(nameof(Error));
            }

            return View(_GroupVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(int id, GroupVM groupVM)
        {
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public List<EngineerVM> GetFreePoolEngineers()
        {
            List<EngineerVM> engineerVMs = GetEngineers().Where(e => !e.IsSupervisor && e.GroupId == "grpFreePool").ToList();

            return engineerVMs;
        }

        [HttpGet]
        public PartialViewResult GetGroupEngineers(string groupId)
        {
            List<EngineerVM> engineerVMs = GetEngineers().Where(e => !e.IsSupervisor && e.GroupId == groupId).ToList();

            engineerVMs.Add(new EngineerVM { EngineerId = "en9090", EngineerName = "Ajooba", GroupId = groupId });

            return PartialView("_EngineerList", engineerVMs);
        }
    }
}