using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using JobBoardApp.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JobBoardApp.Models;

namespace JobBoardApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRepositoryWrapper _repoWrapper;

        public HomeController(ILogger<HomeController> logger, IRepositoryWrapper repoWrapper)
        {
            _logger = logger;
            _repoWrapper = repoWrapper;
        }

        public IActionResult Index()
        {
            var test = _repoWrapper.JobBoard.FindAll();
            return View(_repoWrapper.JobBoard.FindAll());
        }
        
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(JobBoard model)
        {
            _repoWrapper.JobBoard.Create(model);
            _repoWrapper.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid id)
        {
            return View(_repoWrapper.JobBoard
                .FindByCondition(x => x.Id.Equals(id))
                .FirstOrDefault());
        }
        
        [HttpPost]
        public IActionResult Edit(JobBoard model)
        {
            _repoWrapper.JobBoard.Update(model);
            _repoWrapper.Save();
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(Guid id)
        {
            _repoWrapper.JobBoard.Delete(_repoWrapper.JobBoard
                .FindByCondition(x => x.Id.Equals(id))
                .FirstOrDefault());
            _repoWrapper.Save();
            return RedirectToAction("Index");
        }
    }
}
